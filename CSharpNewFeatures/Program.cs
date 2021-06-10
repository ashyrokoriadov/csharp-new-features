using System;
using System.Linq;

namespace CSharoNewFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("ПРИМЕР 1. Создание объекта записи."); 

            Person person = new Person()
            {
                FirstName = "Джон",
                LastName = "Зайцев"
            };

            //Person person = new("Джон", "Зайцев");

            Console.WriteLine(person);
            */
            /*
            Console.WriteLine("ПРИМЕР 2. Сравнение объектов типов записи по значениям и по ссылкам.");

            var phoneNumbers = new string[2];
            PersonWithPhoneNumbers person1 = new("Джон", "Зайцев", phoneNumbers);
            PersonWithPhoneNumbers person2 = new("Джон", "Зайцев", phoneNumbers);
            Console.WriteLine($"Инициализация с одинаковыми значениями: {person1 == person2}"); // вывод на консоль: True

            person1.PhoneNumbers[0] = "555-1234";
            Console.WriteLine($"Замена номера в таблице: {person1 == person2}"); // вывод на консоль: True

            Console.WriteLine($"Сравнение по ссылкам: {ReferenceEquals(person1, person2)}"); // вывод на консоль: False
            */
            /*
            Console.WriteLine("ПРИМЕР 3. Изменение записей.");

            Person person1 = new Person()
            {
                FirstName = "Джон",
                LastName = "Зайцев"
            };

            Console.WriteLine($"Запись до изменения: {person1}");
            Person person2 = person1 with { FirstName = "Иван" };
            Console.WriteLine($"Новая запись с изменениями: {person2}");
            */
            /*
            Console.WriteLine("ПРИМЕР 4. Сравнивание по образцу.");
            Console.WriteLine(IsNumber(2));
            Console.WriteLine(IsNumber(12));
            Console.WriteLine(IsNumber(22));

            Person person1 = null;

            Console.WriteLine($"Person1 is null: {person1 is null}");
            Console.WriteLine($"Person1 is not null: {person1 is not null}");
            */

            Console.WriteLine("ПРИМЕР 5. Создание объектов.");

            Foo someObject = new() { Name = "Bar", Value = 22 };

            Console.WriteLine(someObject);
            

            Console.ReadKey();
        }

        static bool IsNumber(int number)
        {
            return number is >= 0 and <= 10 or >= 20 and <= 30;
        }
    }

    public record Person
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    };

    //public record Person(string FirstName, string LastName);

    //public record Person
    //{
    //    public Person(string firstName, string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }

    //    public string FirstName { get; init; }
    //    public string LastName { get; init; }
    //};

    public record PersonWithPhoneNumbers(string FirstName, string LastName, string[] PhoneNumbers);

    public record PersonBase
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }

    public record PersonBaseWithPhoneNumber : PersonBase
    {
        public string[] PhoneNumbers { get; init; }
    }

    public class Foo
    {
        public int Value { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"{nameof(Name)}: {Name}; {nameof(Value)}: {Value}.";
    }
}


