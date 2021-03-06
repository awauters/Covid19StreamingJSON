﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Covid19StreamingJsonOef
{
    public class Mortality
    {
        [JsonProperty("DATE")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime Date { get; set; }
        [JsonProperty("REGION")]
        public string Region { get; set; }
        [JsonProperty("AGEGROUP")]
        public string AgeGroup { get; set; }
        [JsonProperty("SEX")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Sex sex { get; set; }
        [JsonProperty("DEATHS")]
        public int DeathCount { get; set; }
    }
}
