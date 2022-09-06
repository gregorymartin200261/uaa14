using System;

namespace ex_rev_rentrée_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string Question= "Rentrer vos chiffres.";
            methode Utils = new methode();
            double[] UserEnter = new double[10];
            for (int i = 0; i < 10; i++)
            {
                UserEnter[i] = Utils.Lecture(Question);
            }
            double Moyenne = Utils.Compil(UserEnter);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Moyenne:"+Moyenne);
            Console.ReadLine();
        }
    }
}
