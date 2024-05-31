using System.Net.Mime;
using SkiaSharp;

namespace SimpleApi.Domain.Services;

public interface IBarcodeService
{
    byte[] GenerateBarcode(string value);
}