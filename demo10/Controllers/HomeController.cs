using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using demo10.Models;

namespace demo10.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Console.WriteLine("Hi!");
        return View();
    }


    [HttpPost]
    public IActionResult Index(Price price)
    {

        var priceAmount = price.PriceAmount;

        Console.WriteLine($"Received price amount: {priceAmount}");

        return RedirectToAction("Privacy");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

