using ProjetoElevador.Model;
using ProjetoElevador.View;
using System;

namespace ProjetoElevador.Controller
{
    internal class ElevadorController
    {
        
        //Metodo responsavel pela inicializacao da view
        public void Init()
        {
            Console.Write("Informe a quantidade de andares do predio: ");
            var andares = int.Parse(Console.ReadLine());

            Console.Write("Informe a capaciadade de pessoas no elevador: ");
            var capacidade = int.Parse(Console.ReadLine());
            
            Console.Clear();

            var elevador = new Elevador(capacidade, andares);

            var elevadorView = new ElevadorView();

            elevadorView.Show(elevador);
        }

    }
}
