using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n + 2;

            Console.WriteLine(
            "{0}*{0}", new string('.', width/2));
            
            for (var i = 1; i <=  n / 2 + 1; i++)
            {
                Console.WriteLine(
                    "{0}*{1}*{0}",
                    new string('.', (width/2)-i),
                    new string('.', (2 * i) - 1)
                );
            }

            Console.WriteLine(
                "{0}{1}{0}",
                new string('*', n),
                new string('.', width - 2 * n)
            );

            for (var i = 1; i <= n / 2; i++)
            {
                Console.WriteLine(
                    "{0}*{1}*{0}",
                    new string('.', i),
                    new string('.', width - (2 * (i) + 2))
                );
            }

            /*
            for (var i = 1; i <= n / 2 ; i++)
            {
                Console.WriteLine(
                    "{0}*{1}*{2}*{3}*{2}*{1}*{0}",
                    new string('.', n/2 - i),
                    new string('.', n/2),
                    new string('.', i-1),
                    new string('.', n)
                );
            }
            */

            for (var i = n/2; i > 0; i--)
            {
                Console.WriteLine(
                    "{0}*{1}*{2}*{3}*{2}*{1}*{0}",
                    new string('.', i - 1),
                    new string('.', n / 2),
                    new string('.', n / 2 - i),
                    new string('.', n)
                );
            }

            Console.WriteLine("{0}{1}*{2}*{1}{0}",
                new string('*', n/2 + 1),
                new string('.', n/2),
                new string('.', n)
            );

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{0}*{0}",
                    new string('.', n)
                );
            }

            Console.WriteLine("{0}{1}{0}",
                new string('.', n),
                new string('*', n + 2)
            );
        }
    }
}
