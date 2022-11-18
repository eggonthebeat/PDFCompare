using ImageMagick;
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
using System.Diagnostics;

namespace PDFCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private string pdf1path = "";
        private string pdf2path = "";

        private void pathPDF1btn_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "PDF files!! (*.pdf)|";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }

            pdf1path = filePath;
            PDF1.Text = filePath;
        }
        private void pathPDF2btn_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "PDF files!!! (*.pdf)|";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }

            pdf2path = filePath;
            PDF2.Text = filePath;
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            var settings = new MagickReadSettings();
            settings.Density = new Density(300);
            var image1 = new MagickImage();
            var image2 = new MagickImage();


            pdf1path = PDF1.Text;
            pdf2path = PDF2.Text;

            Console.WriteLine("Reading...");
            label3.Text = "Reading...";

            progressBar1.Value = 25;

            image1.Read(pdf1path, settings);
            image2.Read(pdf2path, settings);

            var output = "C:\\Users\\calci\\OneDrive\\Dokument\\PDF\\output\\";

            var resultpath = output + "doneee.png";

            if (File.Exists(resultpath)) {
                File.Delete(resultpath);
                Console.WriteLine("Deleted old result file.");
            }
            var difference = new MagickImage();
            Console.WriteLine("Comparing...");
            label3.Text = "Comparing...";
            progressBar1.Value = 50;
            var r = image1.Compare(image2, new ErrorMetric(), difference);

            Console.WriteLine("Writing...");
            label3.Text = "Writing...";
            progressBar1.Value = 75;

            difference.Write(resultpath);


            pictureBox1.Image = Image.FromFile(resultpath);
            Process.Start(resultpath);

            Console.WriteLine("Done.");
            label3.Text = "Done.";
            progressBar1.Value = 100;

        }
    }
}
