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

            if(string.IsNullOrWhiteSpace(request.OriginalText))
            {
                return Json(new { error = "You have to put text" });
            }

            var result = await _translationService.TranslateToLeetSpeakAsync(request.OriginalText);
            return Json(new { contents = new { translated = result.Contents.TranslatedText } });
        }
    }


