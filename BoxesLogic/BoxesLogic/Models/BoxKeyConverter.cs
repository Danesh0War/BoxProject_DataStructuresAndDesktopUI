using BoxesDS;
using Newtonsoft.Json;
using System;


// Custom JsonConverter class to handle serialization and deserialization of BoxKey objects.

public class BoxKeyConverter : JsonConverter 
{
    public override bool CanConvert(Type objectType)
    {
        // Returns true only if the object type is BoxKey.
        return objectType == typeof(BoxKey);
    }

    // Deserializes BoxKey objects from a JSON representation.
    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        // Parses the value as a string and splits it at the comma to get dimensions.
        var parts = reader.Value.ToString().Split(',');

        // Returns a new BoxKey object using the parsed dimensions!
        return new BoxKey(double.Parse(parts[0]), double.Parse(parts[1]));
    }

    // Serializes BoxKey objects to a JSON representation.
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        var boxKey = (BoxKey)value;
        writer.WriteValue($"{boxKey.SizeX},{boxKey.SizeY}");
    }
}
