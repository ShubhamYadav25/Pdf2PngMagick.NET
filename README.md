<h2 align="center">Pdf2PngMagick.NET</h2>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" />
  <img src="https://img.shields.io/badge/Magick.NET-239120?style=for-the-badge&logo=imagemagick&logoColor=white" />
  <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
</p>

## About the Project

**Pdf2PngMagick.NET** is a tool designed to convert PDF documents into PNG images with the best possible quality while keeping file sizes low. This project uses **Magick.NET**, an ImageMagick wrapper, to ensure high-quality output with minimal visual changes during the conversion process.

## Features

- Converts PDFs into high-quality PNG images.
- Minimal visual changes during conversion.
- Efficient file size management without compromising quality.
- Built using **Magick.NET**.

## How to choose right DPI value

**DPI (Dots Per Inch)** is a measure of how many dots (or pixels) are packed into one inch of the image. It plays a crucial role in determining the resolution and quality of an image. The higher the DPI, the more detailed the image will be, but the image size in terms of pixels will also increase.

## Formula to Calculate Image Size in Pixels

Given a certain DPI and the desired physical dimensions of an image (in inches), the size of the image in pixels can be calculated as:

- **Width in pixels** = Width in inches × DPI
- **Height in pixels** = Height in inches × DPI

This formula helps determine the total number of pixels needed to represent the image with the desired resolution.

## Example: 4x6 Inch Image at 300 DPI

Let’s say you want to create an image that will be **4 inches wide** and **6 inches tall** with a DPI of **300**. 

## Calculation:

- **Width in pixels** = 4 inches × 300 DPI = 1200 pixels
- **Height in pixels** = 6 inches × 300 DPI = 1800 pixels

Thus, the image will have a size of **1200x1800 pixels** at 300 DPI.

## References and Articles

- [Magick.NET GitHub Repository](https://github.com/dlemstra/Magick.NET)
- [Magick.NET Documentation](https://github.com/dlemstra/Magick.NET/tree/main/docs#documentation)

