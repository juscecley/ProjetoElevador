using System;

namespace ProjetoElevador.Model
{
    internal class Elevador
    {
        //Variavel que controla o andar atual do elevador
        private int _andarAtual = 0;

        //Variavel que controla o total de pessoas dentro do elevador
        private int _totalPessoas = 0;

        //Variavel que armazena a quantidade de andares do predio
        public readonly int TotalAndares = 0;

        //Variavel que armazena a capacidade maxima do elevador
        public readonly int Capacidade = 0;


        //Construtor da classe responsavel por inicializar as variaveis do elevador com as informacoes de entrada do usuario
        public Elevador(int capacidade, int andares)
        {
            TotalAndares = andares;
            Capacidade = capacidade;
        }

        //Metodo responsavel por adicionar uma pessoa ao elevador
        public void Entrar()
        {
            if (_totalPessoas < Capacidade)
            {
                _totalPessoas++;
                Console.WriteLine($"Uma pessoa entrou no elevador. Total de pessoas: {_totalPessoas}");
            }
            else
            {
                Console.WriteLine("Elevador com capacidade máxima.");
            }
        }

        //Metodo responsavel por remover uma pessoa do elevador
        public void Sair()
        {
            if (_totalPessoas > 0)
            {
                _totalPessoas--;
                Console.WriteLine($"Uma pessoa saiu do elevador. Total de pessoas: {_totalPessoas}");
            }
            else
            {
                Console.WriteLine("Não há pessoas no elevador");
            }
        }

        //Metodo responsavel pra subir o elevador em um andar 
        public void Subir()
        {
            if (_andarAtual < TotalAndares)
            {
                _andarAtual++;
                Console.WriteLine($"Subindo para o {_andarAtual} andar.");
            }
            else
            {
                Console.WriteLine("Elevador já está no último andar");
            }
        }

        //Metodo responsavel por descer o elevador um andar
        public void Descer()
        {
            if (_andarAtual > 0)
            {
                _andarAtual--;
                Console.WriteLine($"Descendo para o {_andarAtual} andar.");
            }
            else
            {
                Console.WriteLine("Elevador está no térreo");
            }
        }
    }
}