using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose language / Выберите язык\n1 - English\n2 - Русский");
            string language = Console.ReadLine();
            if (language == "1")
                Console.WriteLine("Welcome to Calculator!\nCurrent version: 1.0\nDeveloped by Infinity Entertainment 2024\n\nPress any key to continue...");
            else if (language == "2")
                Console.WriteLine("Добро пожаловать в калькулятор!\nТекущая версия: 1.0\nРазработано Infinity Entertainment 2024\n\nНажмите любую клавишу для продолжения...");
            else
            {
                Console.WriteLine("Unknown language / Неизвестный язык\nPress any key to restart. / Нажмите любую клавишу для рестарта.");
                Console.ReadLine();
                Console.Clear();
                Main(args);
            }

            Console.ReadKey();
            Console.Clear();
            Calculator(args);

            void Calculator(string[] ident) // Calculator function
            {
                if (language == "1")
                    Console.WriteLine("Please, pick action: ");
                else if (language == "2")
                    Console.WriteLine("Пожалуйста, выберите действие: ");
                Console.WriteLine("+ \n-\n*\n/\n%");
                string action = Console.ReadLine();
                // This operator is called to check action
                if (action != "+" && action != "-" && action != "*" && action != "/" && action != "%")
                {
                    if (language == "1")
                        Console.WriteLine("Undefined action\nPress any key to restart.");
                    else if (language == "2")
                        Console.WriteLine("Неизвестное действие\nНажмите любую клавишу для рестарта.");
                    Console.ReadLine();
                    Console.Clear();
                    Calculator(ident);
                }
                if (language == "1")
                    Console.Write("Enter 1-st number: ");
                else if (language == "2")
                    Console.Write("Напишите 1-е число: ");
                string x = Console.ReadLine();
                if (language == "1")
                    Console.Write("Enter 2-nd number: ");
                else if (language == "2")
                    Console.Write("Напишите 2-е число: "); ;
                string y = Console.ReadLine();
                int result;
                void EndText(string[] endtext) // This function is called at the end of the action.
                {
                    if (language == "1")
                        Console.WriteLine($"Result: {result}\nPress any key");
                    else if (language == "2")
                        Console.WriteLine($"Результат: {result}\nНажмите любую клавишу."); ;    
                    Console.ReadKey();
                    Console.Clear();
                    if (language == "1")
                        Console.WriteLine($"Last action: {x} {action} {y} = {result}");
                    else if (language == "2")
                        Console.WriteLine($"Последнее действие: {x} {action} {y} = {result}");
                    Calculator(ident);
                }
                if (action == "+")
                {
                    result = Convert.ToInt32(x) + Convert.ToInt32(y);
                    EndText(args);
                }
                else if (action == "-")
                {
                    result = Convert.ToInt32(x) - Convert.ToInt32(y);
                    EndText(args);

                }
                else if (action == "*")
                {
                    result = Convert.ToInt32(x) * Convert.ToInt32(y);
                    EndText(args);
                }
                else if (action == "/")
                {
                    result = Convert.ToInt32(x) / Convert.ToInt32(y);
                    EndText(args);
                }
                else if (action == "%")
                {
                    result = Convert.ToInt32(x) % Convert.ToInt32(y);
                    EndText(args);
                }
            }
        }
    }
}
