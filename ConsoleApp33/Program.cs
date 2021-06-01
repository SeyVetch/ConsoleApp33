using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/// <summary>
/// 1ИСП11-17 Маханов А.А.
/// </summary>

namespace ConsoleApp33
{
    class Program
    {
        static public void primer1()
        {
            Console.WriteLine("Диапозон значений  базовых типов \n\n" +
                              "Тип sbyte   :({0}) до ({1})\n" +
                              "Тип byte    :({2}) до ({3})\n" +
                              "Тип short   :({4:0,0}) до ({5:0,0})\n" +
                              "Тип ushort  :({6: мин значение 0,0}) до ({7: макс значение ,0,0})\n" +
                              "Тип int     :({8: 0,0}) до ({9: макс значение ,0,0})\n" +
                              "Тип unit    :({10}) до ({11})\n" +
                              "Тип long    :({12}) до ({13})\n" +
                              "Тип ulong   :({14}) до ({15})\n" +
                              "Тип float   :({16}) до ({17})\n" +
                              "Тип double  :({18}) до ({19})\n" +
                              "Тип decimal :({20}) до ({21})\n",
                              sbyte.MinValue, SByte.MaxValue, byte.MinValue, byte.MaxValue,
                              short.MinValue, Int16.MaxValue, ushort.MinValue, UInt16.MaxValue,
                              int.MinValue, Int32.MaxValue, uint.MinValue, UInt32.MaxValue,
                              long.MinValue, Int64.MaxValue, ulong.MinValue, UInt64.MaxValue,
                              float.MinValue, Single.MaxValue, double.MinValue, Double.MaxValue,
                              decimal.MinValue, Decimal.MaxValue);
            Console.ReadKey();
        }
        static public void primer2()
        {
            MessageBox.Show(String.Format("Тип sbyte   :({0}) до ({1})\n" +
                              "Тип byte    :({2}) до ({3})\n" +
                              "Тип short   :({4}) до ({5})\n" +
                              "Тип ushort  :({6}) до ({7})\n" +
                              "Тип int     :({8}) до ({9})\n" +
                              "Тип unit    :({10}) до ({11})\n" +
                              "Тип long    :({12}) до ({13})\n" +
                              "Тип ulong   :({14}) до ({15})\n" +
                              "Тип float   :({16}) до ({17})\n" +
                              "Тип double  :({18}) до ({19})\n" +
                              "Тип decimal :({20}) до ({21})\n",
                              sbyte.MinValue, SByte.MaxValue, byte.MinValue, byte.MaxValue,
                              short.MinValue, Int16.MaxValue, ushort.MinValue, UInt16.MaxValue,
                              int.MinValue, Int32.MaxValue, uint.MinValue, UInt32.MaxValue,
                              long.MinValue, Int64.MaxValue, ulong.MinValue, UInt64.MaxValue,
                              float.MinValue, Single.MaxValue, double.MinValue, Double.MaxValue,
                              decimal.MinValue, Decimal.MaxValue),"Диапозон базовых типов",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        static public void primer3()
        {
            int number, reminder;
            number = Int32.Parse(Interaction.InputBox("Введите целое число", "Проверка"));
            reminder = number % 2;
            string txt = "Вы ввели ";
            txt += (reminder == 0 ? "четное" : "нечетное") + " число!" + number;
            MessageBox.Show(txt);
        }
        static public void primer4()
        {
            int numbers, hundreds;
            numbers = Int32.Parse(Interaction.InputBox("Введите целое число:", "Количество сотен"));
            hundreds = numbers / 100 % 10;
            string txt = "В этом числе " + hundreds + " сотен!";
            MessageBox.Show(txt, "Сотни");
        }
        static public void prog1()
        {
            //программа 1
            string num = Interaction.InputBox("Какой пример listing?", "Пример");
            //выбор примера 1-4
            switch (num)
            {
                case "1":
                    primer1();
                    break;
                case "2":
                    primer2();
                    break;
                case "3":
                    primer3();
                    break;
                case "4":
                    primer4();
                    break;
                default:
                    MessageBox.Show("Неверный номер");
                    break;
            }
        }
        static public void prog2()
        {
            //программа 2
            Console.WriteLine("Напишите число");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine((x % 3 == 0 ? "Делится на 3" : "Не делится на 3"));
        }
        static public void prog3()
        {
            //программа 3
            Console.WriteLine("Напишите число");
            int x = Int32.Parse(Console.ReadLine());
            bool flag = x % 5 == 2 && x % 7 == 1;
            Console.WriteLine((flag ? "Удовлетворяет условиям" : "Не удовлетворяет условиям"));
        }
        static public void prog4()
        {
            //программа 4
            Console.WriteLine("Напишите число");
            int x = Int32.Parse(Console.ReadLine());
            bool flag = x % 4 == 0 && x < 10;
            Console.WriteLine((flag ? "Удовлетворяет условиям" : "Не удовлетворяет условиям"));
        }
        static public void prog5()
        {
            //программа 5
            Console.WriteLine("Напишите число");
            int x = Int32.Parse(Console.ReadLine());
            bool flag = 5 <= x && x <= 10;
            Console.WriteLine((flag ? "Удовлетворяет условиям" : "Не удовлетворяет условиям"));
        }
        static public void prog6()
        {
            //программа 6
            Console.WriteLine("Напишите число");
            int x = Int32.Parse(Console.ReadLine())/1000;
            Console.WriteLine(x);
        }
        static public void prog7()
        {
            //программа 7
            Console.WriteLine("Напишите число");
            int x = Int32.Parse(Console.ReadLine()) / 10;
            int y = (x / 8) * 10 + x % 8;
            Console.WriteLine(y);
            //Convert.ToString(value, 2)
        }
        static public void prog8()
        {
            //программа 8
            Console.WriteLine("Напишите число");
            int x = Int32.Parse(Console.ReadLine());
            int y = Convert.ToInt32(Convert.ToString(x, 2)) / 100;
            Console.WriteLine(y);
        }
        static public void prog9()
        {
            //программа 9
            Console.WriteLine("Напишите число в двоичном виде");
            int x = Int32.Parse(Console.ReadLine());
            int y = x;
            y = (y / 1000) * 1000 + 100 + y % 100;
            Console.WriteLine(y);
        }
        static public void prog10()
        {
            //программа 10
            Console.WriteLine("Напишите число в двоичном виде");
            int x = Int32.Parse(Console.ReadLine());
            int y = x;
            y = (y / 10000) * 10000 + y % 1000;
            Console.WriteLine(y);
        }
        static public void prog11()
        {
            //программа 11
            Console.WriteLine("Напишите число в двоичном виде");
            string a = Console.ReadLine();
            int x = a.Length - 1;
            x = Convert.ToInt32(Math.Pow(10, x));
            int y = Int32.Parse(a);
            int z = 1 - Convert.ToInt32(y % x) / (x / 10);
            y = (y / x) * x + x / 10 + y % (x / 10);
            Console.WriteLine(y);
        }
        static void Main(string[] args)
        {
            string num = Interaction.InputBox("Какую программу открыть?", "Программа");
            //выбор программы 1-11
            switch (num)
            {
                case "1":
                    prog1();
                    break;
                case "2":
                    prog2();
                    break;
                case "3":
                    prog3();
                    break;
                case "4":
                    prog4();
                    break;
                case "5":
                    prog5();
                    break;
                case "6":
                    prog6();
                    break;
                case "7":
                    prog7();
                    break;
                case "8":
                    prog8();
                    break;
                case "9":
                    prog9();
                    break;
                case "10":
                    prog10();
                    break;
                case "11":
                    prog11();
                    break;
                default:
                    MessageBox.Show("Неверный номер");
                    break;
            }
            Console.ReadLine();
        }
    }
}