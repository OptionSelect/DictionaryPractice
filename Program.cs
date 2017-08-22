using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1 (Inserting Data until Blank Name entered)
            var myDict = new Dictionary<string, int>();
            var name = "Placeholder";
            while (name != string.Empty)
            {
                Console.WriteLine("Please Enter a Name: ");
                name = Console.ReadLine();

                if (name != string.Empty)
                {
                    Console.WriteLine($"Please Enter the phone number associated with {name}:");
                    var phoneNumber = int.Parse(Console.ReadLine());
                    myDict.Add(name, phoneNumber);
                }
            }

            //Part 2 (Searching for Name & Number)
            var lookUp = "Placeholder";
            while (lookUp != string.Empty)
            {
                Console.WriteLine("Please Enter a name you would like to look up:");
                lookUp = Console.ReadLine();
                var phoneNumbah = 0;
                if(myDict.TryGetValue(lookUp, out phoneNumbah))
                {
                    Console.WriteLine($"{phoneNumbah}");
                } else if(lookUp != string.Empty)
                {
                    Console.WriteLine($"Did you mean: ");
                    foreach (var item in myDict)
                    {
                        Console.WriteLine($"{item.Key}");
                    }
                }
            }
            string s = "abcabcabcdefab c a oo ija ;a ;skmdals kn";
            Console.WriteLine(letterCount(s)['b'] == 4);
            Console.WriteLine(letterCount(s).ContainsKey('z') == false);
            Console.WriteLine(letterCount(s).ContainsKey(' ') == false);

        }
        //Part 3 (LetterCount Function) 
        public static Dictionary<char, int> letterCount(string s)
        {
            var lowCase = Regex.Replace(s, @"\s+", "");

            lowCase.ToLower().ToCharArray();
            var charDictionary = new Dictionary<char, int>();
            foreach (var item in lowCase)
            {
                int count = lowCase.Where(c => c == item).Count();
                if (charDictionary.ContainsKey(item) == false)
                {
                    charDictionary.Add(item, count);
                }
            }
            foreach (var item in charDictionary)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            return charDictionary;
        }
    }
}

