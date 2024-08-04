using AFSTest.Models;
using AFSTest.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private readonly ITranslationService _translationService;

    public HomeController(ITranslationService translationService)
    {
        _translationService = translationService;
    }

    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> TranslateToLeetSpeak(TranslationRequest request)
    {
        var result = await _translationService.TranslateToLeetSpeakAsync(request.OriginalText);
        return Json(new { contents = new { translated = result.Contents.TranslatedText } });
    }
}
