using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ConsoleView : IView
    {
        public string Get()
        {
            return Console.ReadLine();
        }

        public void Say<T>(T message)
        {
            Console.WriteLine(message);
        }

        public void Wait()
        {
            Console.ReadKey();
        }
    }
}
