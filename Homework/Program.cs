using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.1
            double money;
            Console.WriteLine("Преобразование числа в денежный формат:");
            Console.Write("Введите число(грн.) -> ");
            money = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"{money} это {(int)money} грн, {(money - (int)money) * 100} коп");
            //1.2
            Console.WriteLine("Вычисление стоймости покупки.");
            Console.WriteLine("Введите исходные данные: ");
            Console.Write("Цена тетради (грн.) -> "); double workbook = Convert.ToInt64(Console.ReadLine());
            Console.Write("Количество тетрадей -> "); int Col = Convert.ToInt32(Console.ReadLine());
            Console.Write("Цена карандаша (грн.) -> "); double pencil = Convert.ToInt64(Console.ReadLine());
            Console.Write("Количество карандашей -> "); int Col2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Стоимость покупки: {(workbook * Col) + (pencil * Col2)}");
            //1.3
            Console.WriteLine("Вычисление стоймости покупки.");
            Console.WriteLine("Введите исходные данные: ");
            Console.Write("Цена тетради (грн.) -> "); double workbook2 = Convert.ToInt64(Console.ReadLine());
            Console.Write("Цена обложки (грн.) -> "); double obl = Convert.ToInt64(Console.ReadLine());
            Console.Write("Количество комплектов (шт.) -> "); int kol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Стоимость покупки: {(workbook2 + obl) * kol}");
            //1.4
            Console.WriteLine("Вычисление поездки на дачу и обратно.");
            Console.Write("Растояние до дачи(км.) -> "); double km = Convert.ToInt64(Console.ReadLine());
            Console.Write("Расход бензина (л. на 100 км пробега) -> "); double lit = Convert.ToInt64(Console.ReadLine());
            Console.Write("Цена бензина за л.(грн.): "); double price = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Поездка на дачу обойдется в {lit / 100 * km * price} грн.");

            //2
            Console.WriteLine("Введите действие:");
            do
            {
                char key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case 'W':
                    case 'w':
                        Console.WriteLine(" вперед");
                        break;
                    case 'S':
                    case 's':
                        Console.WriteLine(" назад");
                        break;
                    case 'A':
                    case 'a':
                        Console.WriteLine(" влево");
                        break;
                    case 'D':
                    case 'd':
                        Console.WriteLine(" вправо");
                        break;
                    case (char)40:
                        Console.WriteLine("Стрелка вверх");
                        break;
                    case (char)39:
                        Console.WriteLine("Стрелка вправо");
                        break;
                    case (char)38:
                        Console.WriteLine("Стрелка вверх");
                        break;
                    case (char)37:
                        Console.WriteLine("Стрелка влево");
                        break;
                    case (char)13:
                        Console.WriteLine(" enter - огонь");
                        break;
                    case ' ':
                        Console.WriteLine("space - прыжок");
                        break;
                    case (char)27:
                        return;
                    default:
                        Console.WriteLine("Вы ввели неверный знак");
                        break;
                }
            } while (true);
        }
    }
}

