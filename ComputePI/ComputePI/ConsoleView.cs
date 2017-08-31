using System;

namespace ComputePI
{
    class ConsoleView : IView
    {
        public string GetString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public void Show<T>(T message)
        {
            Console.WriteLine(message);
        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("The Programming Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Press any key to exist the program");
            Console.ReadKey();
        }
    }
}
