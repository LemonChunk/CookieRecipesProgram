using System.Globalization;
namespace RecipesCookBookApp.Classes.Recipes

{
    public interface IRecipesReposity
    {
        List<Recipe> Read(string fileName);
        void Write(string FileName, List<Recipe> recipes);
    }
}