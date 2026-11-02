namespace RecipesCookBookApp.Classes.DataAccess
{
    public interface IStringsRepository
    {
        List<string> Read(string filePath);
        void Write(string file, List<string> list);
    }
}