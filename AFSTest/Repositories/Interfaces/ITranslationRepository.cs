using AFSTest.Models;

namespace AFSTest.Repositories.Interfaces
{
    public interface ITranslationRepository
    {
        void SaveTranslation(TranslationRecord record);
    }
}