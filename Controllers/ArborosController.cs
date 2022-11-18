using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TECNICAS_DE_PROGRAMACAO_TURMA_24___UNI9_AV1_27_11.Models;

namespace TECNICAS_DE_PROGRAMACAO_TURMA_24___UNI9_AV1_27_11.Controllers;

public class ArborosController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ArborosController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Arboros()
    {
        return View();
    }




}
