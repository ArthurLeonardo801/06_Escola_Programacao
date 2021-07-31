using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*          Dado que eu tenho uma escola de programação
            Faça um programa que capture o nome, a matricula e as notas (4 notas) dos alunos
            Os alunos serão aprovados com notas igual ou maior que 7
            A quantidade de alunos é dinamica, ou seja, o usuário do programa pode digitar quantos alunos ele quiser.
            Obs: temos que digitat os nomes, as matriculas as notas e o sistema calcular o resto
            No final do programa, mostre um relatório assim:                                                             */
namespace EscolaProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine("| PROGRAMA NOTAS ESCOLA PROGRAMACAO  |");
            Console.WriteLine(" ------------------------------------");
            int opcao = 1;
            while (opcao != 0)
            {
                Console.WriteLine("| Opção 1 : Adicione Aluno           |");
                Console.WriteLine("| Opção 2 : Listar Boletins Alunos   |");
                Console.WriteLine("| Opção 0 : Sair                     |");
                Console.WriteLine(" ------------------------------------" );
                Console.WriteLine("Opção:                                ");
                int menu = Convert.ToInt32(Console.ReadLine());


            }
        }
    }
}
