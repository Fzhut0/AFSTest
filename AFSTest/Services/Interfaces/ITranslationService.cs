using AFSTest.Models;

namespace AFSTest.Services.Interfaces
{
    public interface ITranslationService
    {
        Task<TranslationResponse> TranslateToLeetSpeakAsync(string text);
    }
}