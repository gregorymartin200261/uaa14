using System;
using System.Collections.Generic;
using System.Text;

namespace ex_rev_rentrée_2022
{
    public struct methode
    {
        public double Lecture(string question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(question);
            Console.ForegroundColor = ConsoleColor.White;
            string RepUser = Console.ReadLine();

            double x;

            while (!double.TryParse(RepUser ,out x)) 
	        {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Merci de rentrer des chiffres.");
                Console.ForegroundColor = ConsoleColor.White;
                RepUser = Console.ReadLine();
            }

            return x;
        }

        public double Compil(double[] UserEnter)
        {
            double Clac = 0;
            for (int i = 0; i < 10; i++)
            {
                Clac = Clac + UserEnter[i];
            }
            double Rep = Clac / 10;
            return Rep;
        }
    }
}
