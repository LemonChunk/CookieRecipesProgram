using RecipesCookBookApp.Classes.Recipes.Ingredients;

namespace RecipesCookBookApp.Classes.Recipes
{
    public interface IRecipesUserInteraction
    {
        public void Exit();
        void PrintfExistingRecipes(IEnumerable<Recipe> allRecipes);
        public void ShowMessage(string v);
        public void PromptToCreateRecipe();
        public IEnumerable<Ingredient> ReadIngredientsFromUser();
    }
}