using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image2Text
{
    public partial class Shenugayana : Form
    {
        public Shenugayana()
        {
            InitializeComponent();
        }

        private void Upload(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog(this);
            string file = dialog.FileName;
            if (file == string.Empty) return;
            InitialImage.BackgroundImage = Image.FromFile(file);
            ThresholdImg(file);
        }

        private void GetPixel(Bitmap bitmap)
        {
            string pattern = "";
            Color pixel = Color.White;
            Bitmap img = new Bitmap(bitmap);
            for (int i = 0; i < img.Height; i = i + 5)
            {
                for (int j = 0; j < img.Width; j = j + 5)
                {
                    pixel = img.GetPixel(j, i);
                    if (Convert.ToString(pixel.ToArgb()).Equals("-1"))
                    {
                        pattern = pattern + " ";
                    }
                    else
                    {
                        pattern = pattern + "*";
                    }
                }
                pattern = pattern + "\n";
            }
            txtOutput.Text = pattern;
        }

        private void Threshold(object sender, ScrollEventArgs e)
        {
            Bitmap bitmap = new Bitmap(InitialImage.BackgroundImage);
            IFilter threshold = new Threshold(hScrollBar1.Value);
            bitmap = Grayscale.CommonAlgorithms.RMY.Apply(bitmap);
            bitmap = threshold.Apply(bitmap);
            GetPixel(bitmap);
        }

        private void ThresholdImg(string file)
        {
            Bitmap bitmap = new Bitmap(Image.FromFile(file));
            IFilter threshold = new Threshold(hScrollBar1.Value);
            bitmap = Grayscale.CommonAlgorithms.RMY.Apply(bitmap);
            bitmap = threshold.Apply(bitmap);
            GetPixel(bitmap);
        }

        private void printFile(object sender, EventArgs e)
        {
            string text = txtOutput.Text;
            StreamWriter writer = new StreamWriter("C:/Users/aruls/OneDrive/Documents/output.txt");
            writer.WriteLine(text);
            writer.Close();
        }
    }
}