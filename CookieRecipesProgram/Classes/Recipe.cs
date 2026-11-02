using System;
using System.Collections.Generic;
using System.Text;

namespace CookieRecipesProgram.Classes
{
    public class Recipe
    {

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public void AddNewIngredientToRecipe(Ingredient newIngredient)
        {
            Ingredients.Add(newIngredient);
        }
        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
