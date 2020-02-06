using System;

namespace DesignPattern.Singleton
{
    public sealed class SingletonImplementation
    {
        private static readonly Lazy<SingletonImplementation> Instance = new Lazy<SingletonImplementation>(()=>new SingletonImplementation());
        private readonly int _counter = 0;
        public static SingletonImplementation GetSingleton => Instance.Value;

        private SingletonImplementation()
        {
            _counter++;
            Console.WriteLine($"Created Instance: {_counter}");
        }

        public void ExpressThis(string expression)
        {
            Console.WriteLine($"Expressed from {expression} by Instance {_counter}");
        }
    }
}