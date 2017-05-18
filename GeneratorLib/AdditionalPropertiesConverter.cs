﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GeneratorLib
{
    public class AdditionalPropertiesConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Boolean)
            {
                return null;
            }
            

            return existingValue;
        }

        public override bool CanConvert(Type type)
        {
            return (type == typeof (bool) || type == typeof (Dictionary<string, string>));
        }

        public override void WriteJson(JsonWriter w, object o, JsonSerializer s)
        {
            throw new NotImplementedException();
        }
    }
}
