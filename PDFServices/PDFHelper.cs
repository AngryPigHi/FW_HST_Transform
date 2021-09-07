using Aspose.Pdf;
using Aspose.Pdf.Devices;
using System;
using System.IO;

namespace PDFServices
{
    public static class PDFHelper
    {

        public static void GenerationPng(string input, string pngPath = null)
        {
            pngPath = pngPath ?? input.Replace(Path.GetFileName(input), string.Concat(Path.GetFileNameWithoutExtension(input), "_pngsresult"));

            int t = 1;
            while (Directory.Exists(pngPath))
            {
                if (t == 1)
                {
                    pngPath = string.Concat(Path.GetDirectoryName(pngPath), "\\", Path.GetFileNameWithoutExtension(pngPath), "(", t.ToString(), ")");
                }
                else
                {
                    pngPath = pngPath.Replace("(" + (t - 1) + ").png", "(" + t + ").png");
                }
                t++;
            }

            Directory.CreateDirectory(pngPath);
            using (Document document = new Document(input))
            {
                for (int page = 1; page < document.Pages.Count + 1; page++)
                {
                    Page documentPage = document.Pages[page];
                    if (!documentPage.IsBlank(0.01))
                    {
                        using (FileStream fileStream = new FileStream(Path.Combine(pngPath, string.Format("{0}.png", page)), FileMode.CreateNew))
                        {
                            PngDevice pngDevice = new PngDevice();
                            pngDevice.Process(documentPage, fileStream);
                        }
                    }
                }
            }

        }




    }
}
