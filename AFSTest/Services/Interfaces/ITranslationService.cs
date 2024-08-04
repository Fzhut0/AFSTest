using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSTest.Models;

namespace AFSTest.Services.Interfaces
{
    public interface ITranslationService
    {
        Task<TranslationResponse> TranslateToLeetSpeakAsync(string text);
    }
}