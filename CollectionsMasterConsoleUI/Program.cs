using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            var numbers = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            static void ArrayMaker(int[] numbers)
            {
                for(var i = 0; i < 50; i++)
                {
                    numbers[i] = i;
                }
            }
            ArrayMaker(numbers);

            //Print the first number of the array
            Console.WriteLine(numbers[0]);

            //Print the last number of the array            
            Console.WriteLine(numbers[49]);

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            static void NumberPrinter(int[] numbers)
            {
                foreach(var num in numbers)
                {
                    Console.WriteLine(num);
                }
            }
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */
            static void RegularReverse(int[] numbers)
            {
                Array.Reverse(numbers);
                Console.WriteLine(string.Join(" ", numbers));
            }
            
            Console.WriteLine("All Numbers Reversed:");
            RegularReverse(numbers);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);
            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var numberList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine(numberList.Count);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            


            //Print the new capacity
            Console.WriteLine(numberList.Count);

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            //NumberPrinter();
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            

            //Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            
        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }        

        private static void ReverseArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int tmp = numbers[i];
                numbers[i] = numbers[numbers.Length - i - 1];
                numbers[numbers.Length - i - 1] = tmp;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
