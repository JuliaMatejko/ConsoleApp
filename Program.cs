using System;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyClass.hasAllUniqueCharacters("abcc")); //returns false
            Console.WriteLine(MyClass.hasAllUniqueCharacters("abcd")); //returns true
            Console.WriteLine(MyClass.hasAllUniqueCharacters("")); //returns true
        }
    }

    public static class MyClass
    {
        //Second attempt
        public static bool hasAllUniqueCharacters(string input)
        {
            return input.Distinct().Count() == input.Length;
        }


        /*
            //First attempt
            public static bool hasAllUniqueCharacters(string input)
            {
                HashSet<char> characters = new();

                foreach (var character in input)
                {
                    if (characters.Contains(character))
                    {
                        return false;
                    }
                    else
                    {
                        characters.Add(character);
                    }
                }
                return true;
            }
        */
    }
}
