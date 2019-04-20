using System;

namespace RentCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Aluno[] alunos = new Aluno[10]; //
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1));
                //
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                //
                Console.Write("Email: ");
                string email = Console.ReadLine();
                //
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                //
                alunos[quarto] = new Aluno { Nome = nome, Email = email, Quarto = quarto };
                Console.WriteLine();
            }
            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (alunos[i] != null)
                {
                    Console.WriteLine(alunos[i].Quarto + ": " + alunos[i].Nome + ", " + alunos[i].Email);
                }
            }


        }
    }
}
