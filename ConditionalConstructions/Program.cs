using System;

namespace ConditionalConstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("Exercise 1");

            // First Task
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter the number");

            try
            {
                int firstTaskEnteredNumber = Convert.ToInt32(Console.ReadLine());
                if (firstTaskEnteredNumber % 2 == 0)
                {
                    Console.WriteLine("This number is even");
                }
                else if (firstTaskEnteredNumber % 2 == 1)
                {
                    Console.WriteLine("This number is not even");
                }
                else
                {
                    Console.WriteLine("Invalid value entered");
                }
            }
            catch
            {
                Console.WriteLine("Invalid value entered");
            }
            Console.WriteLine("");
            
            // Second Task
            Console.WriteLine("Task 2");
            Console.WriteLine("Enter the mounth number");
            int mounthNumber = Convert.ToInt32(Console.ReadLine());

            switch(mounthNumber)
            {
                case 1:
                    Console.WriteLine("Winter");
                    break;
                case 2:
                    goto case 1;
                case 3:
                    Console.WriteLine("Spring");
                    break;
                case 4:
                    goto case 3;
                case 5:
                    goto case 3;
                case 6:
                    Console.WriteLine("Summer");
                    break;
                case 7:
                    goto case 6;
                case 8:
                    goto case 6;
                case 9:
                    Console.WriteLine("Fall");
                    break;
                case 10:
                    goto case 9;
                case 11:
                    goto case 9;
                case 12:
                    goto case 1;
            }
            Console.WriteLine("");
            
            // Third Task
            Console.WriteLine("Task 3");
            Console.WriteLine("Enter number a");
            int thirdTaskNumberA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number b");
            int thirdTaskNumberB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number c");
            int thirdTaskNumberC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Expression a < b < c is {thirdTaskNumberA < thirdTaskNumberB && thirdTaskNumberB < thirdTaskNumberC}");
            Console.WriteLine($"Expression b > a > c is {thirdTaskNumberB > thirdTaskNumberA && thirdTaskNumberA > thirdTaskNumberC}");
            
            
            //Fourth Task
            Console.WriteLine("Task 4");
            Console.WriteLine("Enter string on russian");
            // Dont understand how can i combine 96 and 97 line
            string russianTestEnteredString = Console.ReadLine();
            Console.WriteLine($"String contain тест is {russianTestEnteredString.Contains("тест")}");

            Console.WriteLine("");
            
            //Fifth Task
            Console.WriteLine("Task 5");
            Console.WriteLine("Enter string Ru or En");
            string fifhtTaskEnteredString = Console.ReadLine();
            string enString = "qwertyuiopasdfghjklzxcvbnmMNBVCXZLKJHGFDSAPOIUYTREWQ";
            string ruString = "йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";

            if (enString.Contains(fifhtTaskEnteredString[0]))
            {
                Console.WriteLine("Brest");
            }
            else if (ruString.Contains(fifhtTaskEnteredString[0]))
            {
                Console.WriteLine("Брест");
            }
            else
            {
                Console.WriteLine("Unknown symbols");
            }
            Console.WriteLine("");
            
            //Sixth Task
            Console.WriteLine("Task 6");
            Console.WriteLine("Enter number ");
            int sixthTaskEnteredNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sixthTaskEnteredNumber % 8 == 0 ? "correct" : "incorrect");
            Console.WriteLine("");
            
            // Second Exercise
            Console.WriteLine("Exercise 2");
            // First Task
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter xxxx number");

            int enteredNumberWithFourDigits = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                Console.Write(enteredNumberWithFourDigits % 10);
                enteredNumberWithFourDigits /= 10;
            }
            Console.WriteLine("");
            
            // Second Task
            Console.WriteLine("Task 2");
            Console.WriteLine("Enter xxxx number");
            int secondTaskNumer = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < 4; i++)
            {
                int secondTaskSecondNumber = secondTaskNumer % 10;
                secondTaskNumer /= 10;

                if (secondTaskSecondNumber == 7)
                {
                    count++;
                }   
            }
            Console.WriteLine($"Number have  two 7 is {count == 2}");
            Console.WriteLine("");
            
            //Third Task
            Console.WriteLine("Task 3");
            Console.WriteLine("Enter xxxx number");

            int thirdTaskNumber = Convert.ToInt32(Console.ReadLine());
            int firstNumberOfEnteredNumber = thirdTaskNumber % 10;
            thirdTaskNumber /= 10;
            int secondNumberOfEnteredNumber = thirdTaskNumber % 10; ;
            thirdTaskNumber /= 10;
            int thirdNumberOfEnteredNumber = thirdTaskNumber % 10; ;
            thirdTaskNumber /= 10;
            int fourthNumberOfEnteredNumber = thirdTaskNumber;

            Console.WriteLine($"Sum of first two numbers equal to sum of two numbers is {firstNumberOfEnteredNumber + secondNumberOfEnteredNumber == thirdNumberOfEnteredNumber + fourthNumberOfEnteredNumber}");
            Console.WriteLine("");
            
            // Third Exercise
            Console.WriteLine("Exercise 3");
            // First Task
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter a x.xxxxx number ");

            double firstTaskDoudleNumber = Convert.ToDouble(Console.ReadLine());
            firstTaskDoudleNumber = firstTaskDoudleNumber / 0.00001;
            firstTaskDoudleNumber = firstTaskDoudleNumber % 100000;
            int fiveNumberAfterPoint = Convert.ToInt32(firstTaskDoudleNumber);
            for(int i = 0; i < 5; i++)
            {
                int num2 = fiveNumberAfterPoint % 10;
                fiveNumberAfterPoint /= 10;
                if( num2 == 0)
                {
                    Console.WriteLine("have 0");
                    break;
                }
                else
                {
                    Console.WriteLine("dont have 0");
                }
            }
            
            // Second Task
            Console.WriteLine("Task 2");
            Console.WriteLine("Enter a x.xxxx number ");

            double secondTaskDoudleNum = Convert.ToDouble(Console.ReadLine());
            secondTaskDoudleNum = secondTaskDoudleNum / 0.0001;
            secondTaskDoudleNum = secondTaskDoudleNum % 10000;
            int fourNumberAfterPoint = Convert.ToInt32(secondTaskDoudleNum);
            for (int i = 0; i < 4; i++)
            {
                int num2 = fourNumberAfterPoint % 10;
                fourNumberAfterPoint /= 10;
                if (num2 == 9)
                {
                    Console.WriteLine("have 9");
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("");

            // Third Task
            Console.WriteLine("Task 3");
            Console.WriteLine("Enter a x.xxxx number ");
            double thirdTaskDoudleNumber = Convert.ToDouble(Console.ReadLine());

            thirdTaskDoudleNumber = thirdTaskDoudleNumber / 0.0001;
            thirdTaskDoudleNumber = thirdTaskDoudleNumber % 10000;

            int num11 = Convert.ToInt32(thirdTaskDoudleNumber);
            int firstNumberToSum = 0;
            int secondNumberToSum = 0;

            for (int i = 0; i < 4; i++)
            {
                int num2 = num11 % 10;
                num11 /= 10;
                if(i == 0)
                {
                    firstNumberToSum = num2;
                }
                if(i == 3)
                {
                    secondNumberToSum = num2;
                }
            }
            Console.WriteLine($"Its {firstNumberToSum == secondNumberToSum} that they are equal");
            Console.WriteLine("");

            // Fourth Exercise 
            Console.WriteLine("Exercise 4");

            // First Task
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter year number");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"This leap year is {year % 4 == 0}");
            Console.WriteLine("");

            // Second Task
            Console.WriteLine("Task 2");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"They are equal is {x == y && y == z}");
            Console.WriteLine("");

            // Third Task
            Console.WriteLine("Task 3");

            int task3X = Convert.ToInt32(Console.ReadLine());
            int task3Y = Convert.ToInt32(Console.ReadLine());
            int task3Z = Convert.ToInt32(Console.ReadLine());
            int count1 = 0;
            
            if(task3X > 0)
            {
                count1++;
            }
            if(task3Y > 0)
            {
                count1++;
            }
            if(task3Z > 0)
            {
                count1++;
            }
            Console.WriteLine(count1 == 1);
            Console.WriteLine("");

            // Fifth Exercise 
            Console.WriteLine("Exercise 5");

            // First Task
            Console.WriteLine("Task 1");

            int task1X = Convert.ToInt32(Console.ReadLine());
            int task1Y = Convert.ToInt32(Console.ReadLine());
            int task1Z = Convert.ToInt32(Console.ReadLine());
            int per = 0;

            if(task1X > task1Y)
            {
                per = task1X;
                task1X = task1Y;
                task1Y = per;
            }
            if(task1Y > task1Z)
            {
                per = task1Y;
                task1Y = task1Z;
                task1Z = per;
            }
            if (task1X > task1Y)
            {
                per = task1X;
                task1X = task1Y;
                task1Y = per;
            }
            Console.WriteLine($"{task1X}, {task1Y}, {task1Z}");

            
        }
    }
}
