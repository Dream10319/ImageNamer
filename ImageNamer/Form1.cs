namespace ImageNamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnSource.Click += (s, e) => SelectDirectory(txtSource);
            btnDest.Click += (s, e) => SelectDirectory(txtDestination);
            btnProcess.Click += (s, e) => ProcessImages(s, e);
        }

        private void BtnProcess_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void SelectDirectory(TextBox textBox)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = dlg.SelectedPath;
                    if (textBox == txtSource)
                        LoadImages();
                }
            }
        }

        private void LoadImages()
        {
            flowPanel.Controls.Clear();
            string[] files = Directory.GetFiles(txtSource.Text, "*.jpg");
            foreach (string file in files)
            {
                ImageInfoControl imgControl = new ImageInfoControl(file);
                flowPanel.Controls.Add(imgControl);
            }
        }

        private void ProcessImages(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSource.Text) || string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                MessageBox.Show("Please select both source and destination directories.");
                return;
            }

            var conflicts = new List<string>();
            progressBar.Visible = true;
            progressBar.Value = 0;
            int validImageCount = flowPanel.Controls.OfType<ImageInfoControl>().Count(control => control.AreAttributesSet());
            progressBar.Maximum = validImageCount;
            if (validImageCount <= 0)
            {
                MessageBox.Show("Please select attributes for all images before processing.");
                return;
            }
            foreach (ImageInfoControl control in flowPanel.Controls)
            {
                if (!control.AreAttributesSet())
                {
                    continue;
                }

                string newFileName = control.GetNewFileName();
                string destPath = Path.Combine(txtDestination.Text, newFileName);

                if (File.Exists(destPath))
                    conflicts.Add(newFileName);
                else
                    File.Move(control.FilePath, destPath);

                progressBar.Value++;
                Thread.Sleep(1000);
            }

            //progressBar.Visible = false;
            if (conflicts.Any())
                MessageBox.Show("Please recheck the following files, files already exist in Destination directory:\n" + string.Join("\n", conflicts));
            else
            {
                MessageBox.Show("All Images Successfully Processed");
                //flowPanel.Controls.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
