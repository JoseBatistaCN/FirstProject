using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstProject.Models;

namespace FirstProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        int hour = DateTime.Now.Hour;
        string message;
        if (hour < 12)
        {
            message = "Bom dia!";
        }
        else if (hour < 18)
        {
            message = "Boa tarde!";
        }
        else
        {
            message = "Boa noite!";
        }

        return View("Index", message);
    }

}
