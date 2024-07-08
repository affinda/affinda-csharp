using Azure.Core;
using System.Text.Json;

public class Utf8JsonAdapter<TValue> : IUtf8JsonSerializable
{
    private readonly TValue value;
    private readonly JsonSerializerOptions? options;

    public Utf8JsonAdapter(TValue value, JsonSerializerOptions? options = default)
    {
        this.value = value;
        this.options = options;
    }

    public void Write(Utf8JsonWriter writer)
    {
        JsonSerializer.Serialize(writer, value, options);
    }
}
