using System.Drawing;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace PeSA.Engine.Helpers
{
    //https://stackoverflow.com/questions/69664644/serialize-deserialize-system-drawing-color-with-system-text-json
    public class ColorJsonConverter : JsonConverter<Color>
    {
        public override Color Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => ColorTranslator.FromHtml(reader.GetString());

        public override void Write(Utf8JsonWriter writer, Color value, JsonSerializerOptions options) => writer.WriteStringValue("#" + value.R.ToString("X2") + value.G.ToString("X2") + value.B.ToString("X2").ToLower());
    }
    public class JsonUtil
    {

        public static string ToJson(object content)
        {
            var options = new JsonSerializerOptions()
            {
                Converters = { new ColorJsonConverter() },
                WriteIndented = true
            };
            string jsonstring = JsonSerializer.Serialize(content, options);
            return jsonstring;
        }
        public static object ReadFromJson(string jsonstring, Type content)
        {
            var options = new JsonSerializerOptions()
            {
                Converters = { new ColorJsonConverter() }
            };
            return JsonSerializer.Deserialize(jsonstring, content, options);
        }
        //public static object ReadFromJson(string json, Type type)
        //{
           /* Regex noNewLineRegex = new("\"(.*)\":(.*),\"");
            while(noNewLineRegex.Match(json).Success)
            {
                Match m = noNewLineRegex.Match(json);
                if (m.Success)
                {
                    json = json.Insert(m.Index + m.Value.Length - 1, "\r\n");
                }

            }
            json = json.Replace("{", "\r\n{\r\n");*/
            //return JsonSerializer.Deserialize(json, type);
        //}
    }
}
