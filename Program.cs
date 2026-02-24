using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace git_lesson
{


    struct Person
    {
        public string Name {get; private set;} = "";
        public string Secondname {get; private set;} = "";
        public int Age {get; private set;}

        public Person(string name, string secondname, int age)
        {
            Name = name;
            Secondname = secondname;
            Age = age;
        }

        public void SetPersonInfo(string name, string secondname, int age)
        {
            Name = name;
            Secondname = secondname;
            Age = age;
        }
    }

    class Program
    {
        static void Main()
        {
            Person person = new Person("Nikita", "Tkachenko", 20);
            PrintPersonInfo(person.Name, person.Secondname, person.Age);

            person.SetPersonInfo("Dima", "Tkachenko", 20);
            PrintPersonInfo(person.Name, person.Secondname, person.Age);

            person.SetPersonInfo("Kirill", "Bilik", 17);
            PrintPersonInfo(person.Name, person.Secondname, person.Age);
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

    

    


