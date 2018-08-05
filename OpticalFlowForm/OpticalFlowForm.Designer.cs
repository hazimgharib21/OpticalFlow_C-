namespace OpticalFlowForm
{
    partial class OpticalFlowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox_Source = new System.Windows.Forms.PictureBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_Video_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_Video_Play = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_Video_Pause = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_Video_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_Result = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1433, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox_Source
            // 
            this.pictureBox_Source.Location = new System.Drawing.Point(12, 45);
            this.pictureBox_Source.Name = "pictureBox_Source";
            this.pictureBox_Source.Size = new System.Drawing.Size(701, 660);
            this.pictureBox_Source.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Source.TabIndex = 1;
            this.pictureBox_Source.TabStop = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem,
            this.videoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItem_Video_Open,
            this.StripMenuItem_Video_Play,
            this.StripMenuItem_Video_Pause,
            this.StripMenuItem_Video_Stop});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.videoToolStripMenuItem.Text = "Video";
            // 
            // StripMenuItem_Video_Open
            // 
            this.StripMenuItem_Video_Open.Name = "StripMenuItem_Video_Open";
            this.StripMenuItem_Video_Open.Size = new System.Drawing.Size(152, 22);
            this.StripMenuItem_Video_Open.Text = "Open";
            this.StripMenuItem_Video_Open.Click += new System.EventHandler(this.StripMenuItem_Video_Open_Click);
            // 
            // StripMenuItem_Video_Play
            // 
            this.StripMenuItem_Video_Play.Name = "StripMenuItem_Video_Play";
            this.StripMenuItem_Video_Play.Size = new System.Drawing.Size(152, 22);
            this.StripMenuItem_Video_Play.Text = "Play";
            this.StripMenuItem_Video_Play.Click += new System.EventHandler(this.StripMenuItem_Video_Play_Click);
            // 
            // StripMenuItem_Video_Pause
            // 
            this.StripMenuItem_Video_Pause.Name = "StripMenuItem_Video_Pause";
            this.StripMenuItem_Video_Pause.Size = new System.Drawing.Size(152, 22);
            this.StripMenuItem_Video_Pause.Text = "Pause";
            this.StripMenuItem_Video_Pause.Click += new System.EventHandler(this.StripMenuItem_Video_Pause_Click);
            // 
            // StripMenuItem_Video_Stop
            // 
            this.StripMenuItem_Video_Stop.Name = "StripMenuItem_Video_Stop";
            this.StripMenuItem_Video_Stop.Size = new System.Drawing.Size(152, 22);
            this.StripMenuItem_Video_Stop.Text = "Stop";
            this.StripMenuItem_Video_Stop.Click += new System.EventHandler(this.StripMenuItem_Video_Stop_Click);
            // 
            // pictureBox_Result
            // 
            this.pictureBox_Result.Location = new System.Drawing.Point(719, 45);
            this.pictureBox_Result.Name = "pictureBox_Result";
            this.pictureBox_Result.Size = new System.Drawing.Size(701, 660);
            this.pictureBox_Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Result.TabIndex = 2;
            this.pictureBox_Result.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // OpticalFlowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Result);
            this.Controls.Add(this.pictureBox_Source);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OpticalFlowForm";
            this.Text = "Optical Flow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox_Source;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_Video_Open;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_Video_Play;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_Video_Pause;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_Video_Stop;
        private System.Windows.Forms.PictureBox pictureBox_Result;
        private System.Windows.Forms.Label label1;
    }
}

