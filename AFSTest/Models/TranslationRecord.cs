namespace AFSTest.Models
{
    public class TranslationRecord
    {
        public Guid Id { get; set; }
        public string OriginalText { get; set; }
        public string TranslatedText { get; set; }
        public DateTime Timestamp { get; set; }
    }
}