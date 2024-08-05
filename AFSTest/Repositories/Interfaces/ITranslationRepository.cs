using AFSTest.Models;

namespace AFSTest.Repositories.Interfaces
{
    public interface ITranslationRepository
    {
        Task SaveTranslationAsync(TranslationRecord record);
    }
}