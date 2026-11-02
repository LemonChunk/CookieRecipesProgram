using RecipesCookBookApp.Classes.Recipes.Ingredients;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RecipesCookBookApp.Classes.Recipes
{

    public class RecipesConsoleUserInteraction : IRecipesUserInteraction
    {
        private readonly IIngredientsRegister _ingredientsRegistered;

        public RecipesConsoleUserInteraction(IIngredientsRegister ingredientsRegistered)
        {
            _ingredientsRegistered = ingredientsRegistered;
        }

        public void Exit()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public void PrintfExistingRecipes(IEnumerable<Recipe> recipes)
        {
            var counter = 1;
            if (recipes.Count()>0)
            {
                Console.WriteLine("Existing recipes are: ");

                foreach(Recipe recipe in recipes)
                {
                    Console.WriteLine("***** " + counter + " *****");
                    Console.WriteLine(recipe);
                    counter++;
                }
            }
        }

        public void PromptToCreateRecipe()
        {
            Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
            foreach(Ingredient ing in _ingredientsRegistered.All)
            {
                Console.WriteLine(ing);
            }
        }

      

        public void ShowMessage(string v)
        {
            Console.WriteLine(v);
        }

        public IEnumerable<Ingredient> ReadIngredientsFromUser()
        {
            var isLoopFinished = false;
            var ingredients = new List<Ingredient>();
            do
            {
                isLoopFinished = false;
                Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
                string userInput = Console.ReadLine()!;
                if(int.TryParse(userInput, out int idInput))
                {
                    if(_ingredientsRegistered.FindIngredientById(idInput) is Ingredient newIngredientAdded){
                        ingredients.Add(newIngredientAdded);
                    }
                    else
                    {
                        Console.WriteLine("Ingredient not found.");
                    }
                }
                else
                {
                    isLoopFinished = true;
                }
            } while (!isLoopFinished);
            return ingredients;
        }
    }
}
