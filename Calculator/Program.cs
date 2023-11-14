using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите выражение: ");
            string expression = "22+33*4-5/2+3";
            Console.WriteLine(Calculate(expression));
        }
        /*private static Explorer(string expression)
        {
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    for (int j = 1; j < expression.Length; j++)
                    {
                        if (expression[j] == ')')
                        {
                            string
                        }
                    }
                }
            }
        }*/
        //СДЕЛАЛ В Calculat НАХОЖДЕНИЕ СКОБОК
        private static double Calculate(string expression)
        {
            expression = expression.Replace(".", ",");
            Console.WriteLine(expression);
            String[] brackets = expression.Split('(', ')');
            String[] numbers = expression.Split('+', '-', '*', '/');
            String[] operations = expression.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9');
            operations = operations.Where(val => val != "").ToArray();
            double[] values = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                values[i] = Convert.ToDouble(numbers[i]);
            }
            foreach (double i in values) Console.Write(i + "\t"); Console.WriteLine();
            foreach (String i in operations) Console.Write(i + "\t"); Console.WriteLine();
            do
            {
                for (int i = 0; i < operations.Length; i++)
                {
                    if (brackets[i] == "(" && brackets[i] == ")") values[i] *= values[i + 1];
                    {
                        for (int j = 0; j < operations.Length; j++)
                        {
                            if (operations[j] == "*") values[j] *= values[j + 1];
                            if (operations[j] == "/") values[j] /= values[j + 1];
                            if (operations[j] == "*" || operations[j] == "/")
                            {
                                for (int f = j + 1; f < operations.Length; f++)
                                {
                                    values[f] = values[f + 1];
                                    operations[f - 1] = operations[f];

                                }
                                values[values.Length - 1] = 0;
                                operations[operations.Length - 1] = null;
                                j--;
                            }
                        }
                        for (int z = 0; z < operations.Length; z++)
                        {
                            if (operations[z] == "+") values[z] += values[z + 1];
                            if (operations[z] == "-") values[z] -= values[z + 1];
                            if (operations[z] == "+" || operations[z] == "-")
                            {
                                for (int j = z + 1; j < operations.Length; j++)
                                {
                                    values[j] = values[j + 1];
                                    operations[j - 1] = operations[j];

                                }
                                values[values.Length - 1] = 0;
                                operations[operations.Length - 1] = null;
                                z--;
                            }

                        }
                    }
                }
                } while ((brackets.Contains("*") || brackets.Contains("/"))) ;
                do
                {
                    for (int i = 0; i < operations.Length; i++)
                    {
                        if (operations[i] == "*") values[i] *= values[i + 1];
                        if (operations[i] == "/") values[i] /= values[i + 1];
                        if (operations[i] == "*" || operations[i] == "/")
                        {
                            for (int j = i + 1; j < operations.Length; j++)
                            {
                                values[j] = values[j + 1];
                                operations[j - 1] = operations[j];

                            }
                            values[values.Length - 1] = 0;
                            operations[operations.Length - 1] = null;
                            i--;
                        }
                    }
                } while (operations.Contains("*") || operations.Contains("/"));
                Console.WriteLine("*DONE");
                do
                {
                    for (int i = 0; i < operations.Length; i++)
                    {
                        if (operations[i] == "+") values[i] += values[i + 1];
                        if (operations[i] == "-") values[i] -= values[i + 1];
                        if (operations[i] == "+" || operations[i] == "-")
                        {
                            for (int j = i + 1; j < operations.Length; j++)
                            {
                                values[j] = values[j + 1];
                                operations[j - 1] = operations[j];

                            }
                            values[values.Length - 1] = 0;
                            operations[operations.Length - 1] = null;
                            i--;
                        }
                    }
                } while (operations.Contains("+") || operations.Contains("-"));
                foreach (double i in values) Console.Write(i + "\t"); Console.WriteLine();
                foreach (String i in operations) Console.Write(i + "\t"); Console.WriteLine();
                return values[0];
            }
    }
    }


