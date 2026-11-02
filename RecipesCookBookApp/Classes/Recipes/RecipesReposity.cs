using RecipesCookBookApp.Classes.DataAccess;
using RecipesCookBookApp.Classes.Recipes.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesCookBookApp.Classes.Recipes
{
    public class RecipesReposity : IRecipesReposity
    {
        private readonly IStringsRepository _stringsRepository;
        private readonly IIngredientsRegister _ingredientRegister;
        private const string Separator = ", ";

        public RecipesReposity(IStringsRepository stringsRepository, IIngredientsRegister ingredientRegister)
        {
            _stringsRepository = stringsRepository;
            _ingredientRegister = ingredientRegister;
        }

        public List<Recipe> Read(string filePath)
        {
            List<string> recipesFromFile = _stringsRepository.Read(filePath);
            var recipes = new List<Recipe>();
            foreach(var recipeFromFile in recipesFromFile)
            {
                var recipe = RecipeFromString(recipeFromFile);
                recipes.Add(recipe);
            }
            return recipes;
            
        }

        private Recipe RecipeFromString(string recipeFromFile)
        {
            List<string> textualIds = recipeFromFile.Split(Separator).ToList();
            var ingredients = new List<Ingredient>();
            foreach(string textualId in textualIds)
            {
                int id = int.Parse(textualId);
                ingredients.Add(_ingredientRegister.FindIngredientById(id)!);
            }
            return new Recipe(ingredients);
        }

        public void Write(string filePath, List<Recipe> allRecipes)
        {
            var recipesAsStrings = new List<string>();
            foreach(Recipe recipe in allRecipes)
            {
                var allIds = new List<int>();
                foreach(Ingredient ingredient in recipe.Ingredients)
                {
                    allIds.Add(ingredient.Id);
                }
                recipesAsStrings.Add(string.Join(Separator, allIds));
            }
            _stringsRepository.Write(filePath, recipesAsStrings);
        }
    }
}
