using System;
using System.Data;

namespace git_lesson
{
    // Null - совместимые значимые типы (Nullable). Для значимого типа.
    class NullableTypeLearn
    {
        public static void Run()
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

        public static void NullableReferenceRun()
        {
            
        }
    }
}