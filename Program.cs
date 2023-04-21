using System.Net.NetworkInformation;
using System.Transactions;

namespace Prog_120_S23_L6_Double_Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Sum all the numbers in an equation:
            ////Using mod and divide, add all the individual numbers of a number together
            ////Ex. 53285
            ////5 + 3 + 2 + 8 + 5 = 23
            //int number = 123; // 1 + 2 + 3 = 6
            //int sum = number + (number / 10);
            //Console.WriteLine(sum);



            //            Distance Formula: Get the difference between two points
            //Equation: d =√(x₁ – x₂)² +(y₁ – y₂)²
            // PEMDAS
            int x1 = 2;
            int x2 = 4;
            int y1 = 7;
            int y2 = 8;
            //Equation: d =√(5 – 5)² +(5 – 5)²
            int parn1 = x1 - x2; // 5 - 5
            int parn2 = y1 - y2; // 5 - 5
            double exp1 = parn1 * parn1; // (5 - 5 ) ^2
            double exp2 = parn2 * parn2;// (5 - 5 ) ^2
            double sqRoot = Math.Sqrt(exp1); // sqrt (5 - 5 ) ^2
            // Breaking apart equations
            double addResult = sqRoot + exp2;

            Console.WriteLine(addResult);

        } // main

        public static void MathLibExample()
        {
            // Math Library
            double doubleNum = 2.64234;
            Console.WriteLine(doubleNum);

            double roundedNumber = Math.Round(doubleNum);
            Console.WriteLine(roundedNumber);

            Console.WriteLine((int)doubleNum);
        }

        public static void TryCatch()
        {
            // A try / catch is meant to catch any errors thrown
            try
            {
                Console.Write("Please enter a number: "); // Ask for info
                string userInput = Console.ReadLine(); // Save info
                int userNum = int.Parse(userInput); // Try to convert into a number
                Console.WriteLine(userNum + userNum); // Add number to itself
            } // End of try
            catch
            {
                Console.WriteLine("Please Enter a Valid Number");
            }
            Console.WriteLine("This code ran");
        }

        public static void FullExample()
        {
            DeclaringVariables();
            ParsingVariables();
            CastingVariables();
        }
        // Declaring
        public static void DeclaringVariables()
        {
            // Whole Numbers
            // 7 a player number
            // Declare and initialize
            int playerNumber = 7;
            // Declare
            int playerNumber2 = 0;
            //Console.WriteLine(playerNumber2);
            // Use of unassigned local variable

            // Decimal Number : float, double, decimal
            // There was an earthquake magnatude of 7.9
            // User an f suffix for type of float
            float magnatuide = 7.9f;
            double distanceTraveled = 245.56;
            // use an M suffix for a variable of this type
            decimal dollerAmount = 12345.23m;
        } // DeclaringVariables

        // Casting
        public static void CastingVariables()
        {
            // Mixing WHole numbers and decimal
            // Casting
            // Any int will go into a double.
            // But you need to CAST a double to go into an int
            int a = 5;
            double b = 5.5;
            double result = a + b;

            // Casting ( tells the computer what a type should be )
            // Explict Casting 
            int wholeNumber = (int)10.5;
            Console.WriteLine(wholeNumber);
            // Implicit Casting - Implied ( we don't need to tell the computer )
            double doubleNumber = 123435464;

        } // CastingVariables

        // Parsing
        public static void ParsingVariables()
        {
            // int.Parse
            //string grade = "10";
            //int gradeNum = int.Parse(grade);

            // type.Parse(string) - How to convert a string to a number
            string height = "5.4";
            double heightNum = double.Parse(height);
            //Console.WriteLine(heightNum + heightNum);

        } // ParsingVariables

        public static void LectureNotes()
        {
            // Outputs - Fundamental
            // Console.WriteLine() - Displays and moves to the next line
            // Console.Write() - Which displays and keeps on the same line

            // Input - Fundamental
            // string variable = Console.ReadLine();

            // Variables - Fundamental
            // declare and initialize ( give it a type, a name, and a value )
            // Words : string, char
            // Whole Numbers: int, byte, long, sbyte
            // Floating Point ( Decimal ) : float, double, decimal

            // Operations
            // Math Operations : + - * / %
            // Assignment Operator : =

            // How to convert strings to numbers
            // int.Parse(), double.Parse() ( Converting a string to a number )
            // Casting : Converting from one similar type to another
            // Try / Parse
            // How to add strings together
            // Concatenation : string + string = one long string
            // String Literal : $"{variable name}"
            // Math Library
        } // LectureNotes


    } // class

} // namespace