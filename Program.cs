using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace git_lesson
{
    // Record with struct = Очень хорошая рактика. Если юзать структуры то только с рекорд, ибо структури будут имютбл(неизменяимыми) 
    // + С помощью метадов Equals() можно нормально сравнивать обьекты по свойствам(name, secondname и тд...). 
    readonly record struct Person
    {
        public string Name {get;} = "";
        public string Secondname {get;} = "";   //{get; init;} init - можно задать свойство только при инициализации  
        public int Age {get;}

        public Person(string name, string secondname, int age)
        {
            Name = name;
            Secondname = secondname;
            Age = age;
        }
    }

    public record User(string name, string secondname);

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Nikita", "Tkachenko", 20);
            PrintPersonInfo(person.Name, person.Secondname, person.Age);

            person = ChangeInfo("Dima", "Tkachenko", 20);
            PrintPersonInfo(person.Name, person.Secondname, person.Age);

            person = ChangeInfo("Rostyslav", "Gonchar", 19);
            PrintPersonInfo(person.Name, person.Secondname, person.Age);

            // Робота с record - сравнение обьектов.
            var user1 = new User("Dasha", "Grigivka");
            var user2 = new User("Dasha", "Grigivka");

            Console.WriteLine(user1 == user2);
            Console.WriteLine(user1);

            var updatedUser = new User(user1.name, "Sokolova");

            // Равно тоже самое!!!
            var updatedUser1 = user1 with {secondname = "Sokolova"};
            Console.WriteLine(updatedUser1);

            // Деконструкция - стоит изучить детальнее!!!
            var (name, secondName) = user1;

            //Nullable_Registration.TestRun();

            Nullable_Registration NewUser1 = new Nullable_Registration("Nikita", "Tkachenko", "tkachenko.nikita.07@gmail.com", 20, 3);
            Console.WriteLine(NewUser1);
            NewUser1.ChangeInfo("Dima", "Koladenko", "koladento@gmail.com", 31, 5);
            Console.WriteLine(NewUser1);

        }

        private static void ConsoleWrite(string text)
        {
            Console.WriteLine(text);
        }

        private static void PrintPersonInfo(string name, string secondName, int age)
        {
            Console.WriteLine($"Name: {name}, Secondname: {secondName} and Age: {age}.");
        }
        
        private static Person ChangeInfo(string newName, string newSecondname, int newAge)
        {
            return new Person(newName, newSecondname, newAge);
        }
    }
}

    

    


