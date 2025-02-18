
namespace ImageNamer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtSource = new TextBox();
            txtDestination = new TextBox();
            btnSource = new Button();
            btnDest = new Button();
            progressBar = new ProgressBar();
            btnProcess = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            flowPanel = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 16);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Source Directory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Destination Directory";
            // 
            // txtSource
            // 
            txtSource.Location = new Point(136, 12);
            txtSource.Name = "txtSource";
            txtSource.ReadOnly = true;
            txtSource.Size = new Size(557, 23);
            txtSource.TabIndex = 2;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(136, 45);
            txtDestination.Name = "txtDestination";
            txtDestination.ReadOnly = true;
            txtDestination.Size = new Size(557, 23);
            txtDestination.TabIndex = 3;
            // 
            // btnSource
            // 
            btnSource.Location = new Point(699, 12);
            btnSource.Name = "btnSource";
            btnSource.Size = new Size(79, 23);
            btnSource.TabIndex = 4;
            btnSource.Text = "...";
            btnSource.UseVisualStyleBackColor = true;
            // 
            // btnDest
            // 
            btnDest.Location = new Point(699, 45);
            btnDest.Name = "btnDest";
            btnDest.Size = new Size(79, 23);
            btnDest.TabIndex = 5;
            btnDest.Text = "...";
            btnDest.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 541);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(765, 23);
            progressBar.TabIndex = 7;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(294, 579);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(74, 26);
            btnProcess.TabIndex = 8;
            btnProcess.Text = "Process";
            btnProcess.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(406, 579);
            button4.Name = "button4";
            button4.Size = new Size(74, 26);
            button4.TabIndex = 9;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowPanel);
            groupBox1.Location = new Point(13, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(765, 448);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Image List";
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.BorderStyle = BorderStyle.FixedSingle;
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.Location = new Point(3, 19);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(759, 426);
            flowPanel.TabIndex = 0;
            flowPanel.WrapContents = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 617);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(btnProcess);
            Controls.Add(progressBar);
            Controls.Add(btnDest);
            Controls.Add(btnSource);
            Controls.Add(txtDestination);
            Controls.Add(txtSource);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Image Namer";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDestination;
        private Button btnSource;
        private Button btnDest;
        private ProgressBar progressBar;
        private Button btnProcess;
        private Button button4;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowPanel;
        private TextBox txtSource;
    }
}
