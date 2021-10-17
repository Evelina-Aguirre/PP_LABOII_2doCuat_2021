using System.Collections.Generic;

namespace Entidades
{
    public class Cliente : Persona
    {
        private List<Producto> carrito;
        private float saldo;

       
        public Cliente(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            carrito = new List<Producto>();  
        }
        public Cliente(string nombre, string apellido, int dni, List<Producto> carrito, float saldo) : this(nombre, apellido, dni)
        {
            this.carrito = carrito;
            this.saldo = saldo;
        }

        public List<Producto> Carrito
        {
            get
            {
                return this.carrito;
            }
        }

        public float Dinero
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }

        /// <summary>
        /// Agrega un producto a la lista Carrito del cliente.
        /// </summary>
        /// <param name="p">Producto a agregar</param>
        /// <param name="c">Carrito donde será agregado el producto</param>
        /// <returns></returns>
        public static bool AgregarProductoAlCarrito(Producto p, Cliente c)
        {
            return c + p;
        }

        /// <summary>
        /// Remueve un producto a la lista Carrito del cliente.
        /// </summary>
        /// <param name="p">Producto a Remover</param>
        /// <param name="c">Cliente del cual será removiso</param>
        /// <returns></returns>
        public static bool QuitarrProductoAlCarrito(Producto p, Cliente c)
        {
            return c - p;
        }

        public bool RemoverTodosLosProductosDeUnaClase(Producto p, Cliente c)
        {
            if (c.Carrito != null || p != null)
            {
                for (int i = 0; i < c.carrito.Count; i++)
                {
                    if (p.Id == c.carrito[i].Id)
                        c.carrito.Remove(p);
                }
                return true;
            }
            else
                return false;
        }
        public static bool operator +(Cliente c, Producto p)
        {
            if (c.Carrito != null || p != null)
            {
                for (int i = 0; i < c.carrito.Count; i++)
                {
                    if (p.Id == c.carrito[i].Id)
                        c.Carrito[i].Cantidad++;
                    else
                        c.carrito.Add(p);
                }
                return true;
            }
            else
                return false;
        }

        public static bool operator -(Cliente c, Producto p)
        {
            if (c.Carrito != null || p != null)
            {
                for (int i = 0; i < c.carrito.Count; i++)
                {
                    if (p.Id == c.carrito[i].Id)
                        c.Carrito[i].Cantidad--;
                    else
                        c.carrito.Remove(p);
                }
                return true;
            }
            else
                return false;

        }
    }
}
