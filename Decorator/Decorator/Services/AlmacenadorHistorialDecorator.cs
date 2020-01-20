using Decorator.Services.Interfaces;
using System;

namespace Decorator.Services
{
    public class AlmacenadorHistorialDecorator : BaseDecorator
    {
        public AlmacenadorHistorialDecorator(ICuentaPagarComponent _component) : base(_component)
        {
        }

        public override void EjecutarAccion()
        {
            base.EjecutarAccion();
            Console.WriteLine(">> Se ha guardado el historial.");
        }
    }
}
