using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FingerID.Models;

namespace FingerID.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
