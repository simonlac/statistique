using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Statiques
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Classe_Statique.PI);
            Console.WriteLine(Classe_Statique.somme(4, 8).ToString());
            // Erreur : On ne peut pas instancier un objet d'une classe statique
            //Classe_Statique cs1 = new Classe_Statique(); 
            Console.ReadKey();
        }
    }
}
