using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero.
            Console.WriteLine("EXERCÍCIO 1");
            int num = 0;
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if(num > 0)
            {
                Console.WriteLine("O número informado é POSITIVO");
            } 
            else if(num < 0)
            {
                Console.WriteLine("O número informado é NEGATIVO");
            }
            else
            {
                Console.WriteLine("O número informado tem valor igual à ZERO");
            }

            //2- Escreva um programa que leia um mês do ano e informe quantos dias ele tem.
            Console.WriteLine(" ");
            Console.WriteLine("EXERCÍCIO 2");

            int mes = 0;
            Console.Write("Digite o número do respectivo mês desejado: ");
            mes = int.Parse(Console.ReadLine());

            if(mes == 1 )
            {
                Console.WriteLine("O mês Janeiro possui 31 DIAS");
            }
            else if(mes == 2)
            {
                Console.WriteLine("O mês Fevereiro possui 28 ou 29 DIAS");
            }
            else if(mes == 3)
            {
                Console.WriteLine("O mês Março possui 30 DIAS");
            }
            else if(mes == 4)
            {
                Console.WriteLine("O mês Abril possui 30 DIAS");
            }
            else if (mes == 5)
            {
                Console.WriteLine("O mês Maio possui 30 DIAS");
            }
            else if(mes == 6)
            {
                Console.WriteLine("O mês Junho possui 30 DIAS");
            }
            else if(mes == 7)
            {
                Console.WriteLine("O mês Julho possui 31 DIAS");
            }
            else if(mes == 8)
            {
                Console.WriteLine("O mês Agosto possui 31 DIAS");
            }
            else if(mes == 9)
            {
                Console.WriteLine("O mês Setembro possui 30 DIAS");
            }
            else if(mes == 10)
            {
                Console.WriteLine("O mês Outubro possui 31 DIAS");
            }
            else if(mes == 11)
            {
                Console.WriteLine("O mês Novembro possui 30 DIAS");
            }
            else if(mes == 12)
            {
                Console.WriteLine("O mês Dezembro possui 31 DIAS");
            }

            //3- Faça um programa que leia a nota de um aluno e informe se ele está aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor que 5).
            Console.WriteLine(" ");
            Console.WriteLine("EXERCÍCIO 3");

            int nota = 0;
            Console.Write("Digite sua nota: ");
            nota = int.Parse(Console.ReadLine());

            if(nota >= 7)
            {
                Console.WriteLine("Você foi APROVADO!");
            }
            else if(nota >= 5)
            {
                Console.WriteLine("Você está de RECUPERAÇÃO!");
            }
            else
            {
                Console.WriteLine("Você foi REPROVADO!");
            }

            //4- Calcule a soma de todos os números de 1 a 100 utilizando um laço de repetição.
            Console.WriteLine(" ");
            Console.WriteLine("EXERCÍCIO 4");

            int n = 0;

            for(int i = 1; i<=100; i++)
            {
                n = i + n;
                Console.WriteLine(n);
            }

            //5- Implemente uma contagem regressiva de 10 até 0 utilizando um laço de repetição.
            Console.WriteLine("");
            Console.WriteLine("EXERCÍCIO 5");

            for(int i = 10; i>=0; i--)
            {
                Console.WriteLine(i);
            }

            //6- Faça um programa que leia o nome de um aluno e suas três notas, calcule a média e informe se ele está aprovado (média maior ou igual a 7) ou reprovado.
            Console.WriteLine("");
            Console.WriteLine("EXERCÍCIO 6");

            string nome = "";
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            float n1 = 0;
            Console.Write("Digite a primeira nota: "); 
            n1 = float.Parse(Console.ReadLine());

            float n2 = 0;
            Console.Write("Digite a primeira nota: ");
            n2 = float.Parse(Console.ReadLine());

            float n3 = 0;
            Console.Write("Digite a primeira nota: ");
            n3 = float.Parse(Console.ReadLine());

            float media = (n1 + n2 + n3) / 3;
            
            if(media >= 7)
            {
                Console.WriteLine("VOCÊ FOI APROVADO! Sua média foi " + media);
            }
            else if(media < 7)
            {
                Console.WriteLine("VOCÊ FOI REPROVADO! Sua média foi " + media);
            }

            //DESAFIO - Faça um programa que peça ao usuário para digitar um ano e verifique se é bissexto.
            Console.WriteLine("");
            Console.WriteLine("DESAFIO");

            int ano = 0;
            Console.Write("Digite um ano: ");
            ano = int.Parse(Console.ReadLine());

            if(ano % 4 == 0)
            {
                Console.WriteLine("O ano de " + ano + " é bissexto");
            }
            else
            {
                Console.WriteLine("O ano de " + ano + " não é bissexto");
            }

        }
    }
}
