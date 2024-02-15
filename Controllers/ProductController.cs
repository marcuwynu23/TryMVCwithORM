using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TryMVCwithORM.Models;

namespace TryMVCwithORM.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var data = new { Message = "Hello from API!" };
        return Json(data);
    }
}
