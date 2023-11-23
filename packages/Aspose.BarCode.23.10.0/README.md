# Barcode Generation & Recognition Library for .NET Apps

![Nuget](https://img.shields.io/nuget/v/Aspose.Barcode) ![Nuget](https://img.shields.io/nuget/dt/Aspose.Barcode)
[![banner](https://raw.githubusercontent.com/Aspose/aspose.github.io/master/img/banners/aspose_barcode-for-net-banner.png)](https://releases.aspose.com/barcode/net/)

[Home](https://www.aspose.com/) | [Product Page](https://products.aspose.com/barcode/net) | [Docs](https://docs.aspose.com/barcode/net/) | [Demos](https://products.aspose.app/barcode/family) | [API Reference](https://apireference.aspose.com/barcode/net) | [Examples](https://github.com/aspose-barcode/Aspose.BarCode-for-.NET) | [Blog](https://blog.aspose.com/category/barcode/) | [Free Support](https://forum.aspose.com/c/barcode) | [Temporary License](https://purchase.aspose.com/temporary-license)

# Barcode Library for .NET
[Aspose.BarCode for .NET](https://products.aspose.com/barcode/net) doesn't just create or recognize barcodes but it provides a complete framework to control almost everything about barcodes. Developers can customize the barcode's appearance like bar height, colors, margins, borders, row/columns count and interpolation modes, as well as barcode generation properties like symbol mode encodings, error correction modes, ECI modes or special barcode metadata. While scanning for barcodes, developers can specify the area/areas where a barcode can be found. Moreover, scanning engine can be optimized for better barcode reading quality or speed with variety of options, which allows to recognize strongly corrupted barcodes.

## Demo applications

- [Generate Barcode](https://products.aspose.app/barcode/generate)
- [Recognize Barcode](https://products.aspose.app/barcode/recognize)
- [Embed Barcode](https://products.aspose.app/barcode/embed)
- [Generate Wi-Fi QR code](https://products.aspose.app/barcode/wifi-qr)
- [Online QR code Scanner](https://products.aspose.app/barcode/scanqr)
- [Barcode Scanner Online](https://products.aspose.app/barcode/scan)

## Barcode API

- [Generate](https://docs.aspose.com/barcode/net/barcode-generation/) & [recognize](https://docs.aspose.com/barcode/net/read-barcodes-with-aspose-barcode-apis/) 70+ barcode symbologies with just a few lines of code.
- Read 1D & 2D barcodes at any angle and [image quality](https://docs.aspose.com/barcode/net/improve-barcode-recognition/).
- [Wide range of options](https://docs.aspose.com/barcode/net/image-formatting-and-display-settings/) to manipulate barcode image appearance.
- Generate barcodes with [special barcode parameters](https://docs.aspose.com/barcode/net/generate-barcode-with-different-symbology/), like error correction mode, ECI or [embedded matadata](https://docs.aspose.com/barcode/net/pdf417-and-macropdf417-barcode/).
- Barcode generation and recognition from documents, like [Swiss QR bills](https://docs.aspose.com/barcode/net/generate-swiss-qr-code/).
- Create [device resolution dependent images](https://docs.aspose.com/barcode/net/setting-barcode-parameters/#managing-image-resolution).
- [Export barcode as XML](https://docs.aspose.com/barcode/net/barcode-in-xml/).
- Specify the [image areas](https://docs.aspose.com/barcode/net/read-barcodes-with-aspose-barcode-apis/#specifying-target-regions-for-recognition) to scan the barcode.
- Specify [reading engine options](https://docs.aspose.com/barcode/net/improve-barcode-recognition/) to obtain best balance between reading quality and speed.

## Supported Symbologies for Barcode Generation & Recognition
The following symbologies are supported for generation and recognition by Aspose.BarCode engine:
- **1D:** Codabar, Code 11, Code 93 Standard, Code 93 Extended, Code 128, EAN8, EAN13, EAN14, SCC14, SSCC18, UPC-A, UPC-E, ISBN, ISSN, ISMN, Standard 2-of-5, Interleaved 2-of-5, Matrix 2-of-5, IATA 2-of-5, ITF-14, ITF-6, MSI, VIN, OPC, PZN, Code16K, Pharmacode, PatchCode, Code 32, Data Logic 2-of-5, Codablock-F, DatabarOmniDirectional, DatabarTruncated, DatabarLimited, DatabarExpanded, DatabarExpandedStacked, DatabarStacked, DatabarStackedOmniDirectional, EAN-2, EAN-5

- **2D:** 	Data Matrix, QR Code, Micro QR Code, Aztec Code, PDF417, Macro PDF417, Micro PDF417, Compact PDF, MaxiCode, DotCode, Mailmark 2D, Swiss QR Code, Han Xin

- **Postal:** AustraliaPost, Postnet, Planet, OneCode, RM4SCC, Mailmark, SingaporePost, DutchKIX, DeutschePostIdentcode, DeutschePostLeitcode, ItalianPost25, AustralianPosteParcel, SwissPostParcel,

- **GS1:**  GS1 Code 128, UpcaGs1Code128Coupon, UpcaGs1DatabarCoupon, GS1 Codablock-F, GS1 Data Matrix, GS1 QR Code, GS1 DotCode, GS1 Composite Bar

- **HIBC:**	HIBC Code 39 LIC, HIBC Code 128 LIC, HIBC Code 39 PAS, HIBC Code 128 PAS, HIBC Aztec Code LIC, HIBC Data Matrix LIC, HIBC QR Code LIC, HIBC Aztec Code PAS, HIBC Data Matrix PAS, HIBC QR Code PAS

## Supported Symbologies for Barcode Recognition Only
- MicrE13B

## Barcode Generation & Recognition Formats

**Images:** JPEG, TIFF, PNG, BMP, GIF, EXIF

## Save BarCode Labels As

**Images:** EMF, SVG

## Platform Independence

Aspose.BarCode for .NET can easily be used in any .NET 32-bit or 64-bit application, including, .Net Framework, .Net Core, ASP.NET, .Net MAUI, Mono, Xamarin, WinForms, WPF and UWP. In short, you can develop apps using Aspose.BarCode for .NET where the .NET framework or .Net Core are available.

## Get Started

Are you ready to give Aspose.BarCode for .NET a try? Simply add Aspose.BarCode to your project references as Nuget package. If you have some difficulties with this, [our examples](https://github.com/aspose-barcode/Aspose.BarCode-for-.NET/blob/master/Examples/CSharp/CSharp.csproj) help you to manage with this.

## Generate a Barcode Label with Code128

Try the following snippet to see how Aspose.BarCode API performs in your environment or check the [GitHub Repository](https://github.com/aspose-barcode/Aspose.BarCode-for-.NET) for other common usage scenarios.

```csharp
// instantiate object and set different barcode properties
BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code128, "1234567");
generator.Parameters.Barcode.XDimension.Millimeters = 1f;

// save the image to your system and set its image format to Png
generator.Save(dir + "output.png", BarCodeImageFormat.Png);
```

## Hide Barcode Text from the PNG Label via C# Code

Aspose.BarCode for .NET allows you to customize various properties of barcodes, such as borders, color, type, bar height as well as barcode text. The following example shows, how simple it is to hide the barcode text using C#.

```csharp
string codeText = "This text is hidden.\n" + "This text is hidden.\n";;

// instantiate barcode object and set CodeText, Symbology , and  CodeLocation
BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.DataMatrix, codeText);
generator.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
generator.Save(dir + "output.png", BarCodeImageFormat.Png);
```

## Recognize Barcode from File via C# Code

The following example demonstrates how to scan a picture of a barcode image using Aspose.BarCode
```csharp
// Read file from directory with DecodeType.EAN13
using (BarCodeReader reader = new BarCodeReader(dataDir + "Scan.jpg", DecodeType.EAN13))
{
    foreach (BarCodeResult result in reader.ReadBarCodes())
    {
        // Read symbology type and code text
        Console.WriteLine("Symbology Type: " + result.CodeType);
        Console.WriteLine("CodeText: " + result.CodeText);
    }
}
```

[Home](https://www.aspose.com/) | [Product Page](https://products.aspose.com/barcode/net) | [Docs](https://docs.aspose.com/barcode/net/) | [Demos](https://products.aspose.app/barcode/family) | [API Reference](https://apireference.aspose.com/barcode/net) | [Examples](https://github.com/aspose-barcode/Aspose.BarCode-for-.NET) | [Blog](https://blog.aspose.com/category/barcode/) | [Search](https://search.aspose.com/) | [Free Support](https://forum.aspose.com/c/barcode) | [Temporary License](https://purchase.aspose.com/temporary-license)