using Newtonsoft.Json;
using System;
using System.Xml;

namespace nuggets
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlText = "<root> <title>users storage</title> <user id='1'> <name>Vasya</name> </user> <user id='2'> <name>Kolya</name> </user> </root>";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlText);
            string json = JsonConvert.SerializeXmlNode(doc);
            Console.WriteLine(json);
            Console.WriteLine();

            // Second Task 
            Console.WriteLine("Task 2");
            VasyaIntrodused();
            KolyaIntrodused();
            Console.WriteLine();

            // Third Task
            Console.WriteLine("Task 3");
            SayMyName("Andrey");
            SayMyName("Nikita");
            Console.WriteLine();

            // Fourth Task
            Console.WriteLine("Task 4");
            // Ask Sensei about this task, couse in task was "который принимает в кач-ве параметра возраст и отображает его в консоли", like only age or age is the second parameter? 
            Introduction("Masha", 18);
            Console.WriteLine();

            // Fifth Task
            Console.WriteLine("Task 5");
            SmartIntroduction("Makar", 1);
            SmartIntroduction("Dima", 3);
            SmartIntroduction("Obama", 26);
            Console.WriteLine();

            // Sixth Task
            Console.WriteLine("Task 6");
            SmarterThanFifthIntroduction("Andrey", 0);
            SmarterThanFifthIntroduction("Max", 1);
            Console.WriteLine();

            // Seventh Task
            Console.WriteLine("Task 7");
            ALotOfNames(60, "Andrey", "Nikita", "Volodza");
            Console.WriteLine();

            // Eighth Task
            Console.WriteLine("Task 8");
            string[] names = new string[] { "Andrey", "Vova", "Victor",};
            string[] surnames = new string[] { "Shushket", "Bombasta", "Godzila" };
            string[] fullName = TwoArrayInOne(names, surnames);
            Console.WriteLine();

            // Ninth Task
            Console.WriteLine("Task 9");
            string name = Console.ReadLine();
            int bet = Convert.ToInt32(Console.ReadLine());
            Bet(name, bet);
            Console.WriteLine();

            // Tenth Task
            Console.WriteLine("Task 10");
            string[] bettors = new string[] {"Vasya - 3", "Kolya - 6", "Andrey = 1", "Nikita - 8"};
            Bettors(bettors);
            Console.WriteLine();

            // Eleventh Task
            Console.WriteLine("Task 11");
            Random random = new Random();
            ShortVersionOfCompareNumbers(1, random);
            Console.WriteLine();

            // Twelfth Task
            Console.WriteLine("Task 12");
            Console.WriteLine("Enter time in format xx,yy");
            double time = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(DateTimeGreatings(time));
            Console.WriteLine();

            // Thirteenth Task
            Console.WriteLine("Task 13");
            string[] text = new string[] {"one", "two", "three", "four", "five"};
            int[] numberOfStrings = new int[] {1, 2, 3, 4, 5, 6};
            GlueArrays(text, numberOfStrings);

        }
        // Second task methods
        public static void VasyaIntrodused() => Console.WriteLine("My name is Vasya");
        public static void KolyaIntrodused() => Console.WriteLine("My name is Kolya");
        // Third task method
        public static void SayMyName(string name) => Console.WriteLine($"My name is {name}");
        // Fourth task method
        public static void Introduction(string name, int age) => Console.WriteLine($"My name is {name} and i am {age} years old");
        // Fifth task method
        public static void SmartIntroduction(string name, int age)
        {
            if( age > 1)
            {
                Console.WriteLine($"My name is {name} and i am {age} years old");
            }
            else
            {
                Console.WriteLine($"My name is {name} and i am {age} year old");
            }
        }
        // Sixth task method
        public static void SmarterThanFifthIntroduction(string name, int age)
        {
            if(age == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine($"My name is {name} and i am {age} years old");
            }
        }
        // Seventh task method
        public static void ALotOfNames(int age, params string[] names)
        {
            Console.Write("We are ");
            for(int i = 0; i < names.Length; i++)
            {
                if(i == names.Length - 1)
                {
                    Console.Write($"and {names[i]}");
                }
                else
                {
                    Console.Write($"{names[i]} ");
                }
            }
            Console.Write($". And we are {age} years old");
        }
        // Eighth task method
        public static string [] TwoArrayInOne(string[] names, string[] surnames)
        {
            int arrayLenghth = names.Length >= surnames.Length ? names.Length : surnames.Length;
            string[] fullName = new string[arrayLenghth];
            
            for(int i = 0; i < fullName.Length; i++)
            {
                fullName[i] = names[i] + " " + surnames[i];
            }
            foreach(string i in fullName)
            {
                Console.WriteLine(i);
            }
            return fullName;
        }
        // Ninth task methods
        public static bool CompareNumbers(int number)
        {
            Random random = new Random();
            int rnd = random.Next(1, 10);
            return number == rnd;
        }
        public static void Bet(string name, int bet)
        {
            if(bet > 10 || bet < 1)
            {
                Console.WriteLine("Your bet is out of the range");
            }
            else
            {
                int count = 1;
                for(; ; )
                {
                    if (CompareNumbers(bet) == true)
                    {
                        Console.WriteLine($"{name} guessed the result on try #{count}");
                        break;
                    }
                    else
                    {
                        count++;
                        continue;
                    }

                }
            }
        }
        // Tenth task methods
        public static int BetModified(string name, int bet)
        {
            int count = 1;
            if (bet > 10 || bet < 1)
            {
                Console.WriteLine("Your bet is out of the range");
            }
            else
            {
                count = 1;
                for (; ; )
                {
                    if (CompareNumbers(bet) == true)
                    {
                        Console.WriteLine($"{name} guessed the result on try #{count}");
                        return count;
                    }
                    else
                    {
                        count++;
                        continue;
                    }
                }
            }
            return count;
        }
        public static void Bettors(params string[] bettors)
        {
            int number = 0;
            string[] bettor = new string[3];
            int[] tries = new int[bettors.Length];
            foreach(string b in bettors)
            { 
                bettor = b.Split(" ");
                int trying = BetModified(bettor[0], Convert.ToInt32(bettor[2]));
                tries[number] = trying;
                number++;
            }
            number = tries[0];
            for(int i = 0; i < tries.Length; i++)
            {
                if (number > tries[i])
                {
                    int tmp = number;
                    number = tries[i];
                    tries[i] = number;
                }
            }
            int index = System.Array.LastIndexOf(tries, number);
            string[] winner = bettors[index].Split(" ");
            Console.WriteLine($"{winner[0]} wins with best result {number}");
        }
        // Eleventh rask method
        public static bool ShortVersionOfCompareNumbers(int number, Random rnd) => number == rnd.Next(0, 2);
        // Twelfth task method
        public static string DateTimeGreatings(double time)
        {
            string vvv = "";
            if(time >= 22.00 && time <= 23.59 || time >= 00.00 && time < 05.00)
            {
                vvv = "good night";
                return vvv;
            }
            else if(time >= 05.00 && time < 12.00)
            {
                return "good morning";
            }
            else if(time >= 12.00 && time < 18.00)
            {
                return "good afternoon";
            }
            else if(time >= 18.00 && time < 22.00)
            {
                return "goood evening";
            }
            return vvv;
        }
        // Thirteenth task method
        public static void GlueArrays(string[] text, int[] numbers)
        {
            if(text.Length != numbers.Length)
            {
                Console.WriteLine("number of string and int values is not equal");
            }
            else
            {
                for(int i = 0; i < text.Length; i++)
                {
                    Console.WriteLine($"{text[i]} = {numbers[i]}");
                }
            }
        }
    }
}
