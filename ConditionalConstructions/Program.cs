using System;

namespace ConditionalConstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            
           /*
            Console.WriteLine("Exercise 1");

            // First Task
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter the number");

            try
            {
                int firstTaskNumber = Convert.ToInt32(Console.ReadLine());
                if (firstTaskNumber % 2 == 0)
                {
                    Console.WriteLine("This number is even");
                }
                else if (firstTaskNumber % 2 == 1)
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
            int thirdTaskNumA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number b");
            int thirdTaskNumB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number c");
            int thirdTaskNumC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Expression a < b < c is {thirdTaskNumA < thirdTaskNumB && thirdTaskNumB < thirdTaskNumC}");
            Console.WriteLine($"Expression b > a > c is {thirdTaskNumB > thirdTaskNumA && thirdTaskNumA > thirdTaskNumC}");
            
            
            //Fourth Task
            Console.WriteLine("Task 4");
            Console.WriteLine("Enter string on russin");
            // Dont understand how can i combine 96 and 97 line
            string fourthTaskString = Console.ReadLine();
            Console.WriteLine($"String contain тест is {fourthTaskString.Contains("тест")}");

            Console.WriteLine("");
            
            //Fifth Task
            Console.WriteLine("Task 5");
            Console.WriteLine("Enter string Ru or En");
            string fifhTaskString = Console.ReadLine();
            string enString = "qwertyuiopasdfghjklzxcvbnmMNBVCXZLKJHGFDSAPOIUYTREWQ";
            string ruString = "йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";

            if (enString.Contains(fifhTaskString[0]))
            {
                Console.WriteLine("Brest");
            }
            else if (ruString.Contains(fifhTaskString[0]))
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
            int sixthTaskNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sixthTaskNumber % 8 == 0 ? "correct" : "incorrect");
            Console.WriteLine("");
            
            // Second Exercise
            Console.WriteLine("Exercise 2");
            // First Task
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter xxxx number");

            int firstTaskNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                Console.Write(firstTaskNum % 10);
                firstTaskNum /= 10;
            }
            Console.WriteLine("");
            
            // Second Task
            Console.WriteLine("Task 2");
            Console.WriteLine("Enter xxxx number");
            int secondTaskNum = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < 4; i++)
            {
                int secondTaskSecNum = secondTaskNum % 10;
                secondTaskNum /= 10;

                if (secondTaskSecNum == 7)
                {
                    count++;
                }   
            }
            Console.WriteLine($"Number have  two 7 is {count == 2}");
            Console.WriteLine("");
            
            //Third Task
            Console.WriteLine("Task 3");
            Console.WriteLine("Enter xxxx number");

            int thirdTaskNum = Convert.ToInt32(Console.ReadLine());
            int firstNumberOfEnteredNumber = thirdTaskNum % 10;
            thirdTaskNum /= 10;
            int secondNumberOfEnteredNumber = thirdTaskNum % 10; ;
            thirdTaskNum /= 10;
            int thirdNumberOfEnteredNumber = thirdTaskNum % 10; ;
            thirdTaskNum /= 10;
            int fourthNumberOfEnteredNumber = thirdTaskNum;

            Console.WriteLine($"Sum of first two numbers equal to sum of two numbers is {firstNumberOfEnteredNumber + secondNumberOfEnteredNumber == thirdNumberOfEnteredNumber + fourthNumberOfEnteredNumber}");
            Console.WriteLine("");
            */
            // Third Exercise
            Console.WriteLine("Exercise 3");
            // First Task
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter a x.xxxxx number ");

            double firstTaskDoudleNum = Convert.ToDouble(Console.ReadLine());
            firstTaskDoudleNum = firstTaskDoudleNum / 0.00001;
            firstTaskDoudleNum = firstTaskDoudleNum % 100000;
            int num = Convert.ToInt32(firstTaskDoudleNum);
            for(int i = 0; i < 5; i++)
            {
                int num2 = num % 10;
                num /= 10;
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
            int num1 = Convert.ToInt32(secondTaskDoudleNum);
            for (int i = 0; i < 4; i++)
            {
                int num2 = num1 % 10;
                num1 /= 10;
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
            
            Console.WriteLine("Task 3");
            Console.WriteLine("Enter a x.xxxx number ");
            double thirdTaskDoudleNum = Convert.ToDouble(Console.ReadLine());
            thirdTaskDoudleNum = thirdTaskDoudleNum / 0.0001;
            thirdTaskDoudleNum = thirdTaskDoudleNum % 10000;
            int num11 = Convert.ToInt32(thirdTaskDoudleNum);
            int firNumTooSum = 0;
            int secNumTooSum = 0;

            for (int i = 0; i < 4; i++)
            {
                int num2 = num11 % 10;
                num11 /= 10;
                if(i == 0)
                {
                    firNumTooSum = num2;
                }
                if(i == 3)
                {
                    secNumTooSum = num2;
                }
            }
            if( firNumTooSum == secNumTooSum)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
            
            Console.WriteLine("Exercise 4");
            Console.WriteLine("Task 1");

            int year = Convert.ToInt32(Console.ReadLine());
            bool vYear;
            year = year % 4;
            if(year == 0)
            {
                Console.WriteLine(vYear = true);
            }
            else
            {
                Console.WriteLine(vYear = false);
            }
            
            Console.WriteLine("Task 2");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            bool eqOrNot;

            if( x == y && y == z)
            {
                Console.WriteLine(eqOrNot = true);
            }
            else
            {
                Console.WriteLine(eqOrNot = false);
            }
            
            Console.WriteLine("Task 3");

            int task3X = Convert.ToInt32(Console.ReadLine());
            int task3Y = Convert.ToInt32(Console.ReadLine());
            int task3Z = Convert.ToInt32(Console.ReadLine());
            bool positive;
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
            if( count1 == 1)
            {
                Console.WriteLine(positive = true);
            }
            else
            {
                Console.WriteLine(positive = false);
            }
            
            Console.WriteLine("Exercise 5");
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
