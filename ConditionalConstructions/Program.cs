using System;

namespace ConditionalConstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1");
            /*
            // First Task
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter the number");
            int firstTaskNumber = Convert.ToInt32(Console.ReadLine());

            int evenOrNot = firstTaskNumber % 2;
            if (evenOrNot == 0)
            {
                Console.WriteLine("This number is even");
            }
            else if (evenOrNot == 1)
            {
                Console.WriteLine("This number is not even");
            }
            else
            {
                Console.WriteLine("Invalid value entered");
            }
            Console.WriteLine("");

            // Second Task
            Console.WriteLine("Task 2");
            Console.WriteLine("Enter the mounth number");

            int MounthNumber = Convert.ToInt32(Console.ReadLine());

            if (MounthNumber >= 1 && MounthNumber <= 2)
            {
                Console.WriteLine("Winter");
            }
            else if ( MounthNumber >= 3 && MounthNumber <= 5)
            {
                Console.WriteLine("Spring");
            }
            else if (MounthNumber >= 6 && MounthNumber <= 8 )
            {
                Console.WriteLine("Summer");
            }
            else if (MounthNumber >= 9 && MounthNumber <= 11)
            {
                Console.WriteLine("Autumn");
            }
            else if (MounthNumber == 12)
            {
                Console.WriteLine("Winter");
            }
            else
            {
                Console.WriteLine("Invalid number");
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

            if (thirdTaskNumA < thirdTaskNumB && thirdTaskNumB < thirdTaskNumC )
            {
                Console.WriteLine("Expression a < b < c is true");
            }
            else if ( thirdTaskNumB > thirdTaskNumA && thirdTaskNumA > thirdTaskNumC)
            {
                Console.WriteLine("expression b > a > c is true");
            }
            else
            {
                Console.WriteLine("None of it true");
            }
            Console.WriteLine("");
            
            //Fourth Task
            Console.WriteLine("Task 4");
            Console.WriteLine("Enter string on russin");

            string FourthTaskString = Console.ReadLine();

            if(FourthTaskString.Contains("тест"))
            {
                Console.WriteLine("String contain тест");
            }
            else
            {
                Console.WriteLine("String do not contain тест");
            }
            Console.WriteLine("");
            
            //Fifth Task
            Console.WriteLine("Task 5");

            Console.WriteLine("Enter string Ru or En");
            string firfhTaskString = Console.ReadLine();
            string enString = "qwertyuiopasdfghjklzxcvbnmMNBVCXZLKJHGFDSAPOIUYTREWQ";
            string ruString = "йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";

            if (enString.Contains(firfhTaskString[0]))
            {
                Console.WriteLine("Brest");
            }
            else if (ruString.Contains(firfhTaskString[0]))
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

            sixthTaskNumber = sixthTaskNumber % 8;

            string answerSixthTask = sixthTaskNumber == 0 ? "correct" : "incorrect";
            Console.WriteLine(answerSixthTask);
            Console.WriteLine("");
            
            // Second Exercise
            Console.WriteLine("Exercise 2");
            // First Task
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter xxxx number");

            int firstTaskNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                int firstTaskSecNum = firstTaskNum % 10;
                Console.Write(firstTaskSecNum);
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
            if (count < 2)
            {
                Console.WriteLine("Less then two 7");
            }
            else if (count == 2)
            {
                Console.WriteLine("Two 7");
            }
            else if (count > 2)
            {
                Console.WriteLine("More then two 7");
            }
            Console.WriteLine("");
            
            //Third Task
            Console.WriteLine("Task 3");
            Console.WriteLine("Enter xxxx number");

            int thirdTaskNum = Convert.ToInt32(Console.ReadLine());
            int firstHalh = 0;
            int secHalf = 0;
            for (int i = 0; i < 2; i++)
            {
                int thirdTaskSecNum = thirdTaskNum % 100;
                thirdTaskNum /= 100;

                int thirdTaskThirdNum = thirdTaskSecNum % 10;
                thirdTaskSecNum /= 10;

                if ( i == 0)
                {
                    firstHalh = thirdTaskThirdNum + thirdTaskSecNum;
                }
                else if ( i == 1)
                {
                    secHalf = thirdTaskThirdNum + thirdTaskSecNum;
                }

            }
            if (firstHalh == secHalf)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They are not equal");
            }
            Console.WriteLine("");
            
            // Third Exercise

            Console.WriteLine("Exercise 3");
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
            

            Console.WriteLine("Task 2");

            Console.WriteLine("Enter a x.xxxx number ");

            double secondTaskDoudleNum = Convert.ToDouble(Console.ReadLine());
            secondTaskDoudleNum = secondTaskDoudleNum / 0.0001;
            secondTaskDoudleNum = secondTaskDoudleNum % 10000;
            int num = Convert.ToInt32(secondTaskDoudleNum);
            for (int i = 0; i < 4; i++)
            {
                int num2 = num % 10;
                num /= 10;
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
            int num = Convert.ToInt32(thirdTaskDoudleNum);
            int firNumTooSum = 0;
            int secNumTooSum = 0;

            for (int i = 0; i < 4; i++)
            {
                int num2 = num % 10;
                num /= 10;
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
            int count = 0;
            
            if(task3X > 0)
            {
                count++;
            }
            if(task3Y > 0)
            {
                count++;
            }
            if(task3Z > 0)
            {
                count++;
            }
            if( count == 1)
            {
                Console.WriteLine(positive = true);
            }
            else
            {
                Console.WriteLine(positive = false);
            }
            */
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
