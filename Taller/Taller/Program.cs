﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            int x = sumar(4, 3);
            System.Console.WriteLine(x);
        }

        static int sumar(int a, int b)
        {
            System.Console.WriteLine("Arian!");
            return a + b;
        }
    }
}
