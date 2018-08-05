using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;

namespace OpticalFlowForm
{
    public partial class OpticalFlowForm : Form
    {
        VideoCapture capture;
        bool Pause = false;
        Image<Gray, byte> _currentImage;
        Image<Gray, byte> _lastImage;
        Image<Gray, float> velx;
        Image<Gray, float> vely;
        Image<Bgr, byte> _inputImage;
        int count = 0;

        public OpticalFlowForm()
        {
            InitializeComponent();
            
            StripMenuItem_Video_Pause.Enabled = Pause;
            StripMenuItem_Video_Play.Enabled = false;
            StripMenuItem_Video_Stop.Enabled = false;
        }

        private void StripMenuItem_Camera_Open_Click(object sender, EventArgs e)
        {
            
        }

        private void StripMenuItem_Video_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                capture = new VideoCapture(ofd.FileName);
                Mat m = new Mat();
                capture.Read(m);
                _inputImage = m.ToImage<Bgr, byte>();
                Image<Gray, byte> grayImage = m.ToImage<Gray, byte>();
                _lastImage = grayImage;
                
                pictureBox_Source.Image = m.Bitmap;
                StripMenuItem_Video_Play.Enabled = true;
            }
        }

        private async void StripMenuItem_Video_Play_Click(object sender, EventArgs e)
        {
            if(capture == null)
            {
                MessageBox.Show("Please Load Video File");
                return;
            }

            Pause = false;
            StripMenuItem_Video_Pause.Enabled = !Pause;
            StripMenuItem_Video_Play.Enabled = false;
            StripMenuItem_Video_Stop.Enabled = true;

            try
            {
                while (!Pause)
                {
                    Mat m = new Mat();
                    capture.Read(m);
                    _inputImage = m.ToImage<Bgr, byte>();

                    if (!m.IsEmpty)
                    {
                        count += 1;
                        label1.Text = count.ToString();
                        Image<Gray, byte> grayImage = m.ToImage<Gray, byte>();
                        _currentImage = grayImage;
                        pictureBox_Source.Image = m.Bitmap;
                        ComputeDenseOpticalFlow();
                        double fps = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
                        await Task.Delay(1000 / Convert.ToInt32(fps));
                        _lastImage = _currentImage;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StripMenuItem_Video_Pause_Click(object sender, EventArgs e)
        {
            Pause = true;
            StripMenuItem_Video_Pause.Enabled = !Pause;
            StripMenuItem_Video_Play.Enabled = true;
        }

        private void StripMenuItem_Video_Stop_Click(object sender, EventArgs e)
        {
            Pause = true;
            capture.Stop();
            pictureBox_Source.Image = null;
            StripMenuItem_Video_Pause.Enabled = false;
            StripMenuItem_Video_Play.Enabled = false;
            StripMenuItem_Video_Stop.Enabled = false;
        }

        void ComputeDenseOpticalFlow()
        {
            velx = new Image<Gray, float>(_lastImage.Size);
            vely = new Image<Gray, float>(_currentImage.Size);
            Image<Gray, byte> result = _currentImage.CopyBlank();

            CvInvoke.CalcOpticalFlowFarneback(_lastImage, _currentImage, velx, vely,
                         0.5, 3, 15, 3, 6, 1.3, 0);

            DrawFarnerBackFlowMap(_inputImage, velx, vely, 1);
            
        }

        void DrawFarnerBackFlowMap(Image<Bgr, Byte> img_curr, Image<Gray, float> flow_x, Image<Gray, float> flow_y, int step, int shiftThatCounts = 0)
        {
            Point fromDotXY = new Point();
            Point toDotXY = new Point();

            MCvScalar col;
            col.V0 = 100;
            col.V1 = 255;
            col.V2 = 0;
            col.V3 = 0;

            for (int i = 0; i < flow_x.Rows; i += step)
            {
                for (int j = 0; j < flow_x.Cols; j += step)
                {
                    toDotXY.X = (int)flow_x.Data[i, j, 0];
                    toDotXY.Y = (int)flow_y.Data[i, j, 0];

                    fromDotXY.X = j;
                    fromDotXY.Y = i;

                    toDotXY.X = fromDotXY.X + toDotXY.X;
                    toDotXY.Y = fromDotXY.Y + toDotXY.Y;

                    CvInvoke.Line(_inputImage, fromDotXY, toDotXY, new MCvScalar(0, 0, 255), 2, Emgu.CV.CvEnum.LineType.EightConnected, 0);

                    pictureBox_Result.Image = _inputImage.Bitmap;
                }
            }
        }
    }
}
