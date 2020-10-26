using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    // sealed : permet que la classe ne puisse pas être héritée
    public sealed class Singleton
    {
        private static int counter = 0;

        private static Singleton instance = null;

        // est utilisée pour renvoyer une seule instance de la classe en vérifiant la valeur de l'instance de variable privée
        public static Singleton GetInstance
        {
            get
            {
                // Si l'instance n'a pas été créée, on la créée sinon, on retourne l'instance créée
                if (instance == null) instance = new Singleton();
                return instance;
            }
        }

        // La classe est créée avec un constructeur privé qui garantira que la 
        // classe ne sera pas instanciée depuis l'extérieur de la classe
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }










    }
}
