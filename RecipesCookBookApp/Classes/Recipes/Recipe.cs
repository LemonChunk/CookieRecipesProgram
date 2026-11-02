using RecipesCookBookApp.Classes.Recipes.Ingredients;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace RecipesCookBookApp.Classes.Recipes
{
    public class Recipe
    {
        public IEnumerable<Ingredient> Ingredients { get; }
        public Recipe(IEnumerable<Ingredient> ing)
        {
            Ingredients = ing;
        }
        public override string ToString()
        {
            var steps = new List<string>();
            foreach(var ingredient in Ingredients){
                steps.Add($"{ingredient.Name}. {ingredient.Instructions}");
            }
            return string.Join(Environment.NewLine, steps);
        }
    }

}
