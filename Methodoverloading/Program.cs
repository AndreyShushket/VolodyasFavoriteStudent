using System;
using System.Linq;

namespace Methodoverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] byteNumbers = new byte[] {1, 2, 3, 4};
            int[] intNumbers = new int[] {5, 6 , 7, 8};
            double[] doubleNumbers = new double[] {9123.9, 11241240.1, 1241.11};
            float[] floatNumbers = new float[] {12124.12f, 11243.13f, 13234.14f};

            Console.WriteLine(Min(byteNumbers));
            Console.WriteLine(Min(intNumbers));
            Console.WriteLine(Min(doubleNumbers));
            Console.WriteLine(Min(floatNumbers));
            Console.WriteLine(Max(byteNumbers));
            Console.WriteLine(Max(intNumbers));
            Console.WriteLine(Max(doubleNumbers));
            Console.WriteLine(Max(floatNumbers));

            int firstIntNumberToSum = 1;
            int secondIntNumberToSum = 2;
            byte firstByteNumberToSum = 3;
            byte secondByteNumberToSum = 4;
            double firstDoubleNumberToSum = 5.5;
            double secondDoubleNumberToSum = 6.6;
            float firstFloatNumberToSum = 7.7f;
            float secondFloatNumberToSum = 8.8f;

            Console.WriteLine(Sum(firstIntNumberToSum, secondIntNumberToSum));
            Console.WriteLine(Sum(firstByteNumberToSum, secondByteNumberToSum));
            Console.WriteLine(Sum(firstDoubleNumberToSum, secondDoubleNumberToSum));
            Console.WriteLine(Sum(firstFloatNumberToSum, secondFloatNumberToSum));
        }

        public static int Min(params int[] numbers) => numbers.Min();

        public static byte Min(params byte[] numbers) => numbers.Min();

        public static double Min(params double[] numbers) => numbers.Min();

        public static float Min(params float[] numbers) => numbers.Min();

        public static int Max(params int[] numbers) => numbers.Max();

        public static byte Max(params byte[] numbers) => numbers.Max();

        public static double Max(params double[] numbers) => numbers.Max();

        public static float Max(params float[] numbers) => numbers.Max();

        public static int Sum(int num1, int num2) => num1 + num2;

        public static byte Sum(byte num1, byte num2) => (byte)(num1 + num2);

        public static double Sum(double num1, double num2) => num1 + num2;

        public static float Sum(float num1, float num2) => num1 + num2;



    }
}
