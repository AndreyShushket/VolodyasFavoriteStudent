using System;


namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {   
            // First Task
            Console.WriteLine("Task 1");

            Console.WriteLine("Enter some text");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter the symbol you try to find");
            char desiredSymbol = Convert.ToChar(Console.ReadLine());

            char[] stringThatConvertintoChar = inputString.ToCharArray();
            int count = 0;

            for(int i = 0; i < stringThatConvertintoChar.Length; i++)
            {
                if(stringThatConvertintoChar[i] == desiredSymbol)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine("");
            
            // We can do it without array too 
            
            count = 0;

            for(int i = 0; i < inputString.Length; i ++)
            {
                if(inputString[i] == desiredSymbol)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine("");
            
            // Second Task 
            Console.WriteLine("Task 2");

            count = 0;
            string longestSurname = "";
            string[] surnames = new string[5] { "Shushket", "Saevich", "Mushket", "Sandwich", "Shrumshketski" };

            for(int i = 0; i < surnames.Length; i++)
            {
                if(surnames[i].Length > count)
                {
                    longestSurname = surnames[i];
                    count = surnames[i].Length;
                }
            }
            Console.WriteLine($"The longest surname is {longestSurname} with {count} symbols");
            Console.WriteLine("");
            
            // Third Task
            Console.WriteLine("Task 3");

            Console.WriteLine("Write some text");
            string enteredString = Console.ReadLine();
            string[] wordsFromString = enteredString.Split(' ');
            Console.WriteLine(wordsFromString.Length);
            Console.WriteLine("");
            
            // Fouth Task
            Console.WriteLine("Task 4");

            int countEven = 0;
            int countOdd = 0;
            int[] numbers = new int[11] {9, 286, 3, 44, 51, 66, 75, 8, 11, 140, 7};
            System.Array.Sort(numbers);

            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }

            int[] even = new int[countEven];
            int[] odd = new int[countOdd];

            for (int i = 0, cE = 0, cO = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even[cE] = numbers[i];
                    cE++;
                }
                else
                {
                    odd[cO] = numbers[i];
                    cO++;
                }
            }
            Console.WriteLine("");
            
            // Fifth Task
            Console.WriteLine("Task 5");
            int maxNumber = 0;
            int minNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                    
                }
                else if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }
            Console.WriteLine(maxNumber - minNumber);
            Console.WriteLine("");

            // Sixth Task
            Console.WriteLine("Task 6");

            Random random = new Random();
            int rnd1 = random.Next(3, 10);
            int rnd2 = random.Next(1, 10);

            int[,] randomArray = new int[rnd1, rnd2];
            int[] randomSortArray = new int[rnd2];

            for (int i = 0; i < rnd1; i++)
            {
                for(int j = 0; j < rnd2; j++)
                {
                    int randomNumberInArray = random.Next(1, 200);
                    randomArray[i, j] = randomNumberInArray;
                }
            }

            for(int i = 0; i < rnd1; i++)
            {
                for(int j = 0; j < rnd2; j++)
                {
                    randomSortArray[j] = randomArray[i, j];
                }
                if (i % 2 == 1)
                {
                    System.Array.Sort(randomSortArray);
                }
                else if (i % 2 == 0)
                {
                    System.Array.Sort(randomSortArray);
                    System.Array.Reverse(randomSortArray);
                }
                for (int j = 0; j < rnd2; j++)
                {
                    randomArray[i, j] = randomSortArray[j];
                }
            }
            for (int i = 0; i < rnd1; i++)
            {
                for (int j = 0; j < rnd2; j++)
                {
                    Console.Write($"{randomArray[i, j]} \t");
                }
                Console.WriteLine();
            }
            
            // Seventh Task
            Console.WriteLine("Task 7");
            string[] strangeWords = new string[3] {"abraacadaabra", "belLio", "whiite"};

            for(int i = 0; i < strangeWords.Length; i++)
            {
                strangeWords[i] = strangeWords[i].ToLower();
                for (int j = 1, k = 0; j < strangeWords[i].Length; j++)
                {
                    if (strangeWords[i][j] == strangeWords[i][k])
                    {
                        strangeWords[i] = strangeWords[i].Remove(j, 1);
                    }
                    k++;
                }
                Console.WriteLine(strangeWords[i]);
            }
        }
    }
}
