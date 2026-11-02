using CookieRecipesProgram.Classes;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
namespace CookieRecipesProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "recipes";
            
            int result;
            bool isLoopDone=false;
            List <Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient(1, "Wheat flour", "Sieve. Add to other ingredients."));
            ingredients.Add(new Ingredient(2, "Coconut flour", "Sieve. Add to other ingredients."));
            ingredients.Add(new Ingredient(3, "Butter", "Melt on low heat. Add to other ingredients."));
            ingredients.Add(new Ingredient(4, "Chocolate", "Melt on low heat. Add to other ingredients."));
            ingredients.Add(new Ingredient(5, "Sugar", "Add to other ingredients."));
            ingredients.Add(new Ingredient(6, "Cardamom", "Take half a teaspoon. Add to other ingredients."));
            ingredients.Add(new Ingredient(7, "Cinnamon", "Take half a teaspoon. Add to other ingredients."));
            ingredients.Add(new Ingredient(8, "Cocoa powder", "Add to other ingredients"));

            Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
            Describer.DescribeIngredientsAvailable(ingredients);
            Recipe recipe = new Recipe();
            do
            {
                isLoopDone = false;
                Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
                string ingredientSelected = Console.ReadLine()!;
                if(!int.TryParse(ingredientSelected, out result)){
                    if(recipe.Ingredients.Count != 0){
                        Console.WriteLine("Recipe finished.");
                        isLoopDone = true;
                    }
                    else
                    {
                        Console.WriteLine("The recipe needs at least one ingredient in order to be registred");
                    }
                }
                else{
                    if (IngredientVerifier.IsTheIngredientValid(ingredients, result) is Ingredient newIngredientToRecipe){
                        recipe.AddNewIngredientToRecipe(newIngredientToRecipe);
                        Console.WriteLine("the ingredient with this ID was added to the recipe");
                    }
                    else{
                        Console.WriteLine("The user selects a number, but it doesn’t match any of the existing ingredients.");
                    }
                }  
            } while (!isLoopDone);
           
        }
    }
}
