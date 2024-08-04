using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSTest.Models;
using AFSTest.Repositories.Interfaces;
using AFSTest.Services.Interfaces;
using Newtonsoft.Json;

namespace AFSTest.Services
{
    public class TranslationService : ITranslationService
    {
        private readonly HttpClient _httpClient;
        private readonly ITranslationRepository _translationRepository;

        public TranslationService(HttpClient httpClient, ITranslationRepository translationRepository)
        {
            _httpClient = httpClient;
            _translationRepository = translationRepository;
        }

        public async Task<TranslationResponse> TranslateToLeetSpeakAsync(string text)
        {
            var response = await _httpClient.GetAsync($"http://api.funtranslations.com/translate/leetspeak.json?text={Uri.EscapeDataString(text)}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<TranslationResponse>(content);

            _translationRepository.SaveTranslation(new TranslationRecord
            {
                OriginalText = text,
                TranslatedText = result.Contents.TranslatedText,
                Timestamp = DateTime.UtcNow
            });
            return result;
        } 
    }
}