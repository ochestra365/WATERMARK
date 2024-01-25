using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WaterMark_Project.Class.PDF
{
    class PDFController
    {
        /*
        This Source Code Form is subject to the terms of the Mozilla Public
        License, v.2.0. If a copy of the MPL was not distributed with this file,
        You can obtain one at https://mozilla.org/MPL/2.0/.
        */
        /// <summary>
        /// ISOS PSC 230125 : OPEN SOURCE.
        /// Make WaterMark on All PDF Pages.
        /// Caution : Korean Language is not supported now.
        /// </summary>
        /// <param name="sourceFile">The PDF File Path You want to mark watermark.</param>
        /// <param name="outputFile">The PDF File marked Watermark.</param>
        /// <param name="watermarkText">The Text You want to Input.</param>
        /// <param name="watermarkFont">The Font You want to Input.</param>
        /// <param name="watermarkFontSize">The Size of Watermark</param>
        /// <param name="watermarkFontColor">The Color of Watermark</param>
        /// <param name="watermarkFontOpacity">The Opacity of WaterMark</param>
        /// <param name="watermarkRotation">The Rotation of WaterMark</param>
        public void AddWatermarkText(string sourceFile, string outputFile,
string watermarkText, BaseFont watermarkFont, float
watermarkFontSize, Color watermarkFontColor, float
watermarkFontOpacity, float watermarkRotation)
        {
            PdfReader reader = null;
            PdfGState gstate = null;
            PdfContentByte underContent = null;
            Rectangle rect = null;
            int pageCount = 0;
            try
            {
                PdfStamper stamper;
                {
                    reader = new PdfReader(sourceFile);
                    rect = reader.GetPageSizeWithRotation(1);
                    stamper = new PdfStamper(reader, new FileStream(outputFile, FileMode.CreateNew), '\0', true);
                    if (watermarkFont == null)
                    {
                        watermarkFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    }
                    if (watermarkFontColor == null)
                    {
                        watermarkFontColor = Color.DARK_GRAY;
                    }
                    gstate = new PdfGState();
                    gstate.FillOpacity = watermarkFontOpacity;
                    gstate.StrokeOpacity = watermarkFontOpacity;
                    pageCount = reader.NumberOfPages;
                    for (int i = 1; i <= pageCount; i++)
                    {
                        Console.WriteLine($"TIME : {DateTime.Now}.\nPAGE : {i}.");
                        underContent = stamper.GetOverContent(i);
                        //_with1 = underContent;
                        underContent.SaveState();
                        underContent.SetGState(gstate);
                        underContent.SetColorFill(watermarkFontColor);
                        underContent.BeginText();
                        underContent.SetFontAndSize(watermarkFont, watermarkFontSize);
                        underContent.SetTextMatrix(30, 30);
                        underContent.ShowTextAligned(Element.ALIGN_CENTER, watermarkText, rect.Width / 2, rect.Height / 2, watermarkRotation);
                        underContent.EndText();
                        underContent.RestoreState();
                    }
                }
                stamper.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"TIME : {DateTime.Now}.\n{ex}");
            }
        }
    }
}
