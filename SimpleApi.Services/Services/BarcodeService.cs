using BarcodeStandard;
using SimpleApi.Domain.Services;
using SkiaSharp;
using Type = BarcodeStandard.Type;

namespace SimpleApi.Services.Services;

public class BarcodeService : IBarcodeService
{
    public byte[] GenerateBarcode(string value)
    {
        try
        {
            var barcode = new Barcode();
            barcode.IncludeLabel = true;
            var image = barcode.Encode(Type.UpcA, value, SKColors.Black, SKColors.White, 290, 120);

            // encode the image (defaults to PNG)
            var encoded = image.Encode();
            var array = encoded.ToArray();
            return array;
        }
        catch (Exception)
        {
            return null;
        }
        //// get a stream over the encoded data
        //var stream = encoded.AsStream();
        //var barcodeImage = System.Drawing.Image.FromStream(stream);
        //return barcodeImage;
    }

    public byte[] ImageToByteArray(System.Drawing.Image imageIn)
    {
        using (var ms = new MemoryStream())
        {
            imageIn.Save(ms, imageIn.RawFormat);
            return ms.ToArray();
        }
    }
}