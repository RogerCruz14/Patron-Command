using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Clases
{
    public class LucesLargas : LucesReceiver
    {
        private const int DISTANCIA = 200;

        public override int Encender()
        {
            this.encendidas = true;
            return DISTANCIA;
        }
    }
}
