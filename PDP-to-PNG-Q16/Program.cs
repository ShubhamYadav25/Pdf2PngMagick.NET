using ImageMagick;
using System;
using System.IO;
public class PdfToPngConverterUsingQ16
{
    public static void Main()
    {
        string pdfFilePath = "C:\\Users\\sy783\\Downloads\\Label-37f1b65c-1dce-4d65-9e64-bdb561033489.pdf";
        string outputPngFilePath = "C:\\Users\\sy783\\Downloads\\label.png";

        // configure the conversion setting
        MagickReadSettings imageSettings = new MagickReadSettings
        {
            // set the density (DPI) to ensure the quality of the image
            // high DPI will increase file size 
            Density = new Density(300, 300)

        };

        using (MagickImageCollection images = new MagickImageCollection())
        {
            // Read the PDF with the specified settings
            images.Read(pdfFilePath, imageSettings);

            // Convert each page of the PDF to a PNG
            for (int i = 0; i < images.Count; i++)
            {
                // Select the current page
                using (MagickImage image = (MagickImage)images[i])
                {
                    // Set the image size to 1200x1800 pixels (4x6 inches at 300 DPI)
                    image.Resize(1200, 1800);

                    // set quality of the PNG output
                    image.Quality = 100;

                    // save the image at defined path
                    image.Write(string.Format(outputPngFilePath, $"{i + 1}.png"));
                }
            }
        }
    }
}
