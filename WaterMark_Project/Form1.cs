using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WaterMark_Project.Class.PDF;
using iTextSharp.text;
namespace WaterMark_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo file = new FileInfo("main.pdf");
                FileInfo outputFile = new FileInfo("main_water.pdf");
                if (file.Exists)
                {
                    float opacity = 0.1f;
                    float rotation = 20;
                    float size = 70;
                    string text = "WaterMark";
                    #region Verify
                    if (outputFile.Exists)
                    {
                        outputFile.Delete();
                    }
                    if (!String.IsNullOrEmpty(this.TxtOpacity.Text))
                    {
                        if (float.TryParse(this.TxtOpacity.Text.Trim(), out float txtOpacity))
                        {
                            opacity = txtOpacity;
                        }
                    }

                    if (!String.IsNullOrEmpty(this.TxtSize.Text))
                    {
                        if (float.TryParse(this.TxtSize.Text, out float txtSize))
                        {
                            size = txtSize;
                        }
                    }
                    if (!String.IsNullOrEmpty(this.Txtrotation.Text))
                    {
                        if (float.TryParse(this.Txtrotation.Text, out float txtRotation))
                        {
                            rotation = txtRotation;
                        }
                    }
                    if (!string.IsNullOrEmpty(this.TxtWaterMark.Text))
                    {
                        text = this.TxtWaterMark.Text.ToUpper().Trim();
                    }
                    #endregion
                    PDFController pdf = new PDFController();
                    pdf.AddWatermarkText("main.pdf", "main_water.pdf", text, null, size, null, opacity, rotation);
                }
                else
                {
                    MessageBox.Show("main.pdf file is not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"TIME : {DateTime.Now}\n{ex}");
            }
        }
    }
}
