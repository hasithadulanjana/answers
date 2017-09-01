using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class ConsoleView : IView
    {
        public string GetString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public void Message<T>(T message)
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
            Console.WriteLine("Press any key to stop the program");
            Console.ReadKey();
        }
    }
}
