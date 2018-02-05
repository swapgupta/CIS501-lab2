using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_SoftwareArch_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess an int, M, in range 0..10: M =");
            string M = Console.ReadLine();

            int guess;
            bool isNumeric = int.TryParse(M, out guess);
            while (!isNumeric || guess > 10 || guess < 0)
            {
                Console.Write("Invalid Entry. Try Again: ");
                M = Console.ReadLine();
                isNumeric = int.TryParse(M, out guess);
            }

            Random r = new Random();
            int intM = Int32.Parse(M);
            int min = 0;
            int max = 10 - intM;
            int N = r.Next(min, max);
            Console.WriteLine("I guess int, {0}, in range 0..{1}", N, max);

            Console.Write("now you type an int, P, such that M + N + P = 10: P = ");
            string P = Console.ReadLine();
            int intP;
            bool isP_Num = int.TryParse(P, out intP);
            while (!isP_Num)
            {
                Console.Write("Invalid Entry. Try Again: ");
                P = Console.ReadLine();
                isP_Num = int.TryParse(P, out intP);
            }

            int sum = intP + N + intM;
            if(sum == 10)
            {
                Console.Write("You win!");
            }
            else
            {
                Console.Write("You lose!");
            }

            Console.ReadLine();
        }
    }
}
