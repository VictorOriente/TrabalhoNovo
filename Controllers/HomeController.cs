using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TECNICAS_DE_PROGRAMACAO_TURMA_24___UNI9_AV1_27_11.Models;

namespace TECNICAS_DE_PROGRAMACAO_TURMA_24___UNI9_AV1_27_11.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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
