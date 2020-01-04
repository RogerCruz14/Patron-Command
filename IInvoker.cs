using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Interfaces
{
    public interface IInvoker
    {
        // Inyecta un ICommand, permitiendo cambiar la operación encapsulada en
        // tiempo de ejecución
        void SetCommand(ICommand command);

        // Ejecuta el método encapsulado
        void Invoke();
    }
}

