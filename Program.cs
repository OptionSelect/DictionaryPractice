using System;
using System.Collections.Generic;
using System.Linq;

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
            while(lookUp != string.Empty)
            {
                Console.WriteLine("Please Enter a name you would like to look up:");
                lookUp = Console.ReadLine();
                foreach (var item in myDict)
                {
                    if(item.Key == lookUp)
                    {
                        Console.WriteLine(item.Value);
                    }
                }  
            }
        }
    }
}

