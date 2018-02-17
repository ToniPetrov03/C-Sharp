using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipDamage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sx1 = int.Parse(Console.ReadLine());
            int Sy1 = int.Parse(Console.ReadLine());
            int Sx2 = int.Parse(Console.ReadLine());
            int Sy2 = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int Cx1 = int.Parse(Console.ReadLine());
            int Cy1 = int.Parse(Console.ReadLine());
            int Cx2 = int.Parse(Console.ReadLine());
            int Cy2 = int.Parse(Console.ReadLine());
            int Cx3 = int.Parse(Console.ReadLine());
            int Cy3 = int.Parse(Console.ReadLine());

            Sy1 = H - (Sy1 - H);
            Sy2 = H - (Sy2 - H);

            int top = Math.Max(Sy1, Sy2);
            int bottom = Math.Min(Sy1, Sy2);
            int left = Math.Min(Sx1, Sx2);
            int right = Math.Max(Sx1, Sx2);

            int score1 = GetScore(Cx1, Cy1, top, bottom, left, right);
            int score2 = GetScore(Cx2, Cy2, top, bottom, left, right);
            int score3 = GetScore(Cx3, Cy3, top, bottom, left, right);

            int score = score1 + score2 + score3;
            Console.WriteLine(score + "%");
        }

        private static int GetScore(int x, int y, int top, int bottom, int left, int right)
        {
            int score = 0;
            if (x < right && x > left && y > bottom && y < top)
            {
                score = 100;
            }
            // corner
            else if (
                x == right && y == bottom ||
                x == left && y == top ||
                x == right && y == top ||
                x == left && y == bottom)
            {
                score = 25;
            }
            else if (
                x == right && y < top && y > bottom ||
                x == left && y < top && y > bottom ||
                y == top && x > left && x < right ||
                y == bottom && x > left && x < right)
            {
                score = 50;
            }

            return score;
        }
    }
}
