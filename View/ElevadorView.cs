using ProjetoElevador.Model;
using System;

namespace ProjetoElevador.View
{
    internal class ElevadorView
    {
        //Metodo responsavel pela exibicao do menu do usuario
        public void Show(Elevador elevador)
        {
            var continuar = true;

            while (continuar)
            {
                Console.WriteLine($@"
                Andares do predio: {elevador.TotalAndares}
                Capacidade do elevador: {elevador.Capacidade}

                Quantidade de pessoas no elevador: {elevador.TotalPessoas}
                Andar Atual: {elevador.AndarAtual}

                Escolha uma opção:
                1 - Entar no Elevador
                2 - Sair do Elevador
                3 - Subir um Andar
                4 - Descer um Andar
                5 - Sair
                ");

                var opcao = Console.ReadLine();
                Console.Clear();


                switch (opcao)
                {
                    case "1":
                        elevador.Entrar();
                        break;
                    case "2":
                        elevador.Sair();
                        break;
                    case "3":
                        elevador.Subir();
                        break;
                    case "4":
                        elevador.Descer();
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}