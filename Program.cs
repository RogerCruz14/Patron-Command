using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Clases;
using Command.Interfaces;

namespace Command
{
    class Program
    {
       public  static void Main(string[] args)
        {
            // Instanciamos los objetos cuyos métodos serán encapsulados dentro de
            // objetos que implementan ICommand
            LucesReceiver lucesPosicion = new LucesPosicion();
            LucesReceiver lucesCortas = new LucesCortas();
            LucesReceiver lucesLargas = new LucesLargas();

            // Creamos los objetos Command que encapsulan los métodos de las clases anteriores
            ICommand encenderPosicion = new EncenderLucesCommand(lucesPosicion);
            ICommand apagarPosicion = new ApagarLucesCommand(lucesPosicion);

            ICommand encenderCortas = new EncenderLucesCommand(lucesCortas);
            ICommand apagarCortas = new ApagarLucesCommand(lucesCortas);

            ICommand encenderLargas = new EncenderLucesCommand(lucesLargas);
            ICommand apagarLargas = new ApagarLucesCommand(lucesLargas);

            // Creamos un nuevo Invoker (el objeto que será desacoplado de las luces)
            IInvoker invoker = new ControladorLucesInvoker();

            // Le asociamos los objetos Command y los ejecutamos
            // El objeto invoker invoca el método 'Execute()' sin saber en ningún momento
            // qué es lo que se está ejecutando realmente.
            invoker.SetCommand(encenderPosicion);      // Asociamos el ICommand
            invoker.Invoke();                          // Hacemos que se ejecute ICommand.Execute()

            // Realizamos lo mismo con el resto de instancias que implementan ICommand.
            // Como podemos ver, el ICommand puede asignarse en tiempo de ejecucion
            invoker.SetCommand(apagarPosicion);
            invoker.Invoke();

            // Luces cortas
            invoker.SetCommand(encenderCortas);
            invoker.Invoke();

            invoker.SetCommand(apagarCortas);
            invoker.Invoke();

            // Luces largas
            invoker.SetCommand(encenderLargas);
            invoker.Invoke();

            invoker.SetCommand(apagarLargas);
            invoker.Invoke();
            Console.ReadLine();
        }
    }
}
