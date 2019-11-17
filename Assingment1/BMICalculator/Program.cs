using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n C# program to calculate BMI \n");

            //Taking input from user

            Console.WriteLine("Enter your height in metres");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n Enter your weight in kilogram");
            double weight = Convert.ToDouble(Console.ReadLine());

            //Calculating BMI

            double bmi = weight / (height * height);

            Console.WriteLine(" \n Your BMI is: " + bmi);

        }
    }
}
