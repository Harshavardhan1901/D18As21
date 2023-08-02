using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Welcome to Learning-----------");

            // Create lists for days, months, fruits, and words/meanings
            List<string> days = new List<string>
            {
                "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
            };

            List<string> months = new List<string>
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
            };

            List<string> fruits = new List<string>
            {
                "Apple", "Banana", "Grapes", "Orange", "Mango", "Pineapple", "Watermelon", "Strawberry", "Cherry", "Peach"
            };

            Dictionary<string, string> words = new Dictionary<string, string>
            {
                {"Abundant", "Present in great quantity; more than adequate; oversufficient; plentiful; as, abundant rain; an abundant harvest."},
                {"Benevolent", "Desiring to do good to others; having a disposition to do good; possessing or manifesting love to mankind, and a desire to promote their prosperity and happiness; disposed to give to good objects; kind; charitable."},
                {"Effervescent", "Gently boiling, bubbling, or fizzing."},
                {"Luminous", "Emitting light; full of light; shining; bright; as, the sun is a luminous body."},
                {"Pristine", "Original; primitive; ancient; pure; uncorrupted; as, pristine virtues; a pristine state."}
            };

            // Use threading to display days and months simultaneously
            var startTime = DateTime.Now;
            DisplayDays(days);
            var endTime = DateTime.Now;
            Console.WriteLine("Start time: " + startTime + " End time: " + endTime);
            Thread.Sleep(5000);
            var startTime1 = DateTime.Now;
            DisplayMonths(months);
            var endTime1 = DateTime.Now;
            Console.WriteLine("Start time: " + startTime1 + " End time: " + endTime1);
            Thread thread1 = new Thread(() => DisplayFruits(fruits));
            Thread thread2 = new Thread(() => DisplayWords(words));
            thread1.Start();
            thread2.Start();
        }

        // Method to display days
        static void DisplayDays(List<string> days)
        {
            Console.WriteLine("-----------Days-----------");
            foreach (var day in days)
            {
                Console.WriteLine(day);
                Thread.Sleep(2000); // Wait for 2 seconds before displaying the next day
            }
        }

        // Method to display months
        static void DisplayMonths(List<string> months)
        {
            Console.WriteLine("-----------Months-----------");
            foreach (var month in months)
            {
                Console.WriteLine(month);
                Thread.Sleep(2000); // Wait for 2 seconds before displaying the next month
            }
        }

        // Method to display fruits
        static void DisplayFruits(List<string> fruits)
        {
            Console.WriteLine("-----------Fruits-----------");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
                Thread.Sleep(1000);
            }
        }

        // Method to display words and their meanings
        static void DisplayWords(Dictionary<string, string> words)
        {
            Console.WriteLine("-----------Words and Meanings-----------");
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key}: {word.Value}");
                Thread.Sleep(1500);
            }
            Console.ReadKey();
        }
    }
}
