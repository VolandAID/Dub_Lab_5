﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dub_Lab_5
{
    static class Program
    {
        // Задание на лабораторную работу №5
        //Разработать программу, реализующую вычисление расстояния Левенштейна с использованием алгоритма Вагнера-Фишера.
        // 1.     Программа должна быть разработана в виде библиотеки классов на языке C# .
        // 2.     Использовать самый простой вариант алгоритма без оптимизации.
        // 3.     Дополнительно возможно реализовать вычисление расстояния Дамерау-Левенштейна(с учетом перестановок соседних символов).
        // 4.     Модифицировать предыдущую лабораторную работу, вместо поиска подстроки используется вычисление расстояния Левенштейна.
        // 5.     Предусмотреть отдельное поле ввода для максимального расстояния.Если расстояние Левенштейна между двумя строками больше максимального, то строки считаются несовпадающими и не выводятся в список результатов.

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Лабораторная работа №5");
            Console.Title = "Дубянский А. И., ИУ5Ц-51Б";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
