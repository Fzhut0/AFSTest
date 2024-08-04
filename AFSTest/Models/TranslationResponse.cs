using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AFSTest.Models
{
    public class TranslationResponse
    {
        [JsonProperty("contents")]
        public Contents Contents { get; set; }
    }

    public class Contents
    {
        [JsonProperty("translated")]
        public string TranslatedText { get; set; }
    }
}