using Microsoft.AspNetCore.Mvc;
using SimpleApi.Domain.Services;

namespace SimpleApi.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BarcodeController : ControllerBase
{
    private readonly IBarcodeService _barcodeService;

    public BarcodeController(IBarcodeService barcodeService)
    {
        _barcodeService = barcodeService;
    }


    [HttpGet("{value}")]
    public IActionResult Generate([FromRoute] string value)
    {
        var barcode = _barcodeService.GenerateBarcode(value);

        if (barcode == null)
        {
            return NotFound();
        }

        return File(barcode, "image/png");
    }
}