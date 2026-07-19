using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeautySalon.RestApi.Configurations.TimeOnlyConvertes;

public class TimeOnlyJsonConverter : JsonConverter<TimeOnly>
{
    public override TimeOnly Read(ref Utf8JsonReader reader,
                                  Type typeToConvert,
                                  JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);

        var root = document.RootElement;

        var hour = root.GetProperty("hour").GetInt32();
        var minute = root.GetProperty("minute").GetInt32();

        return new TimeOnly(hour, minute);
    }

    public override void Write(Utf8JsonWriter writer,
                               TimeOnly value,
                               JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteNumber("hour", value.Hour);
        writer.WriteNumber("minute", value.Minute);
        writer.WriteEndObject();
    }
}