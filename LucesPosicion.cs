using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Clases
{
    public class LucesPosicion : LucesReceiver
    {
        private const int DISTANCIA = 1;

        public override int Encender()
        {
            this.encendidas = true;
            return DISTANCIA;
        }
    }
}
