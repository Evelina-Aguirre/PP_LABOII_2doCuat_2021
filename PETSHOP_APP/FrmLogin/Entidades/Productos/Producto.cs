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
            Gatos,
            Perros,
            Aves,
            Peces,
            Roedores,
            ReptilesYAnfibios,
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

        static Producto()
        {
            idMax = 1000;
        }

        public Producto()
        {
            cantidad = 0;
        }
        public Producto(string nombre, string marca, float precio, EAnimal animal, ECategoria categoria, EMedida medida, int cantidad)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
            this.animal = animal;
            this.categoria = categoria;
            this.medida = medida;
            this.cantidad = cantidad;
            this.id = idMax + 1;
            idMax = this.id;
        }

        public int GetIdMax
        {
            get
            {
                return idMax;
            }
        }
        public ECategoria Categoria
        {
            get
            {
                return categoria;
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
        public EAnimal Animal

        {
            get
            {
                return animal;
            }
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

    }
}
