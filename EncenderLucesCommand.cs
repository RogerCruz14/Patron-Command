using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Clases
{
    public class EncenderLucesCommand : ICommand
    {
        // Referencia al objeto cuyo método se quiere encapsular
        private LucesReceiver luces;

        public EncenderLucesCommand()
        {
        }

        // El constructor inyectará el objeto cuyo método se quiere encapsular
        public EncenderLucesCommand(LucesReceiver luces)
        {
            this.luces = luces;
        }

        // El método Execute() ejecutará el método encapsulado
        public void Execute()
        {
            int distancia = luces.Encender();
            Console.WriteLine(string.Format("Encendiendo luces. Alumbrando a una distancia de {0} metros.", distancia));
        }
    }
}
