using System;

namespace _Cadastro_POO
{
    class Program
    {
        static void Main(string[] args)
        {

            //variaveis
            string bolsist;

            Aluno estudante = new Aluno();

            Console.WriteLine("================================================================");
            Console.WriteLine("========================== CADASTRO ============================");
            Console.WriteLine("================================================================\n");
            
            Console.Write("=======      Nome: ");
            estudante.nome = Console.ReadLine().ToUpper();

            Console.Write("\n=======      Curso: ");
            estudante.curso = Console.ReadLine().ToUpper();

            Console.Write("\n=======      Idade: ");
            estudante.idade = int.Parse( Console.ReadLine() );

            Console.Write("\n=======      RG: ");
            estudante.rg = Console.ReadLine();

            Console.Write("\n=======      Bolsista (S/N): ");
            bolsist = Console.ReadLine();

            
            if (bolsist == "s" || bolsist == "sim") {

                estudante.bolsista = true;

            }
            else if (bolsist == "n" || bolsist == "nao" || bolsist == "não"){

                estudante.bolsista = false;
            
            }
            
            Console.Write("\n=======      Mensalidade Atual: ");
            estudante.mensalidadeat = float.Parse( Console.ReadLine() );

            Console.Write("\n=======      Nota 1: ");
            estudante.nota1 = float.Parse( Console.ReadLine() ); 
            
            Console.Write("\n=======      Nota 2: ");
            estudante.nota2 = float.Parse( Console.ReadLine() );


            Console.WriteLine($"\n \nNome: {estudante.nome}");
            Console.WriteLine($"\nCurso: {estudante.curso}");
            Console.WriteLine($"\nIdade: {estudante.idade}");
            Console.WriteLine($"\nRG: {estudante.rg}");
            Console.WriteLine($"\nNota1: {estudante.nota1} // Nota2: {estudante.nota2}");
            Console.WriteLine($"\nMédia Final: {estudante.VerMediaFinal()}");
            estudante.VerMensalidade();
        }
    }
}