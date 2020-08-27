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
            if(word.Length != 3)
            {
                return false;
            }
            for (var dimensionPointer = 0; dimensionPointer <= 2; dimensionPointer++)
            {
                var partialMatch = true;
                for (var pointer = 0; pointer <= 2; pointer++)
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
                for (var pointer = 2; pointer >= 0; pointer--)
                {
                    if (word[pointer] != array[dimensionPointer,2 - pointer])
                    {
                        partialMatch = false;
                    }
                }
                if (partialMatch == true)
                {
                    return true;
                }
            }


            for (var dimensionPointer = 0; dimensionPointer <= 2; dimensionPointer++)
            {
                var partialMatch = true;
                for (var pointer = 0; pointer <= 2; pointer++)
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
                for (var pointer = 2; pointer >= 0; pointer--)
                {
                    if (word[pointer] != array[2 - pointer,dimensionPointer])
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
