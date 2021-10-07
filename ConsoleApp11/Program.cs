using System;

namespace ConsoleApp11
{
    class Program
    {
        private static void Main(string[] args)
        {
            pessoa[] vect = new pessoa[10];//declara numero de quartos

            Console.WriteLine("quantos quartos serão alugados?: ");
            int n = int.Parse(Console.ReadLine());//coleta e separa a quantidade de quartos salvos.

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();//pula linha
                Console.WriteLine($"hospede #{ i}");
                Console.WriteLine("Nome");//recebe nome
                string nome = Console.ReadLine();
                Console.WriteLine("Email");//recebe email
                string email = Console.ReadLine();
                Console.WriteLine("Quarto");//recebe quarto
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new pessoa(nome, email);//salva no vector
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i<10; i++)
            {
                if(vect[i] != null)//se possui algo dentro de tal vector, imprime itens do vector
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
