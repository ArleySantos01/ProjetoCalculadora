using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
        	double Num1, Num2;
            double resultado = 0;
    		Console.WriteLine("---- Calculadora ----");            
	    	Console.WriteLine("Numero 1: ");
		    // double Salary = Convert.ToDouble(Console.ReadLine());
		    Num1 = Convert.ToDouble(Console.ReadLine());
		    Console.WriteLine("Numero 2: ");
		    Num2 = Convert.ToDouble(Console.ReadLine());
		    Console.WriteLine("Selecione uma operação: +, -, *, /");
            string op = Console.ReadLine();

            switch(op)
            {
                case "+":
                    resultado = Num1 + Num2;
                    break;
                case "-":
                    resultado = Num1 - Num2;
                    break;
                case "*":
                    resultado = Num1 * Num2;
                    break;
                case "/":
                    resultado = Num1 / Num2;
                    break;
                default:
                    Console.WriteLine("Insira um operador válido.");
                    break;
            }
            Console.WriteLine("" + Num1 + " " + op + "  " + Num2 + " = " + resultado);
        }
    }
}
