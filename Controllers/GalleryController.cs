using Microsoft.AspNetCore.Mvc;
using EfficientAssetsDemo.Models;

public class GalleryController : Controller
{
    public IActionResult Index()
    {
        var imageDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/");
        var files = Directory.GetFiles(imageDir)
            .Select(file => new ImageItem
            {
                FileName = Path.GetFileName(file),
                Url = "/images/" + Path.GetFileName(file)
            }).ToList();

        return View(files);
    }
}
