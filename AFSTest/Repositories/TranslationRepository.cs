using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSTest.Data;
using AFSTest.Models;
using AFSTest.Repositories.Interfaces;

namespace AFSTest.Repositories
{
    public class TranslationRepository : ITranslationRepository
    {
        private readonly ApplicationDbContext _context;

        public TranslationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void SaveTranslation(TranslationRecord record)
        {
            _context.TranslationRecords.Add(record);
            _context.SaveChanges();
        }
    }
}