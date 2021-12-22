using System;

namespace ProjetoElevador.Model
{
    internal class Elevador
    {
        //Variavel que controla o andar atual do elevador
        public int AndarAtual;

        //Variavel que controla o total de pessoas dentro do elevador
        public int TotalPessoas;

        //Variavel que armazena a quantidade de andares do predio
        public readonly int TotalAndares;

        //Variavel que armazena a capacidade maxima do elevador
        public readonly int Capacidade;


        //Construtor da classe responsavel por inicializar as variaveis do elevador com as informacoes de entrada do usuario
        public Elevador(int capacidade, int andares)
        {
            TotalAndares = andares;
            Capacidade = capacidade;
        }

        //Metodo responsavel por adicionar uma pessoa ao elevador
        public void Entrar()
        {
            if (TotalPessoas < Capacidade)
            {
                TotalPessoas++;
                Console.WriteLine("Uma pessoa entrou no elevador");
            }
            else
            {
                Console.WriteLine("Elevador com capacidade máxima.");
            }
        }

        //Metodo responsavel por remover uma pessoa do elevador
        public void Sair()
        {
            if (TotalPessoas > 0)
            {
                TotalPessoas--;
                Console.WriteLine("Uma pessoa saiu do elevador");
            }
            else
            {
                Console.WriteLine("Não há pessoas no elevador");
            }
        }

        //Metodo responsavel pra subir o elevador em um andar 
        public void Subir()
        {
            if (AndarAtual < TotalAndares)
            {
                AndarAtual++;
                Console.WriteLine($"Subindo para o {AndarAtual} andar.");
            }
            else
            {
                Console.WriteLine("Elevador já está no último andar");
            }
        }

        //Metodo responsavel por descer o elevador um andar
        public void Descer()
        {
            if (AndarAtual > 0)
            {
                AndarAtual--;
                Console.WriteLine($"Descendo para o {AndarAtual} andar.");
            }
            else
            {
                Console.WriteLine("Elevador está no térreo");
            }
        }
    }
}