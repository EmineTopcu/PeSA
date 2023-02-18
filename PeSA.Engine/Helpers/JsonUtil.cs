using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
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
    public class MatrixJsonConverter<T> : JsonConverter<T[,]>
    {
        public override T[,] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            List<T[]> listMatrix = new List<T[]>();

            reader.Read();
            int colCount = 0;

            while (reader.TokenType != JsonTokenType.EndArray)
            {

                if (reader.TokenType != JsonTokenType.StartArray)
                {
                    throw new JsonException();
                }

                reader.Read();

                List<T> listRow = new ();
                while (reader.TokenType != JsonTokenType.EndArray)
                {
                    listRow.Add(JsonSerializer.Deserialize<T>(ref reader, options));

                    reader.Read();
                }
                if (listRow.Count > colCount)
                    colCount = listRow.Count;

                listMatrix.Add(listRow.ToArray());

                reader.Read();
            }
            T[,] Matrix=new T[listMatrix.Count, colCount];
            for (int rowind = 0; rowind < listMatrix.Count; rowind++)
            {
                for (int colind = 0; colind < colCount; colind++)
                {
                    Matrix[rowind, colind] = listMatrix[rowind][colind];
                }
            }
            return Matrix;
        }
        public override void Write(Utf8JsonWriter writer, T[,] matrix, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            for (int rowind = 0; rowind < matrix.GetLength(0); rowind++)
            {
                writer.WriteStartArray();
                for (int colind = 0; colind < matrix.GetLength(1); colind++)
                {
                    if (typeof(T) == typeof(string))
                        writer.WriteStringValue(matrix[rowind, colind].ToString());
                    else if (typeof(T) == typeof(int))
                        writer.WriteNumberValue(Convert.ToInt32(matrix[rowind, colind]));
                    else if (typeof(T) == typeof(double))
                        writer.WriteNumberValue(Convert.ToDouble(matrix[rowind, colind]));
                }
                writer.WriteEndArray();
            }
            writer.WriteEndArray();
        }
    }
    /*public class MatrixJsonConverter<T> : JsonConverter<T[,]>
    {
        public override T[,] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string fullString = reader.GetString();
            if (fullString.StartsWith("[["))
                fullString = fullString.Substring(2);
            if (fullString.EndsWith("]]"))
                fullString = fullString.Remove(fullString.Length - 2, 2);
            List<string> lines = fullString.Split("],[").ToList();
            if (!lines.Any()) return null;
            List<string> line0 = lines[0].Split(',').ToList();
            T[,] matrix =new T[lines.Count, line0.Count];
            int rowind = 0;
            foreach(string line in lines)
            {
                List<string> cells = line.Split(',').ToList();
                int colind = 0;
                foreach(string cell in cells)
                {
                    matrix[rowind, colind] = (T)Convert.ChangeType(cell, typeof(T));
                    colind++;
                    if (colind >= line0.Count) break;
                }
                rowind++;
            }
            return matrix;
        }
        public override void Write(Utf8JsonWriter writer, T[,] matrix, JsonSerializerOptions options)
        {
            string json = "[[" +
                (typeof(T) == typeof(string) ?
                string.Join("],[", Enumerable.Range(0, matrix.GetLength(0)).Select(i => string.Join(',', Enumerable.Range(0, matrix.GetLength(1)).Select(j => $"\"{matrix[i, j]}\""))))
                :
                string.Join("],[", Enumerable.Range(0, matrix.GetLength(0)).Select(i => string.Join(',', Enumerable.Range(0, matrix.GetLength(1)).Select(j => matrix[i, j])))))
                + "]]";
            writer.WriteStringValue(json);
        }
    }
*/
    public class JsonUtil
    {

        public static string ToJson(object content)
        {
            var options = new JsonSerializerOptions()
            {
                Converters = { new ColorJsonConverter(), new MatrixJsonConverter<double>(), new MatrixJsonConverter<int>(), new MatrixJsonConverter<string>() },
                WriteIndented = true
            };
            string jsonstring = JsonSerializer.Serialize(content, options);
            return jsonstring;
        }
        public static object ReadFromJson(string jsonstring, Type content)
        {
            var options = new JsonSerializerOptions()
            {
                Converters = { new ColorJsonConverter(), new MatrixJsonConverter<double>(), new MatrixJsonConverter<int>(), new MatrixJsonConverter<string>() }
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
