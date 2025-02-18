namespace ImageNamer
{
    partial class ImageInfoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFileName = new Label();
            pictureBox = new PictureBox();
            cbAttribute1 = new ComboBox();
            cbAttribute2 = new ComboBox();
            lblConvertedFileName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(3, 44);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(103, 15);
            lblFileName.TabIndex = 0;
            lblFileName.Text = "original_file_name";
            lblFileName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImageLayout = ImageLayout.Center;
            pictureBox.Location = new Point(234, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(118, 103);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // cbAttribute1
            // 
            cbAttribute1.FormattingEnabled = true;
            cbAttribute1.Location = new Point(368, 20);
            cbAttribute1.Name = "cbAttribute1";
            cbAttribute1.Size = new Size(121, 23);
            cbAttribute1.TabIndex = 2;
            cbAttribute1.SelectedIndexChanged += cbAttribute1_SelectedIndexChanged;
            // 
            // cbAttribute2
            // 
            cbAttribute2.FormattingEnabled = true;
            cbAttribute2.Location = new Point(368, 65);
            cbAttribute2.Name = "cbAttribute2";
            cbAttribute2.Size = new Size(121, 23);
            cbAttribute2.TabIndex = 3;
            cbAttribute2.SelectedIndexChanged += cbAttribute2_SelectedIndexChanged;
            // 
            // lblConvertedFileName
            // 
            lblConvertedFileName.AutoSize = true;
            lblConvertedFileName.Location = new Point(502, 44);
            lblConvertedFileName.Name = "lblConvertedFileName";
            lblConvertedFileName.Size = new Size(116, 15);
            lblConvertedFileName.TabIndex = 4;
            lblConvertedFileName.Text = "converted_file_name";
            lblConvertedFileName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ImageInfoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblConvertedFileName);
            Controls.Add(cbAttribute2);
            Controls.Add(cbAttribute1);
            Controls.Add(pictureBox);
            Controls.Add(lblFileName);
            Name = "ImageInfoControl";
            Size = new Size(734, 109);
            Load += ImageInfoControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFileName;
        private ComboBox cbAttribute1;
        private ComboBox cbAttribute2;
        private Label lblConvertedFileName;
        public PictureBox pictureBox;
    }
}
