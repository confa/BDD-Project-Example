using System;
using System.Collections.Generic;

namespace AdvancedTesting.Models
{
    public class Recipe
    {
        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            CreatedAt = DateTime.Now;
        }

        /// <summary>
        /// Recipe ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Recipe Name.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Creation Date.
        /// </summary>
        public DateTime CreatedAt { get; set; }
        
        /// <summary>
        /// Author Name.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Recipe Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Recipe Ingredients.
        /// </summary>
        public List<Ingredient> Ingredients { get; set; }
    }
}