using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedTesting.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IngredientType
    {
        Carrot,
        Cucumber,
        Parsley,
        Tomato,
        Salad,
        Squash,
        Cabbage,
        Egg,
        Flour,
        Salt,
        Pepper, 
        Marzipan, 
        Oil,
        Butter,
        Cheese
    }
}