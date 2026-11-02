using System;
using System.Collections.Generic;
using System.Text;

namespace CookieRecipesProgram.Classes
{
    public static class IngredientVerifier
    {
        public static Ingredient? IsTheIngredientValid(List<Ingredient> list, int number)
        {
            foreach (Ingredient ing in list)
            {
                if (number == ing.Id)
                {
                    return ing;
                }
             
            }
            return null;
        }
    }
}
