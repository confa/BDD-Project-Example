using AdvancedTesting.Enums;

namespace AdvancedTesting.Models
{
    public class Ingredient
    {
        /// <summary>
        /// Ingredient Type.
        /// </summary>
        public IngredientType Type { get; set; }

        /// <summary>
        /// Ingredient Amount.
        /// </summary>
        public int Amount { get; set; }
    }
}