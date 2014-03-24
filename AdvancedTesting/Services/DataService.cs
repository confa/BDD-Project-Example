using System;
using System.Collections.Generic;
using AdvancedTesting.Models;
using System.Linq;

namespace AdvancedTesting.Services
{
    public class DataService
    {
        private List<Recipe> Recipes { get; set; }
        private static int CurrentId;

        public DataService()
        {
            Recipes = new List<Recipe>();
        }

        public bool Insert(Recipe recipe)
        {
            try
            {
                recipe.Id = ++CurrentId;
                Recipes.Add(recipe);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Recipe Get(int id)
        {
            return Recipes.FirstOrDefault(x => x.Id == id);
        }

        public List<Recipe> GetAll()
        {
            return Recipes;
        }

        public void Remove(int id)
        {
            Recipes.Remove(Get(id));
        }
    }
}