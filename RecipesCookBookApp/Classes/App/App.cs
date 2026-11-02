using RecipesCookBookApp.Classes;
using RecipesCookBookApp.Classes.Recipes;
using RecipesCookBookApp.Classes.Recipes.Ingredients;
using System.Globalization;

namespace RecipesCookBookApp.Classes.App
{

    public class App
    {
        private readonly IRecipesUserInteraction _recipesUserInteraction;
        private readonly IRecipesReposity _recipesRepository;

        public App(IRecipesUserInteraction recipesUserInteraction, IRecipesReposity recipesReposity)
        {
            _recipesUserInteraction = recipesUserInteraction;
            _recipesRepository = recipesReposity;
        }

        public void Run(string filePath)
        {
            var allRecipes = _recipesRepository.Read(filePath);
            _recipesUserInteraction.PrintfExistingRecipes(allRecipes);
            _recipesUserInteraction.PromptToCreateRecipe();
            IEnumerable<Ingredient> ingredients = _recipesUserInteraction.ReadIngredientsFromUser();
            if (ingredients.Count() > 0)
            {
                var recipe = new Recipe(ingredients);
                allRecipes.Add(recipe);
                _recipesRepository.Write(filePath, allRecipes);
                _recipesUserInteraction.ShowMessage("Recipe added: ");
                _recipesUserInteraction.ShowMessage(recipe.ToString());
            }
            else
            {
                _recipesUserInteraction.ShowMessage("No ingredients have been selected. " +
                    "Recipe will not be saved");
            }
            _recipesUserInteraction.Exit();
        }
    }



}
