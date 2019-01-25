﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace AudioRecordSample.LUISAPI
{
    public class LuisResultData
    {
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("topScoringIntent")]
        public TopScoringIntentData TopScoringIntent { get; set; }

        [JsonProperty("intents")]
        public List<IntentData> Intents { get; set; }

        [JsonProperty("entities")]
        public List<EntityData> Entities { get; set; }

        [JsonProperty("dialog")]
        public DialogData dialog { get; set; }
    }
}