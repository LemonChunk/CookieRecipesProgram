namespace RecipesCookBookApp.Classes.Recipes.Ingredients
{
    public interface IIngredientsRegister
    {
        IEnumerable<Ingredient> All { get; }

        Ingredient? FindIngredientById(int id);
    }
}