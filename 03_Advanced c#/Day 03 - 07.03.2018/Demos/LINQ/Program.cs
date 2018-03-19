using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lstPersons = new List<Person>()
                {
                new Person("Omer", "Haimovich", 23, Hobby.Running, 1.68),
                new Person("Tomer", "Haimovich", 28, Hobby.Reading, 1.65),
                new Person("Ilan", "Cohen", 31, Hobby.Skating, 1.80),
                new Person("Einav", "Rasina", 20, Hobby.Baking, 1.50),
                new Person("Neta", "Ezra", 22, Hobby.Baking, 1.54),
                new Person("Ron", "Cohen", 24, Hobby.Playing, 2.08),
                new Person("Linor", "Yaakov", 19, Hobby.Baking, 1.64),
                new Person("Lior", "Hirch", 21, Hobby.Baking, 1.88),
            };

            var sumOperator =lstPersons.Sum(x => x.Age);
            var sumAggreggate = lstPersons.Aggregate(0, (seed, p) => { return seed += p.Age; });

            var averageOperator = lstPersons.Average(x => x.Age);
            var averageAggreggate = lstPersons.Aggregate(0.0, (seed, p) => { return seed += p.Age; }, (seed) => { return seed / lstPersons.Count; });
            
            //////////////////////////////////////////////////////////////////////////
            // 1) Select
            //////////////////////////////////////////////////////////////////////////
            //1.
            {
                var lstPersonsClient = lstPersons.Select((p) =>
                {
                    return new
                    {
                        FullName = p.FirstName + p.LastName,
                        NextBrithday = p.Age + 1,
                        Hobby = p.Hobby,
                    };
                }).ToList();

                foreach (var item in lstPersonsClient)
                {
                    var FUllName = item.FullName;
                }                

                // 2.
                string[] fruits = { "apple", "banana", "mango", "orange",
                      "passionfruit", "grape" };

                var query =
                    fruits.Select((fruit, index) =>
                                      new { index, str = fruit.Substring(0, index) });

                foreach (var obj in query)
                {
                    Console.WriteLine("{0}", obj);
                }
            }
            


            //////////////////////////////////////////////////////////////////////////
            // 2) Where
            //////////////////////////////////////////////////////////////////////////
            {
                {
                    List<string> fruits =
                    new List<string> { "apple", "passionfruit", "banana", "mango",
                    "orange", "blueberry", "grape", "strawberry" };

                    IEnumerable<string> query = fruits.Where(fruit => fruit.Length < 6);

                    IEnumerable<string> parallelQuery = fruits.Where(fruit => fruit.Length < 6);

                    foreach (string fruit in query)
                    {
                        Console.WriteLine(fruit);
                    }
                }
                {
                    int[] numbers1 = { 0, 30, 20, 15, 90, 85, 40, 75 };

                    IEnumerable<int> query =
                        numbers1.Where((number, index) => number <= index * 10);

                    foreach (int number in query)
                    {
                        Console.WriteLine(number);
                    }
                }
            }
            //////////////////////////////////////////////////////////////////////////
            // 3) ToDicationary
            //////////////////////////////////////////////////////////////////////////  
            {
                {
                    var lstPersonsDic = lstPersons.Select((p) =>
                    {
                        return new
                        {
                            FullName = p.FirstName + p.LastName,
                            NextBrithday = p.Age + 1,
                            Hobby = p.Hobby,
                        };
                    }).ToDictionary(a=>a.Hobby);

                    // Example for Key as Object

                    // Select Valaue as well
                    var lstPersonsNamesDic = lstPersons.Select((p) =>
                    {
                        return new
                        {
                            FullName = p.FirstName + p.LastName,
                            NextBrithday = p.Age + 1,
                            Hobby = p.Hobby,
                        };
                    }).ToDictionary(a => a.Hobby, a=>a.FullName);




                }
            }

            //////////////////////////////////////////////////////////////////////////
            // Aggregation
            //////////////////////////////////////////////////////////////////////////            
            {

                string sentence = "the quick brown fox jumps over the lazy dog";

                //1.
                // Split the string into individual words.
                string[] words1 = sentence.Split(' ');

                // Prepend each word to the beginning of the 
                // new sentence to reverse the word order.
                string reversed = words1.Aggregate((workingSentence, next) =>
                                                      next + " " + workingSentence);

                Console.WriteLine(reversed);

                //2.
                int[] ints = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };

                // Count the even numbers in the array, using a seed value of 0.
                int numEven = ints.Aggregate(0, (total, next) =>
                                                    next % 2 == 0 ? total + 1 : total);

                Console.WriteLine("The number of even integers is: {0}", numEven);

                string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };

                //3.
                // Determine whether any string in the array is longer than "banana".
                string longestName =
                    fruits.Aggregate("banana",
                                    (longest, next) =>
                                        next.Length > longest.Length ? next : longest,
                                    // Return the final result as an upper case string.
                                    fruit => fruit.ToUpper());

                Console.WriteLine(
                    "The fruit with the longest name is {0}.",
                    longestName);
            }

            //////////////////////////////////////////////////////////////////////////
            // 5) zip
            //////////////////////////////////////////////////////////////////////////

            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };

            var numbersAndWords = numbers.Zip(words, (first, second) => first + " " + second);

            foreach (var item in numbersAndWords)
                Console.WriteLine(item);


        }
    }
}
