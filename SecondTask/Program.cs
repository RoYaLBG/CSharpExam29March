using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('\\');

            var month = input[0];
            var moneyPerHour = decimal.Parse(input[1]);
            var hoursPerDay = decimal.Parse(input[2]);
            var itemPrice = decimal.Parse(input[3]);

            var daysPerMonth = 31;

            switch (month)
            {
                case "Feb":
                    daysPerMonth = 18;
                    break;
                case "Apr":
                case "June":
                case "Sept":
                case "Nov":
                    daysPerMonth = 20;
                    break;
                default:
                    daysPerMonth = 21;
                    break;
            }

            var hoursPerMonth = hoursPerDay * daysPerMonth;
            var moneyPerMonth = hoursPerMonth * moneyPerHour;

            if (moneyPerMonth > 700)
            {
                moneyPerMonth = moneyPerMonth 
                    + moneyPerMonth * 0.1M;
            }

            var moneyLeft = moneyPerMonth - itemPrice;
            var output = "";
            if (moneyLeft >= 0)
            {
                output = string.Format(
                    "Money left = {0:f2} leva.", 
                    moneyLeft
                    );
            }
            else
            {
                output = string.Format(
                    "Not enough money. {0:f2} leva needed.",
                    Math.Abs(moneyLeft)
                    );
            }

            Console.WriteLine(output);
        }
    }
}
