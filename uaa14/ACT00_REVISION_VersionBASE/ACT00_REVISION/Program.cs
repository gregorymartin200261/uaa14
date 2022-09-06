using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE

            string rep="";
            string name="";
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;
            MethodesDuProjet Utils = new MethodesDuProjet();

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                c1 = lireDouble(1);
                c2 = lireDouble(2);
                c3 = lireDouble(3);

                Utils.OrdonneCotes(c1, c2, c3);
                if (Utils.Triangle(c1, c2, c3))
                {
                    ok = true;
                    // vérification équilatéral
                    if( Utils.Equi(c1, c2, c3))
                    {
                        name = "equilateral";
                        Utils.Affiche(ok, name);
                    }
                    else
                    {
                        // vérification triangle rectangle
                        if(Utils.TriangleRectangle(c1, c2, c3))
                        {
                            name = "rectangle";
                            Utils.Affiche(ok, name);

                        }
                        else
                        {
                            name = "rectangle";
                            ok = false;
                            Utils.Affiche(ok, name);
                        }
                        if (Utils.Isocele(c1, c2, c3))
                        {
                            name = "isocele";
                            Utils.Affiche(ok, name);
                        }
                    }
                }
                else // si ce n'est pas un triangle
                {
                    Utils.Affiche(ok, name);
                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    // ...
                    // ...
                }
                // reprise ?
                Utils.Affiche(ok,name);
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }
    }
}
