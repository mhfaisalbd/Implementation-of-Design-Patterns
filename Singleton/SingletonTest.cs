using System;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class SingletonTest
    {
        void FirstExpression()
        {
            SingletonImplementation singleton = SingletonImplementation.GetSingleton;
            singleton.ExpressThis("First");
        }
        void SecondExpression()
        {
            SingletonImplementation singleton = SingletonImplementation.GetSingleton;
            singleton.ExpressThis("Second");
        }
        void ThirdExpression()
        {
            SingletonImplementation singleton = SingletonImplementation.GetSingleton;
            singleton.ExpressThis("Third");
        }

        public void Test()
        {

            Console.WriteLine($"Singleton --All parallel methods are invoked from single instance\n______________________________________________________________________");
            Parallel.Invoke(FirstExpression, SecondExpression,ThirdExpression);
        }
    }
}