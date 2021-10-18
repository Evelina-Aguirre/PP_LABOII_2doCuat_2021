using System;

namespace Entidades
{
    public class UsuarioInvalidoException : Exception
    {
        public override string Message
        {
            get
            {
                return "Usuario o contraseña incorrectos.";
            }
        }
    }
}
