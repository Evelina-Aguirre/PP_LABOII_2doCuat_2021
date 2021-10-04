namespace Entidades
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre, string apellido, int dni, int id, double sueldo, string usuario, string clave) 
            : base(nombre, apellido, dni, id, sueldo, usuario, clave)
        {
        
        }

        public override string Usuario
        {
            get { return base.Usuario; }
        }

        public override string Clave
        {
            get { return base.Clave ; }
        }

        public override double Sueldo
        {
            get { return base.Sueldo; }
        }



    }
}
