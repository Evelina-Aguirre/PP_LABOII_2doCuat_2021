using System;

namespace Entidades
{
    public class ClienteSinDineroExcepcion : Exception
    {
        public override string Message
        {
            get
            {
                return "El saldo no es suficiente para realizar la venta.";
            }
        }

    }
}
