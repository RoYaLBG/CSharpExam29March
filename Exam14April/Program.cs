using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam14April
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 10
            char startLetter = Console.ReadLine()[0];

            int toIncrease = 0;
            bool toBreak = false;
            int lineCheck = n; // 10

            for (var c = 0; c <= n / 7; c++)
            {
                if (toBreak) break;
                for (var i = 1; i <= 3; i++)
                {
                    if (lineCheck <= 0)
                    {
                        toBreak = true;
                        break;
                    }
                    int charCount = i * 2 - 1;
                    int dotCount = (7 - charCount) / 2;
                    Console.Write(new string('.', dotCount));
                    for (var j = 0; j < charCount; j++)
                    {
                        Console.Write((char)(startLetter + toIncrease));
                        if ((char)(startLetter + toIncrease) == 'G')
                        {
                            toIncrease = -1;
                            startLetter = 'A';
                        }
                        toIncrease++;
                    }
                    Console.Write(new string('.', dotCount));
                    Console.WriteLine();
                    lineCheck--;
                }

                if (lineCheck <= 0)
                {
                    toBreak = true;
                    break;
                }

                for (var j = 0; j < 7; j++)
                {
                    Console.Write((char)(startLetter + toIncrease));
                    if ((char)(startLetter + toIncrease) == 'G')
                    {
                        toIncrease = -1;
                        startLetter = 'A';
                    }
                    toIncrease++;
                }

                Console.WriteLine();
                lineCheck--;

                for (var i = 3; i >= 1; i--)
                {
                    if (lineCheck <= 0)
                    {
                        toBreak = true;
                        break;
                    }
                    int charCount = (2 * i - 1);
                    int dotCount = (7 - charCount) / 2;
                    Console.Write(new string('.', dotCount));
                    for (var j = 0; j < charCount; j++)
                    {
                        Console.Write((char)(startLetter + toIncrease));
                        if ((char)(startLetter + toIncrease) == 'G')
                        {
                            toIncrease = -1;
                            startLetter = 'A';
                        }
                        toIncrease++;
                    }
                    Console.WriteLine(new string('.', dotCount));
                    lineCheck--;
                }
            }
        }
    }
}
