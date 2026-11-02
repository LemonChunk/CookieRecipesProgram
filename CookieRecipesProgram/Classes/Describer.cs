using System;
using System.Collections.Generic;
using System.Text;

namespace CookieRecipesProgram.Classes
{
    public static class Describer
    {
        public static void DescribeIngredientsAvailable(List<Ingredient> list)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("List Of Ingredients:\n");
            foreach(Ingredient ing in list){
                Console.WriteLine($"{ing.Id}. {ing.Name}\n");
            }
            Console.WriteLine("--------------------------------------");
        }
        public static void DescribeExistingRecipes(List<Recipe> list)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("List Of Recipes:\n");
            for(int i = 0; i < list.Count; i++){
                Console.WriteLine("***** " + i+1 + " *****"); 
                foreach(Ingredient ing in list[i].Ingredients)
                {
                    Console.WriteLine($"{ing.Name}. {ing.Instructions}");
                }
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}
