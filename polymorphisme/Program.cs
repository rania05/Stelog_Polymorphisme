using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace polymorphisme
{
    internal class Program
    {
        static void Main()
        {
           
            while (true)
            {
                Console.WriteLine("Choisissez une forme :");
                Console.WriteLine("1. Triangle");
                Console.WriteLine("2. Cercle");
                Console.WriteLine("3. Rectangle");
                Console.WriteLine("4. Quitter");
                Console.Write("Votre choix est : ");

                string choix = Console.ReadLine();

                if (choix == "1")
                {
                    Console.Write("Entrez la base du triangle : ");
                    double baseTriangle = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Entrez la hauteur du triangle : ");
                    double hauteur = Convert.ToDouble(Console.ReadLine());

                    Triangle triangle = new Triangle(baseTriangle, hauteur);
                    AfficherSurface(triangle);
                }
                else if (choix == "2")
                {
                    Console.Write("Entrez le rayon du cercle : ");
                    double rayon = Convert.ToDouble(Console.ReadLine());

                    Cercle cercle = new Cercle(rayon);
                    AfficherSurface(cercle);
                }
                else if (choix == "3")
                {
                    Console.Write("Entrez la longueur du rectangle : ");
                    double longueur = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Entrez la largeur du rectangle : ");
                    double largeur = Convert.ToDouble(Console.ReadLine());

                    Rectangle rectangle = new Rectangle(longueur, largeur);
                    AfficherSurface(rectangle);
                }
                else if (choix == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Choix invalide. Veuillez sélectionner une option valide.");
                }
            }
        }

        static void AfficherSurface(Forme forme)
        {
            double surface = forme.CalculSurface();
            Console.WriteLine("La surface de "+forme+" est : " + surface);
        }
    }
}
