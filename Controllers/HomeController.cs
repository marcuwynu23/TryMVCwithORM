using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TryMVCwithORM.Models;

namespace TryMVCwithORM.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var data = new { Message = "Hello from API!" };
        return Json(data);
    }
}
