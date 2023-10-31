using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolodinaAA.Sprint4.Task1.V5.Lib;

namespace Tyuiu.VolodinaAA.Sprint4.Task1.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт#4 |Выполнила: Володина А.А.|ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы(ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Володина Александра Александровна | ПКТб-23-1                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 5 до 9 подсчитать сумму четных   *");
            Console.WriteLine("* элементов массива. С клавиатуры: 9,6,6,9,7,8,5,9,6,6,8,6,8,6,7          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.WriteLine("ВВедите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];
            for (int i = 0; i <= len-1;i++)
            {
                Console.WriteLine($"Введите значение {i}-го элемента массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(numsArray[i]+ "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(numsArray);
            Console.WriteLine($"Сумма четных элементов массива равна {res}");
            Console.ReadKey();
        }
    }
}
