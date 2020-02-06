using System;
using System.Threading.Tasks;
using DesignPattern.Factory;
using DesignPattern.Factory.FactoryMethod;
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
            Console.WriteLine($"_______________________________________________________________________" +
                              $"__________________________________________\n");
            new FactoryMethodTest().Test();

            Console.ReadKey();
        }

        
    }
}
