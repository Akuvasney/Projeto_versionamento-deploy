using System;

namespace Projeto_Itau_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Classe_funcionarios funcionariaAmanda = new Classe_funcionarios();

            funcionariaAmanda.nome = "Amanda";
            funcionariaAmanda.cargaHoraria = 8;
            funcionariaAmanda.valorHora = 30.0;

            Classe_funcionarios funcionarioBruno = new Classe_terceiro("Bruno", 10, 20, "Amazon", 1.5);

            Console.WriteLine("Você é terceirizado?(Y/N)");
            string resposta = Console.ReadLine();

            if (resposta == "n" || resposta == "N")
            {
                funcionariaAmanda.ImprimeDados();
            }
            else
            {
                funcionarioBruno.ImprimeDados();
            }

        }
    }
}