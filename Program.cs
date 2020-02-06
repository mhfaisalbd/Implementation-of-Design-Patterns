using System;
using System.Threading.Tasks;
using DesignPattern.Factory;
using DesignPattern.Singleton;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"______________________________________________________________________\n"); 
            new SingletonTest().Test();
            Console.WriteLine($"______________________________________________________________________\n");
            new FactoryTest().Test();

            Console.ReadKey();
        }

        
    }
}
