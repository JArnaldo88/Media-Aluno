using System;

namespace mediaAluno
{
    internal  class program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;
            Console.WriteLine("insira a primeira nota:");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("insira a segunda nota:");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("insira a terceira nota:");
            n3 = Convert.ToDouble(Console.ReadLine());

            media = Math.Round (n1 + n2 + n3) / 3;

            if (media <= 5)
            {
                Console.WriteLine("Reprovado"  + media);
            }
            if (media >= 7)
            {
                Console.WriteLine("Aprovado" + media);
            }
            if(media > 5 && media < 7)
            {
                Console.WriteLine("Recuperação" + media );
            }
        }
    }
}

