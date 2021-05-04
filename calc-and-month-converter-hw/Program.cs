using System;

namespace calc_and_month_converter_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an application that takes two numbers from a user and based on their choice will add, subtract, multiply, or divide.
            //Ask the user to enter the first number
            //Store user’s input into a variable
            //Ask the user to enter the second number
            //Store user’s input into a variable
            //Console.WriteLine("Enter your first variable");
            //double var1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your second variable");
            //double var2 = double.Parse(Console.ReadLine());

            //Ask the user the following: "Would you like to (1)Add (2)Subtract (3)Multiply (4)Divide?"
            //Console.WriteLine("Would you like to (1)Add (2)Subtract (3)Multiply (4)Divide?  Example: 'Divide'");
            //string calcFunction = Console.ReadLine().ToLower();
            //switch (calcFunction)
            //{
            //    case "add":
            //  double addVars = var1 + var2;
            //        Console.WriteLine($"{addVars}");
            //        break;
            //    case "subtract":
            //        double subtractVars = var1 - var2;
            //        Console.WriteLine($"{subtractVars}");
            //        break;
            //    case "multiply":
            //        double multiplyVars = var1 * var2;
            //        Console.WriteLine($"{multiplyVars}");
            //        break;
            //    case "divide":
            //        double divideVars = var1 / var2;
            //        Console.WriteLine($"{divideVars}");
            //        break;
            //    default:
            //        Console.WriteLine("Please choose a valid option");
            //        break;

            //}
            //Store the user’s input in a variable
            //Create a switch statement that switches based on the users choice
            //The first case should print the sum of the first number and the second number
            //The second case should print the difference between the first number and the second number
            //The third case should print the product of the first number and the second number
            //The fourth case should print the quotient of the first number and the second number
            //The default case should print the message: “Please choose a valid option”



            //Month Converter
            //The following application will take in a number that corresponds with a month of the year and print that month to the Console.

            //Prompt the user for a number between 1 - 12
            //Store the number in a variable
            //Make sure the number is not less than 1 and not greater than 12
            //Once you have a valid number, the application should print out the month that corresponds to the number

            Console.WriteLine("Enter a number 1 - 12");
            int monthNum = int.Parse(Console.ReadLine());
            bool keepGoing = true;
            string userInput;
            while (keepGoing)
            {
                if (monthNum >= 1 && monthNum <= 12)
                    switch (monthNum)
                    {
                        case 1:
                            Console.WriteLine("January");
                            break;
                        case 2:
                            Console.WriteLine("February");
                            break;
                        case 3:
                            Console.WriteLine("March");
                            break;
                        case 4:
                            Console.WriteLine("April");
                            break;
                        case 5:
                            Console.WriteLine("May");
                            break;
                        case 6:
                            Console.WriteLine("June");
                            break;
                        case 7:
                            Console.WriteLine("July");
                            break;
                        case 8:
                            Console.WriteLine("August");
                            break;
                        case 9:
                            Console.WriteLine("September");
                            break;
                        case 10:
                            Console.WriteLine("October");
                            break;
                        case 11:
                            Console.WriteLine("November");
                            break;
                        case 12:
                            Console.WriteLine("December");
                            break;
                    }




                if (monthNum <= 1 || monthNum >= 12)
                {
                    Console.WriteLine("Enter a valid number");
                    Console.WriteLine("Enter a number 1 - 12");
                    monthNum = int.Parse(Console.ReadLine());

                }
                else
                {

                    Console.WriteLine("Press ENTER to Exit");
                    Console.ReadLine();
                    keepGoing = false;
                }
            }
        }
    }
}
