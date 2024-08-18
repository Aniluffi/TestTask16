using cocult;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
/// класс для сериализации фигур
/// </summary>
public class ShapeConverter : JsonConverter<Figure>
{
    /// <summary>
    /// метод для чтения листа фигур
    /// </summary>
    /// <param name="reader">файловый поток</param>
    /// <param name="typeToConvert"></param>
    /// <param name="options">настроки </param>
    /// <returns></returns>
    /// <exception cref="JsonException"></exception>
    public override Figure Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            JsonElement root = doc.RootElement;
            string type = root.GetProperty("Type").GetString();

            return type switch
            {
                "Circle" => JsonSerializer.Deserialize<Circle>(root.GetRawText(), options) ?? new Circle(),
                "Rectangle" => JsonSerializer.Deserialize<Rectangle>(root.GetRawText(), options) ?? new Rectangle(),
                "Polygon" => JsonSerializer.Deserialize<Polygon>(root.GetRawText(), options) ?? new Polygon(),
                "Square" => JsonSerializer.Deserialize<Square>(root.GetRawText(), options) ?? new Square(),
                "Triangle" => JsonSerializer.Deserialize<Triangle>(root.GetRawText(), options) ?? new Triangle(),
                _ => throw new JsonException("Unknown shape type")
            };
        }
    }
    /// <summary>
    /// сериализация фигур
    /// </summary>
    /// <param name="writer"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    public override void Write(Utf8JsonWriter writer, Figure value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}

