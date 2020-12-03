using System;

namespace _Cadastro_POO
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista;
        public float nota1;
        public float nota2;
        public float mediaFinal;
        public float mensalidadeat;
        public float desconto;
        public float mensalidade;

        
        //Métodos

        public float VerMediaFinal() {

            mediaFinal = (nota1 + nota2) / 2;

            return mediaFinal;
        }

        public void VerMensalidade() {
            if (bolsista == true)
            {
                desconto = mensalidadeat / 100 * 50;
                mensalidade = mensalidadeat - desconto;
                Console.WriteLine("Aluno SIM Bolsista");
                Console.WriteLine($"Mensalidade: {mensalidade}");

            } else if (bolsista == false)
            {
            
                desconto = mensalidadeat / 100 * 10;
                mensalidade = mensalidadeat - desconto;
                Console.WriteLine("Aluno NÃO Bolsista");
                Console.WriteLine($"Mensalidade: {mensalidade}");

            }

        }

    }
}