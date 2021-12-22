using ProjetoElevador.Controller;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var eveladorController = new ElevadorController();

            eveladorController.Init();
        }
    }
}