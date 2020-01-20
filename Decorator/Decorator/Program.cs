using Decorator.Services;
using Decorator.Services.Interfaces;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InicializarAplicacion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        static void InicializarAplicacion()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            ICuentaPagarComponent GuadarCuentaPagar = new AlmacenadorCuentaPagarDecorator();
            ICuentaPagarComponent Historial = new AlmacenadorHistorialDecorator(GuadarCuentaPagar);
            ICuentaPagarComponent Notificador = new NotificadorDecorator(Historial);
            Notificador.EjecutarAccion();

        }
    }
}
