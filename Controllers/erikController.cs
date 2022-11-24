using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TecnicasV1.Models;

namespace TecnicasV1.Controllers;

public class erikController : Controller{
    public IActionResult Index()
    {
        return View();
    }

}