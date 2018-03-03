using System;

namespace _01.FighterAttack
{
    class FighterAttack
    {
        static void Main(string[] args)
        {
            int Px1 = int.Parse(Console.ReadLine());
            int Py1 = int.Parse(Console.ReadLine());
            int Px2 = int.Parse(Console.ReadLine());
            int Py2 = int.Parse(Console.ReadLine());
            int Fx  = int.Parse(Console.ReadLine());
            int Fy  = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int destruction = 0;


            if (Fx + D >= Math.Min(Px1,Px2) && Fx + D <= Math.Max(Px1, Px2))
            {
                destruction = destruction + 100;
            }
            if (Fy + 1 <= Math.Max(Py1, Py2) && Fy + D >= Math.Min(Px1, Px2) && Fy + D <= Math.Max(Px1,Px2))
            {
                destruction = destruction + 50;
            }
            if (Fy - 1 >= Math.Min(Py1, Py2) && Fy + D >= Math.Min(Px1, Px2) && Fy + D <= Math.Max(Px1, Px2))
            {
                destruction = destruction + 50;
            }
            if (Fx + D + 1 <= Math.Max(Px1,Px2) && Fx + D + 1 >= Math.Min(Px1, Px2))
            {
                destruction = destruction + 75;
            }
            Console.WriteLine(destruction + "%");
        }
    }
}
