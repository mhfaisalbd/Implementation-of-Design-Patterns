using System;
using System.Threading.Tasks;
using DesignPattern.Singleton;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(FirstExpression, SecondExpression);
            Console.ReadKey();
        }

        static void FirstExpression()
        {
            SingletonImplementation singleton = SingletonImplementation.GetSingleton;
            singleton.ExpressThis("First");
        }
        static void SecondExpression()
        {
            SingletonImplementation singleton = SingletonImplementation.GetSingleton;
            singleton.ExpressThis("Second");
        }
    }
}
