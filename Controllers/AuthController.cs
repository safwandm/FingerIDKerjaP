using Microsoft.AspNetCore.Mvc;
using FingerID.Models;
using FingerID.Services;

namespace FingerID.Controllers;

public class AuthController : Controller
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        if (_authService.ValidateCredentials(model.Username, model.Password))
        {
            TempData["User"] = model.Username;
            return RedirectToAction("Verify", "Fingerprint");
        }

        ViewBag.Error = "Invalid credentials";
        return View();
    }
}
