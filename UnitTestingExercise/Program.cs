using System;
//using System.xUnit;

namespace UnitTestingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var unitTest = new UnitTestMethods();
            int sum = unitTest.Add(1, 2, 3);
            Console.WriteLine($"Addition result: {sum}");

            var substract = unitTest.Substract(20, 10);
            Console.WriteLine($"Substraction result: {substract}");

        }
    }
}
