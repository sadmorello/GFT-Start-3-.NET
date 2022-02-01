using System;

namespace Desafios
{
    class Media
    {
        static void Main(string[] args)
        {
            double a, b, c, d, avg;
            string[] values = Console.ReadLine().Split(' ');
            a = double.Parse(values[0]) * 2;
            b = double.Parse(values[1]) * 3;
            c = double.Parse(values[2]) * 4;
            d = double.Parse(values[3]) * 1;
            avg = (a + b + c + d) / 10;
            Console.WriteLine("Media: {0:0.0}", Math.Round(avg, 1, MidpointRounding.ToEven));
            if (avg >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (avg < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (avg >= 5.0 && avg <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: {0:0.0}", Math.Round(e, 1, MidpointRounding.ToEven));
                avg = (avg + e) / 2;
                if (avg >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado");
                }
                Console.WriteLine("Media final: {0:0.0}", Math.Round(avg, 1, MidpointRounding.ToEven));
            }
            Console.ReadKey();
        }
    }
}