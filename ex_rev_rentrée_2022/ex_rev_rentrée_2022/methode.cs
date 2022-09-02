using System;
using System.Collections.Generic;
using System.Text;

namespace ex_rev_rentrée_2022
{
    public struct methode
    {
        static double lecture(string question)
        {
            Console.WriteLine(question);
            string RepUser = Console.ReadLine();

            double x;

            while (!double.TryParse(RepUser ,out x)) 
	        {
                Console.WriteLine("Merci de rentrer des chiffres.");
                RepUser = Console.ReadLine();
            }

            return x;
        }
    }
}
