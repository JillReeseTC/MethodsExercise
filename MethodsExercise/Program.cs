using System.ComponentModel;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise  1
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite weather?");
            string weather = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("Name an animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band");
            string band = Console.ReadLine();
            Console.WriteLine("Name a tool you use?");
            string tool = Console.ReadLine();
            Console.WriteLine("What is your favorite car");
            string car = Console.ReadLine();
            Console.WriteLine("What is your favorite musical instrument?");
            string instrument = Console.ReadLine();
            Console.WriteLine("What is a good name for a pet?");
            string name2 = Console.ReadLine();

            Console.WriteLine($"One day, {name} looked out at the {color} clouds and said, \"{weather}\"!");
            Console.WriteLine($"Grabbing their {instrument} and whistling to summon their pet {animal}, {name2},");
            Console.WriteLine($"they hopped in their {car} to get to band practice. On the way, a tree had fallen");
            Console.WriteLine($"so they had to stop the {car} and use their {tool} to move the tree out of the way.\n");
            Console.WriteLine($"The pet {animal}, {name2}, was of no use in this, but simply laughed at them.\n\n\n");


            //Exercise 2
            Console.WriteLine($"Exercise 2");
            double number1 = AskNumber();
            double number2 = AskNumber();
            string operation = AskOperation();
            double answer = MathMethods(operation, number1, number2);
            Console.WriteLine($"Your answer is {operation} {number1} and {number2} equals {answer}");

            //Challenge Mode
            Console.WriteLine($"Challenge Mode\n");
            Console.WriteLine($"Enter number or numbers separated with commas, then hit Enter:");
            string input = Console.ReadLine();
            string[] split = input.Split(',');
            int totalCount = split.Count();
            double[]? num = new double[totalCount];

            int countArr = 0;
            foreach(string s in split) 
            {
               num[countArr] = 0.0;  //initialize the array value before loading it
               num[countArr] = double.Parse(s);  //load it with the input number
               countArr++;
            }
            operation = "";
            operation = AskOperation();
            double answer2 = ChallengeMathMethod(num, operation);
            Console.WriteLine($"The Challenge Math answer sum is {answer2}");

        }

        public static double ChallengeMathMethod(double[] num, string operation) 
        {
            double sum = 0;
             
            switch (operation)
            {
                case "add":
                    foreach (var number in num)
                    {
                        sum += number;
                    }
                    break;
                case "subtract":
                    foreach (var number in num)
                    {
                        sum -= number;
                    }
                    break;
                case "multiply":
                    foreach (var number in num)8,
                    {
                        sum = sum * number;
                    }
                    break;
                case "divide":
                    foreach (var number in num)
                    {
                        sum = sum / number;
                    }
                    break;
                default:
                    Console.WriteLine("You're in the default loop on ChallengeMathMethod");
                    break;
            }
            return sum;
        }
        public static double AskNumber() 
        {
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();
            double answer = double.Parse(number);
            return answer;
        }

        public static string AskOperation()
        {
            Console.WriteLine("Do you want to add the numbers? Y/N");
            string opThing = Console.ReadLine();
            if(opThing != null && opThing == "Y") 
            {
                return "add";
            }
            else 
            {
                Console.WriteLine("OK, do you want to subtract the numbers? Y/N");
                string opThing2 = Console.ReadLine();
                if (opThing2 != null && opThing2 == "Y")
                {
                    return "subtract";
                }
                else
                {
                    Console.WriteLine("OK, do you want to multiply the numbers? Y/N");
                    string opThing3 = Console.ReadLine();
                    if (opThing3 != null && opThing3 == "Y")
                    {
                        return "multiply";
                    }
                    else
                    {
                        Console.WriteLine("OK, do you want to divide the numbers? Y/N");
                        string opThing4 = Console.ReadLine();
                        if (opThing4 != null && opThing4 == "Y")
                        {
                            return "divide";
                        }
                        else
                        {
                            Console.WriteLine("You didn't make a choice! I think you want to add the numbers.");
                            return "add";
                        }
                    }
                }
            }
        }

        public static double MathMethods(string operation, double number1, double number2) 
        {
            if(operation == "add")
            {
                return number1 + number2;
            }
            else if(operation == "subtract")
            {
                return number1 - number2;
            }
            else if(operation == "multiply") 
            {
                return number1 * number2;
            }
            else if(operation == "divide")
            {
                return number1 / number2;
            }
            else
            {
                Console.WriteLine($"I don't understand that operation requested.");
                return 1;
            }
        }
    }
}
