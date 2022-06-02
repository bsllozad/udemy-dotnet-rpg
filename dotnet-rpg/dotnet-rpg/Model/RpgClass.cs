using System.Text.Json.Serialization;

namespace dotnet_rpg.Model
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric
    }
}
