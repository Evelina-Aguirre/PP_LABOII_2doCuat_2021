using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        private double sueldo;
        private string usuario;
        private string clave;
        public Empleado(string nombre, string apellido, int dni, double sueldo, string usuario, string clave) 
            : base(nombre, apellido, dni)
        {
            this.sueldo = sueldo;
            this.usuario = usuario;
            this.clave = clave;
        }

        public override string Nombre
        {
            get
            {
                return base.Nombre;
            }
        }
        public override string Apellido
        {
            get
            {
                return base.Apellido;
            }
        }
        public override int Dni
        {
            get
            {
                return base.Dni;
            }
        }
        public virtual double Sueldo
        {
            get { return this.sueldo; }
        }

        public virtual string Usuario
        {
            get { return this.usuario; }
        }

        public virtual string Clave
        {
            get { return this.clave; }
        }

        
        
        public static bool operator == (Empleado e1, Empleado e2)
        {
            return e1.Id == e2.Id;
        }
        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

    }
}
