using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public enum EAnimal
        {
            Gato,
            Perro,
            Ave,
            Pez,
            Roedor,
            ReptilesYAnfibios,
            Reptil,
            Anfibio
        }
        public enum ECategoria
        {
            Alimentos,
            Juguetes,
            Accesorios,
            BebederosYComederos,
            EstéticaEHigiene,
            HogarYCamas,
            ViajesYPaseo,
            TortuguerosYTerrarios
            
        }

        public enum EMedida
        {
            Unidades,
            Litros,
            Kilos
        }

        private static int idMax;
        private string nombre;
        private string marca;
        private float precio;
        private ECategoria categoria;
        private EMedida medida;
        private EAnimal animal;
        private int cantidad;
        private int id;
        private string descripcion;

        static Producto()
        {
            idMax = 1000;
        }

        public Producto()
        {
            cantidad = 1;
        }

        public Producto(string nombre, string marca, float precio, EAnimal animal, ECategoria categoria, EMedida medida,string descripcion):this()
        {
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
            this.animal = animal;
            this.categoria = categoria;
            this.medida = medida;
            this.descripcion = descripcion;
            this.id = idMax + 1;
            idMax = this.id;

        }
        public Producto(string nombre, string marca, float precio, EAnimal animal, ECategoria categoria, EMedida medida,string descripcion, int cantidad)
            :this(nombre,marca,precio,animal,categoria,medida,descripcion)
        {
            this.cantidad = cantidad;
            
        }

        

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Marca
        {
            get
            {
                return this.marca;
            }
        }

        public float Precio
        {
            get
            {
                return this.precio;
            }
        }
        
        public EMedida Medida
        {
            get
            {
                return medida;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }
        public ECategoria Categoria
        {
            get
            {
                return categoria;
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }
        public EAnimal Animal

        {
            get
            {
                return animal;
            }
        }

    }
}
