using System;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 100, 5, 6 };

            //Console.WriteLine(ChallengeOne());
            //ChallengeTwo();

            //ChallengeThree();

            //ChallengeFive(myArray);

            //ChallengeSix();
            //ChallengeSeven();

            ChallengeEight();
        }

        static int ChallengeOne()
        {
            //ask user for 3 numbers
            //if user inputs less than 3 numbers return zero
            //if user inputs more than 3 numbers, only multiply the first 3
            //if input isn't numbers return 1
            int functionResult = 1;

            Console.WriteLine("Please enter 3 numbers seperated by spaces:");
            string inputNumbers = Console.ReadLine();
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

        static void ChallengeTwo()
        {
            

            bool runProgram = true;

            while (runProgram)
            {
                Console.WriteLine("Please enter a number between 2 - 10");
                int amountOfNumbers = Convert.ToInt32(Console.ReadLine());

                double[] array = new double[0];

                double sum = 0;

                if (amountOfNumbers < 2 || amountOfNumbers > 10)
                {
                    Console.WriteLine("Wrong input try again");
                    runProgram = false;
                }
                else
                {
                    array = new double[amountOfNumbers];

                }


                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"please enter number {i+1} of {array.Length}");

                    double inputNow = Convert.ToDouble(Console.ReadLine());

                    array[i] = inputNow;
                    sum += inputNow;

                }

                double average = sum / amountOfNumbers;
                Console.WriteLine($"The average of those numbers is {average}");

                break;
            }

        }

        static void ChallengeThree()
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
                for (int j = spaceCounter; j < spaceCounter+1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k > starCounter; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
                spaceCounter++;
                starCounter -= 2;
            }
            
        }

        static int ChallengeFour(int[] x)
        {
            int[] passedArray = x;
            int result = passedArray[0];
            //return the most repeated element in an array
            //if no duplicates or same number repeats more than one time, return first number
            for (int i = 0; i < passedArray.Length; i++)
            {
                //I didn't know how to solve it tbh
            }
            
            return result;
        }


        static void ChallengeFive(int[] x)
        {
            int maxValue = 0;
            int[] passedArray = x;


            for (int i = 0; i < passedArray.Length; i++)
            {
                if (passedArray[i] > maxValue)
                {
                    maxValue = passedArray[i];
                }
            }

            Console.WriteLine(maxValue);
        }

        static void ChallengeSix()
        {
            string myPath = "./My New Text File.txt";
            Console.WriteLine("Please input a word to save in a file");
            string myWord = Console.ReadLine();
            string updatedWord = $"\n{myWord}";


            File.AppendAllText(myPath, updatedWord);
            
        }

        static void ChallengeSeven()
        {
            string myPath = "./My New Text File.txt";
            Console.WriteLine("These are the results from My Text File: ");

            Console.WriteLine(File.ReadAllText(myPath));

        }

        static void ChallengeEight()
        {
            string myPath = "./My New Text File.txt";

            string myText = File.ReadAllText(myPath);
            string[] myFormattedText = myText.Split("\n");

            //Save last word
            string myLastWord = myFormattedText[myFormattedText.Length - 1];

            //Remove last word
            myFormattedText[myFormattedText.Length - 1] = "";

            //add last word back to array
            myFormattedText[myFormattedText.Length - 1] = myLastWord;

            //loop over my array of strings and add them back to file
            for (int i = 0; i < myFormattedText.Length; i++)
            {
                File.AppendAllText(myPath, myFormattedText[i]);
            }

        }

        void ChallengeNine()
        {

        }








    }
}
