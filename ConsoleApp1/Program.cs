using System;
using System.IO;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { -1, -2, -3, -5, -6, -5, -5, -6 };

            //string[] something = { "2", "hi" };
            //Console.WriteLine(something.GetType());

            static void ChallengeOneHandler()
            {
                //Challenge 1:
                Console.WriteLine("Please enter 3 numbers seperated by spaces:");
                string myInput = Console.ReadLine();
                Console.WriteLine(ChallengeOne(myInput));
            }

            static void ChallengeTwoHandler()
            {
                //Challenge 2:

                int[] array = new int[0];


                bool runProgram = true;

                while (runProgram)
                {
                    Console.WriteLine("Please enter a number between 2 - 10");
                    int amountOfNumbers = Convert.ToInt32(Console.ReadLine());


                    int sum = 0;

                    if (amountOfNumbers < 2 || amountOfNumbers > 10)
                    {
                        Console.WriteLine("Wrong input try again");
                        runProgram = false;
                    }
                    else
                    {
                        array = new int[amountOfNumbers];
                    }
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine($"please enter number {i + 1} of {array.Length}");

                        int inputNow = Convert.ToInt32(Console.ReadLine());

                        array[i] = inputNow;
                    }
                    break;
                }
                Console.WriteLine($"The average of these numbers is: {ChallengeTwo(array)}"); 
            }

            //Challenge 3:
            //ChallengeThree();

            //Challenge 4:
            //Console.WriteLine(ChallengeFour(myArray)); 

            //Challenge 5:
            //ChallengeFive(myArray);

            //Challenge 6:
            //ChallengeSix();

            //Challenge 7:
            //ChallengeSeven();

            //Challenge 8:
            ChallengeEight();

            //Challenge 9:
            //ChallengeNine();
        }

        public static int ChallengeOne(string input)
        {
            //ask user for 3 numbers
            //if user inputs less than 3 numbers return zero
            //if user inputs more than 3 numbers, only multiply the first 3
            //if input isn't numbers return 1
            int functionResult = 1;

            string inputNumbers = input;

            string[] seperatedNumbers = inputNumbers.Split(" ");

            if (seperatedNumbers.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    int num = Convert.ToInt32(seperatedNumbers[i]);
                    Type type = typeof(int);
                    Type type1 = num.GetType();
                    if (type != type1)
                    {
                        functionResult = 1;
                        break;
                    }
                    else
                    {
                        functionResult *= num;
                    }

                }
            }

            if (seperatedNumbers.Length < 3)
            {
                functionResult = 0;
            }


            return functionResult;
        }

        public static int ChallengeTwo(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

           int avg = sum / arr.Length;

            return avg;
        }

        public static void ChallengeThree()
        {
            int spaceCounter = 4;
            int starCounter = 1;
            
            //print first 5 lines
            for (int i = 0; i < 5; i++)
            {
                for (int j = spaceCounter; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < starCounter; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
                spaceCounter--;
                starCounter += 2;
            }

            spaceCounter = 1;
            starCounter = 7;
            //print last 4 lines
            for (int h = 0; h < 4; h++)
            {
                for (int j = 0; j < spaceCounter; j++)
                {
                    Console.Write(" ");

                }
                for (int k = 0; k < starCounter; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
                spaceCounter++;
                starCounter -= 2;
            }
            
        }

        public static int ChallengeFour(int[] arr)
        {
            int firstCounter = 0;
            int secondCounter = 0;
            int repetition = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        firstCounter++;
                    }
                }
                if (firstCounter > secondCounter)
                {
                    secondCounter = firstCounter;
                    repetition = arr[i];
                }
                firstCounter = 0;
            }
            return repetition;
        }

        public static int ChallengeFive(int[] x)
        {
            int[] passedArray = x;

            //Note: I set this to 0 at the beginning and it didn't work with negative numbers
            //So just set it to first element of array
            int maxValue = passedArray[0];


            for (int i = 0; i < passedArray.Length; i++)
            {
                if (passedArray[i] > maxValue)
                {
                    maxValue = passedArray[i];
                }
            }

            Console.WriteLine(maxValue);
            return maxValue;
        }

        public static void ChallengeSix()
        {
            string myPath = "./words.txt";
            Console.WriteLine("Please input a word to save in a file");

            string myWord = Console.ReadLine();

            string updatedWord = $"{myWord}\n";

            File.AppendAllText(myPath, updatedWord);
            
        }

        public static void ChallengeSeven()
        {
            string myPath = "./words.txt";

            Console.WriteLine("These are the results from My Text File: ");

            Console.WriteLine(File.ReadAllText(myPath));

        }

        public static void ChallengeEight()
        {
            string myPath = "./words.txt";

            string myText = File.ReadAllText(myPath);

            string[] myFormattedText = myText.Split("\n");


            //Save a word
            string myLastWord = myFormattedText[myFormattedText.Length - 1];

            //Remove last word
            myFormattedText[myFormattedText.Length - 1] = " ";


            //Write everything to file again to remove the word
            for (int i = 0; i < myFormattedText.Length; i++)
            {
                File.WriteAllText(myPath, $"{myFormattedText[i]}\n");
            }
            
            //add removed word or last word back to array
            File.AppendAllText(myPath, $"{myLastWord}\n");

        }

        public static string[] ChallengeNine(string input)
        {
            string[] inputArray = input.Split();

            string[] outputArray = new string[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                outputArray[i] = $"{inputArray[i]}: {inputArray[i].Length}";
            }
            return outputArray;
        }








    }
}
