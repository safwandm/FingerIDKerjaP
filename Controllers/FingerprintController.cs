using Microsoft.AspNetCore.Mvc;
using FingerID.Services;

namespace FingerID.Controllers;

public class FingerprintController : Controller
{
    private readonly IFingerprintService _fingerprintService;

    public FingerprintController(IFingerprintService fingerprintService)
    {
        _fingerprintService = fingerprintService;
    }

    public IActionResult Verify()
    {
        return View();
    }

    [HttpPost]
    public IActionResult VerifyFingerprint()
    {
        var user = TempData["User"]?.ToString();

        if (user == null)
            return RedirectToAction("Login", "Auth");

        if (_fingerprintService.VerifyFingerprint(user))
        {
            return RedirectToAction("Index", "Home");
        }

        return RedirectToAction("Login", "Auth");
    }
}
