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

        public async Task SaveTranslationAsync(TranslationRecord record)
        {
            await _context.TranslationRecords.AddAsync(record);
            await _context.SaveChangesAsync();
        }
    }
}