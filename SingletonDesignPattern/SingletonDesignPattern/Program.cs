using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class AppCounter
    {
        // Lazy<T> creates the AppCounter only when .Value is accessed.
        private static readonly Lazy<AppCounter> _instance = new Lazy<AppCounter>(() => new AppCounter());

        // Private constructor prevents:
        // new AppCounter()
        private AppCounter()
        {
            Console.WriteLine("AppCounter object created.");
        }

        // Global access to the single instance
        public static AppCounter Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public int Count { get; private set; }

        public void Increment()
        {
            Count++;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Application Started");

            // First request - Singleton object is created here
            AppCounter counter1 = AppCounter.Instance;

            counter1.Increment();

            Console.WriteLine($"Counter 1: {counter1.Count}");

            // Second request - existing object is returned
            AppCounter counter2 = AppCounter.Instance;

            counter2.Increment();

            Console.WriteLine($"Counter 1: {counter1.Count}");
            Console.WriteLine($"Counter 2: {counter2.Count}");

            // Verify both variables point to same object
            bool sameObject = ReferenceEquals(counter1, counter2);

            Console.WriteLine($"Same Object: {sameObject}");
        }
    }
}
