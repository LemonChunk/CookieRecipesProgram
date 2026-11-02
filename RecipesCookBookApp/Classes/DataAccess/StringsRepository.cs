using System;


namespace RecipesCookBookApp.Classes.DataAccess
{
    public abstract class StringsRepository : IStringsRepository
    {
        public List<string> Read(string filePath)
        {
            if (File.Exists(filePath))
            {
                string fileContents = File.ReadAllText(filePath);
                return TextToStrings(fileContents);
            }
            else
            {
                return new List<string>();
            }
        }
        public void Write(string file, List<string> list)
        {
            File.WriteAllText(file, StringsToText(list));
        }
        protected abstract List<string> TextToStrings(string fileContents);
        protected abstract string StringsToText(List<string> listOfStrings);
    }
}
