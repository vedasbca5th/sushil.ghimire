using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    class Program
    {

        static void Main()
        {
            //Method Syntax.
            int[] numbers = { 12, 34, 45, 2, 34, 55, 67, 987, 9900, 2345, 67, 39 };
            //Find all the elements from the numbers array which are less than 75 and greater than 20.
            var result = numbers.Select(num => num).Where(num => num < 75 && num > 20);//num is a custom variable.

            //Query Expression Syntax.
            //filteration.
            var result1 = from num in numbers where num > 50 select num;
            string[] names = { "Sushil", "Dipan", "Bishnu", "Rojina", "sushant", "Anjana", "Badal", "Binaya" };
            //find names that starts with letter 'B' and having length less then 6.
            var resulti = from name in names
                          where name.StartsWith("B") && name.Length < 6
                          select name;

            //Restriuctions-where
            var result2 = from num in numbers
                          where num > 50 && num < 70
                          select num;

            //Projections-select
            var result3 = from num in numbers
                          where num % 2 == 0
                          select num * num;
            //oderby: oderby descending
            var result4 = from num in numbers
                          orderby num descending
                          select num;
            //partitioning: skip,take useful for paging in web pages.
            var result5 = numbers.Take(5);//take 5 elements from the collection.
            var result6 = numbers.Skip(4).Take(5);//skip the first 4 elemnts and take next 5 elements.

            //Quentifiers: Any,All,Contains
            var isEvenThere = numbers.Any(num => num % 2 == 0);//any even numbers are present in the array or not.
            var areAllEven = numbers.All(num => num % 2 == 0);//all even numers are present in the array or not.
            var result7 = numbers.Contains(24);//elements 24 is present in the array or not.

            //Generics: Range,Repeat
            var result8 = Enumerable.Range(1, 1000);
            var result9 = Enumerable.Repeat("Hello World", 20);

            Person p1 = new Person(101, "Sushil", "Ghimire", "Kumaripati", 22);
            Person p2 = new Person(102, "Bishal", "Moktan", "Butwal", 30);
            Person p3 = new Person(106, "Laxi", "Udas", "Lele", 17);
            Person p4 = new Person(104, "Sanjel", "Shrestha", "Kathmandu", 25);
            Person p5 = new Person(103, "Anjan", "Bashnet", "Kumaripati", 33);
            Person p6 = new Person(107, "Kamal", "Aryal", "Kathmandu", 24);
            Person p7 = new Person(105, "Dipan", "Bhusal", "Mangalbazar", 12);

            List<Person> people = new List<Person> { p1, p2, p3, p4, p5, p6, p7 };

            //List all the person from kathmandu
            var result10 = from person in people
                           where person.Address == "Kathmandu"
                           select person;
            //List all the person name who is minors
            var result11 = from person in people
                           where person.Age < 18
                           select person.FirstName;
            //:ist the  person who lives in kumaripti  ascending order by age.
            var result12 = from person in people
                           where person.Address == "Kumaripati"
                           orderby person.Age
                           select person;
        }
        void LearnLinqOnComplexCollection()
        {

            Country c1 = new Country("Nepal", "Kathmandu", "Asia", 29594504);
            Country c2 = new Country("India", "Delhi", "Asia", 2009594504, DateTime.Parse("1947/11/1"));
            Country c3 = new Country("England", "GB", "Europe", 34594504);

            Country c4 = new Country("Bhutan", "Thimpu", "Asia", 594504);

            Country c5 = new Country("Austrilia", "Canberra", "Austrilia", 29594504, DateTime.Parse("1944/1/1"));
            Country c6 = new Country("Russia", "Mosco", "Europe", 29594504, DateTime.Parse("1943/11/1"));

            List<Country> countries = new List<Country> { c1, c2, c3, c4, c5, c6 };

            //list all the Asian Country Names

            var result = from country in countries
                         where country.Continent == "Asia"
                         select country.Name;

            //hw-List all the Asian Country which are never been Invaded.
            //hw- List all the Europian Countries in ascending order that has population less than 500k.

        }
    }




}
