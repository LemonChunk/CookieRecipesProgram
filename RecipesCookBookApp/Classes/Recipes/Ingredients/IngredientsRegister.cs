namespace RecipesCookBookApp.Classes.Recipes.Ingredients
{
    public class IngredientsRegister : IIngredientsRegister
    {
        public IEnumerable<Ingredient> All { get; } = new List<Ingredient>()
        {
            new WheatFlour(),
            new CoconutFlour(),
            new Butter(),
            new Chocolate(),
            new Sugar(),
            new Cardamom(),
            new Cinnamon(),
            new CocoaPowder()
        };

        public Ingredient? FindIngredientById(int id)
        {
            foreach (Ingredient ingredient in All)
            {
                if (ingredient.Id == id)
                {
                    return ingredient;
                }
            }
            return null;
        }
    }
}
