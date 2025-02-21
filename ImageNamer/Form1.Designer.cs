
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
            txtNewAttribute1 = new TextBox();
            btnAddAttribute1 = new Button();
            btnAddAttribute2 = new Button();
            txtNewAttribute2 = new TextBox();
            btnReload = new Button();
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
            progressBar.Location = new Point(12, 601);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(765, 23);
            progressBar.TabIndex = 7;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(294, 642);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(74, 26);
            btnProcess.TabIndex = 8;
            btnProcess.Text = "Process";
            btnProcess.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(406, 642);
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
            groupBox1.Location = new Point(12, 132);
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
            // txtNewAttribute1
            // 
            txtNewAttribute1.Location = new Point(16, 92);
            txtNewAttribute1.Name = "txtNewAttribute1";
            txtNewAttribute1.Size = new Size(186, 23);
            txtNewAttribute1.TabIndex = 11;
            // 
            // btnAddAttribute1
            // 
            btnAddAttribute1.Location = new Point(208, 92);
            btnAddAttribute1.Name = "btnAddAttribute1";
            btnAddAttribute1.Size = new Size(97, 23);
            btnAddAttribute1.TabIndex = 12;
            btnAddAttribute1.Text = "Add Attribute1";
            btnAddAttribute1.UseVisualStyleBackColor = true;
            btnAddAttribute1.Click += button1_Click;
            // 
            // btnAddAttribute2
            // 
            btnAddAttribute2.Location = new Point(538, 92);
            btnAddAttribute2.Name = "btnAddAttribute2";
            btnAddAttribute2.Size = new Size(97, 23);
            btnAddAttribute2.TabIndex = 14;
            btnAddAttribute2.Text = "Add Attribute2";
            btnAddAttribute2.UseVisualStyleBackColor = true;
            btnAddAttribute2.Click += btnAddAttribute2_Click;
            // 
            // txtNewAttribute2
            // 
            txtNewAttribute2.Location = new Point(346, 92);
            txtNewAttribute2.Name = "txtNewAttribute2";
            txtNewAttribute2.Size = new Size(186, 23);
            txtNewAttribute2.TabIndex = 13;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(699, 91);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(75, 23);
            btnReload.TabIndex = 15;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 680);
            Controls.Add(btnReload);
            Controls.Add(btnAddAttribute2);
            Controls.Add(txtNewAttribute2);
            Controls.Add(btnAddAttribute1);
            Controls.Add(txtNewAttribute1);
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
        private TextBox txtNewAttribute1;
        private Button btnAddAttribute1;
        private Button btnAddAttribute2;
        private TextBox txtNewAttribute2;
        private Button btnReload;
    }
}
