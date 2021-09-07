using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFToPngCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            string directPath = Console.ReadLine();

            DirectoryInfo TheFolder = new DirectoryInfo(directPath);
            foreach (FileInfo NextFile in TheFolder.GetFiles())
            {
                if (NextFile.Extension == ".pdf")
                {
                    //PDFHelper.GenerationPng(NextFile.FullName);
                    string pngNmae=Path.GetFileNameWithoutExtension(NextFile.FullName);

                    PDFTranImgHelp.ConvertPDF2Image(NextFile.FullName, directPath+"\\", pngNmae, 1, 2, ImageFormat.Png, Definition.Eight);
                    Console.WriteLine(directPath + "\\"+ pngNmae);
                }
            }

            Console.WriteLine("Done!");
            Console.ReadKey();

        }
    }
}
