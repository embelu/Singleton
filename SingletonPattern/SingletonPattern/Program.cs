using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {   // https://dotnettutorials.net/lesson/singleton-design-pattern/
            //
            // Ne pas utiliser en multi-threaded 
            //

            Singleton developper = Singleton.GetInstance;
            developper.PrintDetails("From developper");

            Singleton analyst = Singleton.GetInstance;
            analyst.PrintDetails("From analyst");

            Singleton tester = Singleton.GetInstance;
            tester.PrintDetails("From tester");


            Console.ReadKey();
        }
    }
}
