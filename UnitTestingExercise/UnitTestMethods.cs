﻿using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        
        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        public int Substract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Divide(int x, int y )
        {
            return x / y ;
        }

        public string YourMethodName()
        {
            return "Test has started";
        }

        public string YourMethodName2()
        {
            return "Test has been completed";

        }
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference


        // Create an Add method that passes 3 integers
        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend

        // Create a Multiply method that passes 2 integers

        // Create a Divide method that passes 2 integers



        // Create 2 methods that will utilize the [Fact] tests you wrote


    }
}
