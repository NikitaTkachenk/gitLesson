using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace git_lesson
{
    class Program
    {
        public string Name {get; private set;} = "";
        public string FirstName {get; private set;} = "";
        public int Age {get; private set;}

        static void Main()
        {
            ConsoleWrite("Hello my friend!");
            PrintPersonInfo("Nikita", "Tkachenko", 20);
        }

        private static void ConsoleWrite(string text)
        {
            Console.WriteLine(text);
        }

        private static void PrintPersonInfo(string name, string secondName, int age)
        {
            Console.WriteLine($"Name: {name}, Secondname: {secondName} and Age: {age}.");
        }
    }
}

    

    


