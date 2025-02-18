using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageNamer
{
    public partial class ImageInfoControl : UserControl
    {
        public string FilePath { get; }

        public ImageInfoControl(string filePath)
        {
            this.FilePath = filePath;
            InitializeComponent();
        }

        public bool AreAttributesSet() => cbAttribute1.SelectedItem != null && cbAttribute2.SelectedItem != null;

        public string GetNewFileName()
        {
            string originalName = Path.GetFileNameWithoutExtension(FilePath);
            lblConvertedFileName.Text = $"{originalName}_{cbAttribute1.SelectedItem}_{cbAttribute2.SelectedItem}.jpg";
            return lblConvertedFileName.Text;
        }

        private void ImageInfoControl_Load(object sender, EventArgs e)
        {
            lblFileName.Text = Path.GetFileName(FilePath);

            cbAttribute1.Items.AddRange(new string[] { "FrontBody", "SideBody", "Rear", "Front", "Side", "Back", "Detail1", "Detail2", "Detail3" });
            cbAttribute2.Items.AddRange(new string[] { "Zoom", "Full", "NA" });

            pictureBox.Image = LoadImageWithoutLocking(FilePath);
        }

        private void cbAttribute1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AreAttributesSet())
                GetNewFileName();
        }

        private void cbAttribute2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AreAttributesSet())
                GetNewFileName();
        }

        private Image LoadImageWithoutLocking(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                return Image.FromStream(fs);
            }
        }
    }
}
