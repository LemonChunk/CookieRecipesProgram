using RecipesCookBookApp;
using RecipesCookBookApp.Classes;
using RecipesCookBookApp.Classes.DataAccess;
using RecipesCookBookApp.Classes.Recipes;
using RecipesCookBookApp.Classes.Recipes.Ingredients;
using RecipesCookBookApp.Classes.App;

const FileFormat Format = FileFormat.Txt;

var registerOfIngredients = new IngredientsRegister();

IStringsRepository stringReposity = Format == FileFormat.Json ? new StringsJsonRepository() : new StringsTextualRepository();

var recipesCookBookApp = new App(new RecipesConsoleUserInteraction(registerOfIngredients), new RecipesReposity(stringReposity, registerOfIngredients));
FileMetaData file = new FileMetaData("recipes", Format);

recipesCookBookApp.Run(file.ToPath());
