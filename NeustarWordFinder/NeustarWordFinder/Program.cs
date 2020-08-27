using System;

namespace NeustarWordFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new char[3, 3] {{'x','y','z'},
                                      {'d','o','g'},
                                      {'a','b','c'} };

            Console.WriteLine("Please type a three letter string");
            if(CheckIfExistsInArray(Console.ReadLine(), array))
            {
                Console.WriteLine("The string is in the array");
            }
            else
            {
                Console.WriteLine("The string is not in the array");
            }
        }

        private static bool CheckIfExistsInArray(string word, char[,] array)
        {
            if(word.Length != array.GetLength(0))
            {
                return false;
            }
            for (var dimensionPointer = 0; dimensionPointer <= array.GetLength(0) - 1; dimensionPointer++)
            {
                var partialMatch = true;
                for (var pointer = 0; pointer <= array.GetLength(0) - 1; pointer++)
                {
                    if (word[pointer] != array[dimensionPointer,pointer])
                    {
                        partialMatch = false;
                    }
                }
                if(partialMatch == true)
                {
                    return true;
                }

                partialMatch = true;
                for (var pointer = array.GetLength(0) - 1; pointer >= 0; pointer--)
                {
                    if (word[pointer] != array[dimensionPointer, array.GetLength(0) - 1 - pointer])
                    {
                        partialMatch = false;
                    }
                }
                if (partialMatch == true)
                {
                    return true;
                }
            }


            for (var dimensionPointer = 0; dimensionPointer <= array.GetLength(1) - 1; dimensionPointer++)
            {
                var partialMatch = true;
                for (var pointer = 0; pointer <= array.GetLength(1) - 1; pointer++)
                {
                    if (word[pointer] != array[pointer,dimensionPointer])
                    {
                        partialMatch = false;
                    }
                }
                if (partialMatch == true)
                {
                    return true;
                }

                partialMatch = true;
                for (var pointer = array.GetLength(1) - 1; pointer >= 0; pointer--)
                {
                    if (word[pointer] != array[array.GetLength(1) - 1 - pointer,dimensionPointer])
                    {
                        partialMatch = false;
                    }
                }
                if (partialMatch == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
