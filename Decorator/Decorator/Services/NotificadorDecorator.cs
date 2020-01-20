using Decorator.Services.Interfaces;
using System;

namespace Decorator.Services
{
    public class NotificadorDecorator : BaseDecorator
    {
        public NotificadorDecorator(ICuentaPagarComponent _component) : base(_component)
        {
        }

        public override void EjecutarAccion()
        {
            base.EjecutarAccion();
            Console.WriteLine(">>> Se ha enviado el correo.");
        }
    }
}
