namespace RecipesCookBookApp.Classes.DataAccess
{
    public class StringsTextualRepository : StringsRepository, IStringsRepository
    {
        private static readonly string Separator = Environment.NewLine;
       
        protected override string StringsToText(List<string> listOfStrings)
        {
            return string.Join(Separator, listOfStrings);
        }

        protected override List<string> TextToStrings(string text)
        {
            return text.Split(Separator).ToList();
        }
    }
}
