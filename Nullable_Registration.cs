using System;
using System.Data;

namespace git_lesson
{
    // Null - совместимые значимые типы (Nullable). Для значимого типа.
    class Nullable_Registration
    {
        public string Name {get; private set;}
        public string Secondname {get; private set;}
        public string E_mail {get; private set;}
        public int? CountExperience {get; private set;} = null;

        public Nullable_Registration(string name, string secondname, string e_mail, int age, int countExperience)
        {
            Name = name;
            Secondname = secondname;
            E_mail = e_mail;
            CountExperience = countExperience;
        }
   
        public void ChangeInfo(string newName, string newSecondname, string newE_mail, int newAge, int newCountExperience)
        {
            Name = newName;
            Secondname = newSecondname;
            E_mail = newE_mail;
            CountExperience = newCountExperience;
        }





        public static void TestRun()
        {
             //int a = null; - Неправильно!       // null - гооврит о том что у нас нету ссылки на этоти данные в управляемой куче.

            int? i = null; // Теперь может быть null.
            int b = 7;
            
            Console.WriteLine(i == null);
            System.Console.WriteLine(i.HasValue);
            System.Console.WriteLine(i.GetValueOrDefault());
            System.Console.WriteLine(i.GetValueOrDefault(3));
            System.Console.WriteLine(i ?? 55);    // Оператор обьядинения с null, если в левой части будет null то вернеться значение что будет с правой части. ??.
            // System.Console.WriteLine(i.Value); - Ошибка, исключение!

            Console.WriteLine(i + b);  // из-за того что Одна из переменных null, то результат будет null независимо от другой переменной.
            Console.WriteLine(i < b);  // False - при сравнении с null всегда будет false.
        }  

    }
}