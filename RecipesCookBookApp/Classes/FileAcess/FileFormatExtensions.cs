
using RecipesCookBookApp.Classes.DataAccess;

public static class FileFormatExtensions
{
    public static string AsFileExtension(this FileFormat fileFormat) => fileFormat == FileFormat.Json ? "json" : "txt";
}