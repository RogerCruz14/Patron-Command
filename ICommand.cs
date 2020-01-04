using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Interfaces
{
    public interface ICommand
    {
        // El método Execute() será aquel que el objeto que reciba la referencia
        // será capaz de ejecutar.
        void Execute();
    }
}
