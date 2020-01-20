using Decorator.Services.Interfaces;
using System;

namespace Decorator.Services
{
    public class BaseDecorator : ICuentaPagarComponent
    {
        private readonly ICuentaPagarComponent Component;
        public BaseDecorator(ICuentaPagarComponent _component)
        {
            this.Component = _component ?? throw new ArgumentException(nameof(_component));
        }
        public virtual void EjecutarAccion()
        {
            if (this.Component != null)
            {
                this.Component.EjecutarAccion();
            }
        }
    }
}
