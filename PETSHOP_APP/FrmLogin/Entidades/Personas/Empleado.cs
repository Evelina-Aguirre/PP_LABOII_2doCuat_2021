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
        public Empleado(string nombre, string apellido, int dni, int id, double sueldo, string usuario, string clave) 
            : base(nombre, apellido, dni)
        {
            this.sueldo = sueldo;
            this.usuario = usuario;
            this.clave = clave;
        }

        public virtual string Usuario
        {
            get { return this.usuario; }
        }

        public virtual string Clave
        {
            get { return this.clave; }
        }

        public virtual double Sueldo 
        {
            get { return this.sueldo; }
        }


    }
}
