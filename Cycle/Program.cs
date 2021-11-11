using System;

namespace Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            // First Task
            Console.WriteLine("Task 1");

            for(int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");

            int firstTaskWhileI = 1;
            while(firstTaskWhileI <= 50)
            {
                Console.WriteLine(firstTaskWhileI);
                firstTaskWhileI++;
            }
            
            // Second Task
            Console.WriteLine("Task 2");
            for (int i = 0, j = 0; i <= 10; i++)
            {
                Console.WriteLine(j = i + j);
            }
            Console.WriteLine("");

            int secondTaskWhileI = 0;
            int j1 = 0;
            while( secondTaskWhileI <= 10)
            {
                Console.WriteLine(j1 = j1 + secondTaskWhileI);
                secondTaskWhileI++;
            }
            Console.WriteLine("");
            
            // Third Task
            Console.WriteLine("Task 3");

            int count = 0;
            for(int i = 1000; i > 50;)
            {
                Console.WriteLine(i = i / 2);
                count++;
            }
            Console.WriteLine(count);
            Console.WriteLine("");

            count = 0;
            int thirdTaskWhileI = 1000;
            while(thirdTaskWhileI > 50)
            {
                Console.WriteLine(thirdTaskWhileI = thirdTaskWhileI / 2);
                count++;
            }
            Console.WriteLine("");
            Console.WriteLine(count);
            
            //Fourth Task
            Console.WriteLine("Task 4");

            int numberOfStrings = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= numberOfStrings; i++)
            {
                for(int j1 = 1; j1 <= i; j1++)
                {
                    Console.Write(j1);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            int fourthTaskWhileNumber = 1;
            while(fourthTaskWhileNumber <= numberOfStrings)
            {
                int fourthTaskSecondWhileNumber = 1;
                while (fourthTaskSecondWhileNumber <= fourthTaskWhileNumber)
                {
                    Console.Write(fourthTaskSecondWhileNumber);
                    fourthTaskSecondWhileNumber++;
                }
                fourthTaskWhileNumber++;
                Console.WriteLine("");
            }
            Console.WriteLine("");
            
            // Fifth Task
            Console.WriteLine("Task 5");

            for (; ; )
            {
                Random random = new Random();
                int rnd = random.Next(0, 5);
                Console.WriteLine("Guess The number, but u got only 5 tries! Are you ready? yes or no");
                string agreement = Console.ReadLine();
                if(agreement.Equals("yes"))
                {
                    for (int i = 0; i <= 5; i++)
                    {
                        if (i == 5)
                        {
                            Console.WriteLine("Bruh, you are out of your tries, start over!");
                            break;
                        }
                        Console.WriteLine("Enter your number!!");
                        int customNumber = Convert.ToInt32(Console.ReadLine());
                        if (customNumber == rnd)
                        {
                            Console.WriteLine("You are correct!");
                            break;
                        }
                        if (customNumber > rnd)
                        {
                            Console.WriteLine("Your number a bit bigger, try again!");
                            Console.WriteLine("Or you wonna pick a new random number yes or no?");
                            string pickNewRandomNumber = Console.ReadLine();
                            if (pickNewRandomNumber.Equals("yes"))
                            {
                                Console.WriteLine("Okay then");
                                break;
                            }
                            else if (pickNewRandomNumber.Equals("no"))
                            {
                                Console.WriteLine("Well, good luck");
                                continue;
                            }
                            continue;
                        }
                        if (customNumber < rnd)
                        {
                            Console.WriteLine("Your number a bit smaller, try again!");
                            Console.WriteLine("Or you wonna pick a new random number yes or no?");
                            string pickNewRandomNumber = Console.ReadLine();
                            if (pickNewRandomNumber.Equals("yes"))
                            {
                                Console.WriteLine("Okay then");
                                break;
                            }
                            else if (pickNewRandomNumber.Equals("no"))
                            {
                                Console.WriteLine("Well, good luck");
                                continue;
                            }
                            continue;
                        }
                    }
                }
                else if(agreement.Equals("no"))
                {
                    Console.WriteLine("See you soon then");
                    break;
                }
            }
        }
    }
}
