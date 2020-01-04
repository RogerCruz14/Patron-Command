using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Command.Interfaces;

namespace Command.Clases
{
    public class ApagarLucesCommand : Interfaces.ICommand
    {
        private LucesReceiver luces;

        public ApagarLucesCommand(LucesReceiver luces)
        {
            this.luces = luces;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            luces.Apagar();
            Console.WriteLine("Apagando las luces");
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
