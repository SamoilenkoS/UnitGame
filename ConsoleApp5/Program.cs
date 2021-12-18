using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Ex1()
        {
            Triangle triangle = new Triangle();
            triangle.A = 1;
            Console.WriteLine($"A:{triangle.A};B:{triangle.B};C:{triangle.C}");
            Console.WriteLine(triangle.Square);
        }

        static void Ex2()
        {
            double sum = 0;
            Shape[] shapes = new Shape[2];
            shapes[0] = new Triangle();
            shapes[1] = new Rectangle();
            foreach (var shape in shapes)
            {
                sum += shape.Square;
            }

            Console.WriteLine(sum);
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int warriorsWinCount = 0;
            for (int i = 0; i < 1000; i++)
            {
                Unit[] units = new Unit[2];
                units[0] = new Warrior();
                units[1] = new Archer();
                int attack = 0;
                int defence = 1;
                while (units[0].HP > 0 && units[1].HP > 0)
                {
                    units[attack].Attack(units[defence]);
                    Swap(ref attack, ref defence);
                }
                warriorsWinCount += units[0].HP > 0 ? 1 : 0;
            }

            Console.WriteLine(warriorsWinCount);
            Console.WriteLine($"{(double)Archer.DodgeCount/Archer.AttackCount}");
        }
    }
}
