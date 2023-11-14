//#define CLASS_CONSOLE
//#define STRING_OPERATIONS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrodictionTo.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if CLASS_CONSOLE
                        /*/*Console.Title = "Intoduction to Net";
                        Console.WriteLine("\t\t\tПривет");
                        Console.CursorLeft = 32;
                        Console.CursorTop = 8;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Cursor Position");
                        Console.ResetColor();*/*/
#endif
#if STRING_OPERATIONS
           /* Console.Write("Your name: ");
            string first_name = Console.ReadLine();
            Console.Write("Your surname: ");
            string last_name = Console.ReadLine();
            Console.Write("Your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(last_name + " " + first_name + " " + age + "y/o");//конкатенация
            Console.WriteLine(String.Format("{0} {1} {2} y/o", last_name,first_name,age));
            Console.WriteLine($"{last_name} {first_name} {age} y/o");
            Console.Write("Your name: ");*/
#endif
        }

    }
}
