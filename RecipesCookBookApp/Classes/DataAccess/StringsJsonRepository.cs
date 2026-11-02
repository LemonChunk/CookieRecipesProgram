using System.Text.Json;

namespace RecipesCookBookApp.Classes.DataAccess
{
    public class StringsJsonRepository : StringsRepository, IStringsRepository
    {
        protected override string StringsToText(List<string> listOfStrings)
        {
            return JsonSerializer.Serialize(listOfStrings);
        }

        protected override List<string> TextToStrings(string fileContents)
        {
            return JsonSerializer.Deserialize<List<string>>(fileContents)!;
        }
    }
}
