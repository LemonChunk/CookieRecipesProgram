using System;
using System.Collections.Generic;
using System.Text;

namespace CookieRecipesProgram.Classes
{
    public static class IntReader
    {
        public static int ReadInt(string message)
        {
            int band, result;
            do
            {
                band = 1;
                Console.WriteLine(message);
                string userAnswer = Console.ReadLine()!;
                if (int.TryParse(userAnswer, out result))
                {
                    Console.WriteLine($"Ingresaste: {result}");
                }
                else
                {
                    band = 0;
                    Console.WriteLine("The loop stops and we consider the recipe finished.");
                }
            } while (band == 0);
            return result;
        }
    }
}
