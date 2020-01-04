using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Clases
{
    // Clase abstracta de la que heredarán las clases que serán encapsuladas por los
    // objectos Command. Por lo tanto, sus métodos serán aquellos que encapsulará el
    // método Execute().
    public abstract class LucesReceiver
    {
        protected bool encendidas;
        protected int distanciaAlumbrado;

        // Propiedad de sólo lectura que devolverá el estado de las luces
        public bool Encendidas
        {
            get { return encendidas; }
        }

        // Método encargado de apagar las luces. Establece el estado del atributo 'encendidas'
        // a 'false'. Será común a todas las clases que hereden de ella.
        public void Apagar()
        {
            this.encendidas = false;
        }

        // El método Encender será distinto en cada una de las clases que hereden de esta clase.
        public abstract int Encender();
    }
}
