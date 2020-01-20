using Decorator.Services.Interfaces;
using System;

namespace Decorator.Services
{
    public class AlmacenadorCuentaPagarDecorator : ICuentaPagarComponent
    {
        public void EjecutarAccion()
        {
            Console.WriteLine("> Se ha guardado la entidad cuenta x pagar.");
        }
    }
}
