using System;

namespace HomeworkFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            // TODO: write code to ask for input array of numbers, then which number we want to find
            // and then output first and last occurrences into console

            
            int[] items = new int[5];
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("Please enter your number: ");
                string itemsString = Console.ReadLine();
                items[i] = Int32.Parse(itemsString);
              
            }
                        
            Console.WriteLine("Which number you want to find?");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);
            int realNumber = number-1;
            Console.WriteLine(items[realNumber]);

           Console.ReadKey();
        } 

        // TODO : Find index of first occurrence in integer array. Solve using loop of your choice.
        public static int LastIntegerIndex(int[] items, int numberToFind)
            
        {
            
            // TODO: Delete following line before implementing.
            throw new NotImplementedException();
        }

        // TODO : Find index of last occurrence in given array. Solve using loop of your choice.
        public static int FirstIntegerIndex(int[] items, int numberToFind)
        {
            // TODO: Delete following line before implementing.
            throw new NotImplementedException();
        }
    }
}
