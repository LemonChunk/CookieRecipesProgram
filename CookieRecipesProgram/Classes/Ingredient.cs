using System;
using System.Collections.Generic;
using System.Text;

namespace CookieRecipesProgram.Classes
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; } = "New Ingredient";
        public string Instructions { get; set; } = "Instructions here!";
        public override string ToString()
        {
            return $"{Id}. {Name}.";
        }
        public Ingredient(int id, string name, string instructions)
        {
            Id = id;
            Name = name;
            Instructions = instructions;
        }
      

    }
}
