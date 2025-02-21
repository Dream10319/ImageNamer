using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ImageNamer
{
    public partial class ImageInfoControl : UserControl
    {
        public string FilePath { get; }
        public AttributeManager attManager;
        public ImageInfoControl(string filePath, AttributeManager attributeManager)
        {
            this.FilePath = filePath;
            InitializeComponent();
            attManager = attributeManager;
        }

        public bool AreAttributesSet() => cbAttribute1.SelectedItem != null && cbAttribute2.SelectedItem != null;

        public string GetNewFileName()
        {
            string originalName = Regex.Replace(Path.GetFileNameWithoutExtension(FilePath), @"_\d+$", "");
            lblConvertedFileName.Text = $"{originalName}_{cbAttribute1.SelectedItem}_{cbAttribute2.SelectedItem}.jpg";
            return lblConvertedFileName.Text;
        }

        private void ImageInfoControl_Load(object sender, EventArgs e)
        {
            lblFileName.Text = Path.GetFileName(FilePath);

            cbAttribute1.Items.AddRange(attManager.attribute1Options.ToArray());
            cbAttribute2.Items.AddRange(attManager.attribute2Options.ToArray());

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
