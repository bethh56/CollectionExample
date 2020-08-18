using System;
using System.Collections.Generic;

namespace CollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // new list of type string
            var instructors = new List<string>();
            var students = new List<string>();
            var evening11 = new List<string>();

            var numbers = new List<int>();

            instructors.Add("Jameka");
            instructors.Add("Nathan");
            instructors.Add("Dylan");

            students.Add("Beth");
            students.Add("John");
            students.Add("Monique");

            // add multiple at once from an existing list
            evening11.AddRange(instructors);
            evening11.AddRange(students);

            foreach (var person in evening11)
            {
                Console.WriteLine($"{person} is in evening cohort 11");
            }

            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(5);

            // is the string "Steve" in e11
            var steveIsInE11 = evening11.Contains("Steve");
            Console.WriteLine($"Steve is {(steveIsInE11 ? "" : "not ")}in e11.");

            //just the first match
            var matchingPerson = evening11.Find(person => person.StartsWith("J"));
            Console.WriteLine($"{matchingPerson} startes with 'J'");
            // in a list, the index is the key
            Console.WriteLine($"{students[1]} is the student at the index of 1.");

            // dictionaries have 2 generic type parameters
            var words = new Dictionary<string, string>();

            //dictionary entries are made of key value pairs, and both must be suppied to add anything
            words.Add("pedantic", "like a pedant");
            words.Add("congratulate", "to be excited for; celebrate");
            words.Add("scrupulous", "diligent, thorough, extremely attentive to details");
            //keys must be unique, this won't work if the "C" was lower case
            words.Add("Congratulate", "not a real thing");
            Console.WriteLine($"The fake definition of Congratulations is {words["congratulate"]}");

            foreach (var (word, definition) in words)
            {
                Console.WriteLine($"The fake definition of {word} is {definition}.");
            }

            var wordsWithMultipleDefinitions = new Dictionary<string, List<string>>();
            wordsWithMultipleDefinitions.Add("Scrupulous", new List<string>()
            {
                "Diligent",
                "Thorough",
                "Extremely attentive to detail"
            });

            foreach (var (word, definitions) in wordsWithMultipleDefinitions)
            {
                Console.WriteLine($"{word} is defined as :");
                foreach (var definition in definitions)
                {
                    Console.WriteLine($"    {definition}");
                }
            }

            var queue = new Queue<string>();

            queue.Enqueue("this is first");
            queue.Enqueue("second");
            queue.Enqueue("third");

            queue.
        }
    }
}
