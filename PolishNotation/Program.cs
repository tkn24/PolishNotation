using System;
using System.Collections;

namespace PolishNotation
{
    class Program
    {

        public static int Operand(string op)
        {
            switch (op)
            {
                case "+": 
                    return 0;
                case "-": 
                    return 1;
                case "*":
                    return 2;
                case "/":
                    return 3;
                default:
                    return -1;
            }
        }

        public static int calculate(string operatör, int value1, int value2)
        {                             
            switch (Operand(operatör))
            {
                case 0: return value1 + value2; 

                case 1: return value1 - value2; 

                case 2: return value1 * value2; 

                case 3: return value1 / value2; 
                default:
                    return -1;
            }

        }

        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            Console.Write("Enter the expression (with a blank space) :");

            var entered = Console.ReadLine().Split(' ');

            for (int k = entered.Length - 1; k >= 0; k--)
            {

                if (entered[k] == ("+") || entered[k] == ("-") || entered[k] == ("*") || entered[k] == ("/"))
                {
                    
                    stack.Push(calculate(entered[k], int.Parse((string)stack.Pop()), int.Parse((string)stack.Pop())).ToString());
                }
                else
                {
                    stack.Push(entered[k]);
                }
            }

            Console.WriteLine("Result : " + stack.Pop());
            Console.ReadKey();

        }
    }
}
