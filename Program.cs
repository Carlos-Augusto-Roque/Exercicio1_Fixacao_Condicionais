using System;

namespace Exercicio1_Fixacao_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano corrente: ");
            int anoCorrente = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idade;
            idade = anoCorrente - anoNascimento;
            Console.WriteLine("idade: "+idade+ " anos ");

            if(idade >=18)
            {
                Console.WriteLine("Autorizado para votar !");
            }
            else
            {
                Console.WriteLine("Sem autorização para votar !");
            }

            Console.WriteLine("----Fim----");
        }
    }
}

// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).