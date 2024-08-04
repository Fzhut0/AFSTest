using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSTest.Models;

namespace AFSTest.Repositories.Interfaces
{
    public interface ITranslationRepository
    {
        void SaveTranslation(TranslationRecord record);
    }
}