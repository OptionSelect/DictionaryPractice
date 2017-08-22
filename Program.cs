using System;

namespace DictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Please enter the phone number associated with {name}:");
            var phoneNumber = Console.ReadLine();
        }
    }
}
