using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_21
{
    class Program
    {
        static void Main(string[] args)
        {
            char couleur;
            do
            {
                // Saisir une couleur
                Console.Write("Saisir une couleur (V/O/R) = ");
                couleur = Console.ReadKey().KeyChar;
                Console.ReadLine();
            } while (couleur != 'O' && couleur != 'R' && couleur != 'V');

            // Différents ordre à exécuter
            switch (couleur)
            {
                    case 'V':
                        Console.WriteLine("Passer");
                        break;
                    case 'O':
                        Console.WriteLine("Ralentir");
                        break;
                    case 'R':
                        Console.WriteLine("S'arrêter");
                        break;

            } Console.ReadLine();
            




        } 
        
            
            
    }
}
