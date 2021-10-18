using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public static class Venta
    {
        
        public static List<Producto> ventasRealizadas;
        static Venta()
        {
            
            ventasRealizadas =  new List<Producto>();
            CargarProductos();
        }

        public static void CargarProductos()
        {
            Producto p1 = new Producto("Comedero", "Generico", 325, Producto.EAnimal.Ave, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, "");
            Producto p2 = new Producto("Jaula", "MetalicBirds", 1200, Producto.EAnimal.Ave, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, "");
            Producto p3 = new Producto("Pretal", "DogHola", 524, Producto.EAnimal.Ave, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, "");
            Producto p4 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perro, Producto.ECategoria.ViajesYPaseo, Producto.EMedida.Unidades, "");
            Producto p5 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perro, Producto.ECategoria.ViajesYPaseo, Producto.EMedida.Unidades, "");
            Producto p6 = new Producto("Comida Seca Adulto", "DogChow", 524, Producto.EAnimal.Ave, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, "");
            Producto p7 = new Producto("Comida Seca Adulto", "DogHola", 524, Producto.EAnimal.Ave, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, "");
            ventasRealizadas.Add(p1);
            ventasRealizadas.Add(p2);
            ventasRealizadas.Add(p3);
            ventasRealizadas.Add(p4);
            ventasRealizadas.Add(p5);
            ventasRealizadas.Add(p6);
            ventasRealizadas.Add(p7);

        }


        public static void RegistrarVenta(List<Producto> auxLista)
        {
            for (int i = 0; i < auxLista.Count; i++)
            {
                ventasRealizadas.Add(auxLista[i]);
            }
            
        }

       
    }
}
