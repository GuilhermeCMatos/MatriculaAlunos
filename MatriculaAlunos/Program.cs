using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int desenvolvimento = 0;
            int administracao = 0;
            int mecatronica = 0;
            int edificacoes = 0;

            //Loop ->
            bool continuarMatricula = true; // "bool" -> só le verdadeiro ou falso
            while (continuarMatricula)
            {
                // opções ->
                Console.WriteLine("Escolha o curso desejado:");
                Console.WriteLine("D - Desenvolvimento");
                Console.WriteLine("A - Administração");
                Console.WriteLine("M - Mecatrônica");
                Console.WriteLine("E - Edificações");

                char opcao = char.ToUpper(Console.ReadKey().KeyChar); //"char.ToUpper" faz pegar o minúsculo
                Console.WriteLine(); // -> pula linha

                // respsota ->
                switch (opcao)
                {
                    case 'D': // por algum motivo está funcionando com minúscula
                        if (desenvolvimento < 5)
                        {
                            desenvolvimento++;
                            Console.WriteLine("Matrícula realizada em Desenvolvimento.");
                        }
                        else
                        {
                            Console.WriteLine("Desculpe, não há vagas disponíveis para Desenvolvimento.");
                        }
                        break;
                    case 'A':
                        if (administracao < 5)
                        {
                            administracao++;
                            Console.WriteLine("Matrícula realizada em Administração.");
                        }
                        else
                        {
                            Console.WriteLine("Desculpe, não há vagas disponíveis para Administração.");
                        }
                        break;
                    case 'M':
                        if (mecatronica < 5)
                        {
                            mecatronica++;
                            Console.WriteLine("Matrícula realizada em Mecatrônica.");
                        }
                        else
                        {
                            Console.WriteLine("Desculpe, não há vagas disponíveis para Mecatrônica.");
                        }
                        break;
                    case 'E':
                        if (edificacoes < 5)
                        {
                            edificacoes++;
                            Console.WriteLine("Matrícula realizada em Edificações.");
                        }
                        else
                        {
                            Console.WriteLine("Desculpe, não há vagas disponíveis para Edificações.");
                        }
                        break;
                    default: //se nada der certo ->
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                // Pergunta se continuará ou não ->
                Console.WriteLine("Deseja matricular mais um aluno? (S/N)");
                char continuar = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine(); // Avança para uma nova linha após a entrada do usuário

                // verificação ->
                if (continuar != 'S') //"!=" -> "Diferente de..."
                {
                    continuarMatricula = false;
                }
            }

            // Exibir tudo ->
            Console.WriteLine("Total de matrículas por curso:");
            Console.WriteLine("Desenvolvimento: " + desenvolvimento);
            Console.WriteLine("Administração: " + administracao);
            Console.WriteLine("Mecatrônica: " + mecatronica);
            Console.WriteLine("Edificações: " + edificacoes);


            //Final ->
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
