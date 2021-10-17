namespace Entidades
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre, string apellido, int dni, double sueldo, string usuario, string clave)
            : base(nombre, apellido, dni, sueldo, usuario, clave)
        {

        }

        public override string Nombre
        {
            get { return base.Nombre; }
        }
        public override string Apellido
        {
            get { return base.Apellido; }
        }
        public override int Dni
        {
           get { return base.Dni; }
        }
        public override string Usuario
        {
            get { return base.Usuario; }
        }

        public override string Clave
        {
            get { return base.Clave; }
        }

        public override double Sueldo
        {
            get { return base.Sueldo; }
        }


    }
}
