using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int id;
        private static int idMax;

        static Persona()
        {
            idMax = 100;   
        }
        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.id = idMax + 1;
            idMax = this.id;
        }

        public virtual string Nombre 
        {
            get
            {
                return this.nombre;
            } 
        }
        public virtual string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public virtual int Dni
        {
            get
            {
                return this.dni;
            }
        }
      
        public virtual int Id
        {
            get
            {
                return this.id;
            }
        }

        


    }
}
