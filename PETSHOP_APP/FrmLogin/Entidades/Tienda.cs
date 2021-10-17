using System.Collections.Generic;

namespace Entidades
{
    public static class Tienda
    {
        public static List<Persona> personas;
        public static List<Producto> stock;
        public static List<Cliente> clientes;
       

        static Tienda()
        {
            personas = new List<Persona>();
            stock = new List<Producto>();
            clientes = new List<Cliente>();


            CargarEmpleadosActuales();
            CargarClientes();
            CargarProductoPerros();
        }


        public static List<Cliente> Clientes
        {
            get { return clientes; }

        }
        public static List<Producto> Stock
        {
            get { return stock; }

        }

        public static List<Persona> Personas
        {
            get { return personas; }

        }


        public static bool CargarEmpleados(Persona p)
        {

            foreach (Persona item in personas)
            {
                if (item != p)
                {
                    personas.Add(p);
                    return true;
                }
            }
            return false;
        }

        public static void CargarEmpleadosActuales()
        {
            Empleado e1 = new Empleado("María", "Perez", 33333333, 1, 90000, "maria", "maria123");
            Empleado e2 = new Empleado("Pedro", "Aldobar", 33333334, 2, 90000, "pedro", "pedro123");

            Administrador a1 = new Administrador("Ian", "Del Rio", 33333335, 3, 90000, "ian", "ian123");

            personas.Add(e1);
            personas.Add(e2);
            personas.Add(a1);
        }

        public static void  CargarProductoPerros()
        {
           //Gatos
            Producto p1 = new Producto("Alimento", "Purina", 325, Producto.EAnimal.Gatos, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, 50);
            Producto p2 = new Producto("Alimento", "CatChow", 1200, Producto.EAnimal.Gatos, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, 50);
            Producto p3 = new Producto("Bebedero", "Generico", 524, Producto.EAnimal.Gatos, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, 50);
            Producto p4 = new Producto("Comedero", "Generico", 524, Producto.EAnimal.Gatos, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, 50);
            Producto p5 = new Producto("Chaleco Térmico", "Generico", 524, Producto.EAnimal.Gatos, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, 50);
            Producto p6 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Gatos, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, 50);
            Producto p7 = new Producto("Pala", "Generico", 524, Producto.EAnimal.Gatos, Producto.ECategoria.EstéticaEHigiene, Producto.EMedida.Unidades, 50);
            Producto p8 = new Producto("Piedras", "Generico", 524, Producto.EAnimal.Gatos, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, 50);
            Producto p9 = new Producto("Cama Almohadón", "Generico", 524, Producto.EAnimal.Gatos, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, 50);
            Producto p10 = new Producto("Raton mecánico", "Generico", 524, Producto.EAnimal.Gatos, Producto.ECategoria.Juguetes, Producto.EMedida.Unidades, 50);
            Producto p11 = new Producto("Caña Pescar", "Generico", 524, Producto.EAnimal.Gatos, Producto.ECategoria.Juguetes, Producto.EMedida.Unidades, 50);
            Producto p12 = new Producto("Jaula Viaje", "Generico", 524, Producto.EAnimal.Gatos, Producto.ECategoria.ViajesYPaseo, Producto.EMedida.Unidades, 50);
            Producto p13 = new Producto("Bolso Viaje", "DogHoGenericola", 524, Producto.EAnimal.Gatos, Producto.ECategoria.ViajesYPaseo, Producto.EMedida.Unidades, 50);
            

            //Perros
            Producto p16 = new Producto("Alimento", "Generico", 325, Producto.EAnimal.Perros, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, 50);
            Producto p17 = new Producto("Alimento", "Generico", 1200, Producto.EAnimal.Perros, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, 50);
            Producto p18 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perros, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, 50);
            Producto p19 = new Producto("Comida Seca Adulto", "Generico", 524, Producto.EAnimal.Perros, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, 50);
            Producto p20 = new Producto("Comida Seca Adulto", "Generico", 524, Producto.EAnimal.Perros, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, 50);
            Producto p21 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perros, Producto.ECategoria.EstéticaEHigiene, Producto.EMedida.Unidades, 50);
            Producto p22 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perros, Producto.ECategoria.EstéticaEHigiene, Producto.EMedida.Unidades, 50);
            Producto p23 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perros, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, 50);
            Producto p24 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perros, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, 50);
            Producto p25 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perros, Producto.ECategoria.Juguetes, Producto.EMedida.Unidades, 50);
            Producto p26 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perros, Producto.ECategoria.Juguetes, Producto.EMedida.Unidades, 50);
            Producto p27 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perros, Producto.ECategoria.ViajesYPaseo, Producto.EMedida.Unidades, 50);
            Producto p28 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perros, Producto.ECategoria.ViajesYPaseo, Producto.EMedida.Unidades, 50);
      

            //Aves
            Producto p31 = new Producto("Comedero", "Generico", 325, Producto.EAnimal.Aves, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, 50);
            Producto p32 = new Producto("Jaula", "MetalicBirds", 1200, Producto.EAnimal.Aves, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, 50);
            Producto p33 = new Producto("Pretal", "DogHola", 524, Producto.EAnimal.Aves, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, 50);
            Producto p34 = new Producto("Comida Seca Adulto", "DogChow", 524, Producto.EAnimal.Aves, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, 50);
            Producto p35 = new Producto("Comida Seca Adulto", "DogHola", 524, Producto.EAnimal.Aves, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, 50);

           

            //Peces
            Producto p38 = new Producto("Comedero", "Generico", 325, Producto.EAnimal.Gatos, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, 50);
            Producto p39 = new Producto("Follage Plastico", "Generico", 1200, Producto.EAnimal.Peces, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, 50);
            Producto p40 = new Producto("Jaula", "Generico", 524, Producto.EAnimal.Peces, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, 50);
            Producto p41 = new Producto("Comida Pez Dorado", "Generico", 524, Producto.EAnimal.Peces, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, 50);
            Producto p42 = new Producto("Comida Starfish", "Generico", 524, Producto.EAnimal.Peces, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, 50);
            Producto p43 = new Producto("Pecera", "Generico", 524, Producto.EAnimal.Peces, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, 50);
            Producto p44 = new Producto("Comida CatFish", "Generico", 524, Producto.EAnimal.Peces, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, 50);
           

            //Roedores
            Producto p45 = new Producto("Comedero", "Generico", 325, Producto.EAnimal.Roedores, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, 50);
            Producto p46 = new Producto("Rueda Ejercicio", "Generico", 1200, Producto.EAnimal.Roedores, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, 50);
            Producto p47 = new Producto("Cueva", "Generico", 524, Producto.EAnimal.Roedores, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, 50);
            Producto p68 = new Producto("Alimento Cobayo", "Generico", 524, Producto.EAnimal.Roedores, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, 50);
            Producto p49 = new Producto("Heno", "Generico", 524, Producto.EAnimal.Roedores, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, 50);
            Producto p50 = new Producto("Jaula acondicionada", "Generico", 524, Producto.EAnimal.Roedores, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, 50);
          
            

            //Reptiles
            Producto p53 = new Producto("Comedero", "Generico", 325, Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, 50);
            Producto p54 = new Producto("Follage decorativo", "Generico", 1200, Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, 50);
            Producto p55 = new Producto("Terrario acondicionado", "Generico", 524, Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, 50);
            Producto p56= new Producto("Tenebrios", "Generico", 524, Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, 50);
            Producto p57 = new Producto("Zophobas Seca Adulto", "Generico", 524, Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, 50);
            Producto p58 = new Producto("Tortuguero", "Generico", 524, Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, 50);
        
           

            stock.Add(p1);
            stock.Add(p2);
            stock.Add(p3);
            stock.Add(p4);
            stock.Add(p5);
            stock.Add(p6);
            stock.Add(p7);
            stock.Add(p8);
            stock.Add(p9);
            stock.Add(p10);
            stock.Add(p11);
            stock.Add(p12);
            stock.Add(p13);
            stock.Add(p16);
            stock.Add(p17);
            stock.Add(p18);
            stock.Add(p19);
            stock.Add(p20);
            stock.Add(p21);
            stock.Add(p22);
            stock.Add(p23);
            stock.Add(p24);
            stock.Add(p25);
            stock.Add(p26);
            stock.Add(p27);
            stock.Add(p28);
            stock.Add(p31);
            stock.Add(p32);
            stock.Add(p33);
            stock.Add(p34);
            stock.Add(p35);
            stock.Add(p38);
            stock.Add(p39);
            stock.Add(p40);
            stock.Add(p41);
            stock.Add(p42);
            stock.Add(p43);
            stock.Add(p44);
            stock.Add(p45);
            stock.Add(p46);
            stock.Add(p47);
            stock.Add(p49);
            stock.Add(p50);
            stock.Add(p53);
            stock.Add(p54);
            stock.Add(p55);
            stock.Add(p56);
            stock.Add(p57);
            stock.Add(p58);
            


        }
        public static void CargarClientes()
        {
            List<Producto> prodc1 = new List<Producto>();
            Producto p1 = new Producto("Comedero", "Generico", 325, Producto.EAnimal.Aves, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, 2);
            Producto p2 = new Producto("Jaula", "MetalicBirds", 1200, Producto.EAnimal.Aves, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, 1);
            Producto p3 = new Producto("Pretal", "DogHola", 524, Producto.EAnimal.Aves, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, 1);
            prodc1.Add(p1);
            prodc1.Add(p2);
            prodc1.Add(p3);


            Cliente c1 = new Cliente("Marta", "Mendoza", 33333333,prodc1, 20000);

            Cliente c2 = new Cliente("Diego", "Berne", 99999999,prodc1, 2000);

            Cliente c3 = new Cliente("Franco", "Morla", 77777777,prodc1, 20000);

            Cliente c4 = new Cliente("Lisa", "Prado", 33333333,prodc1, 20000);

            clientes.Add(c1);
            clientes.Add(c2);
            clientes.Add(c3);
            clientes.Add(c3);

        }

      

        public static Empleado LogIn(string usuario, string clave)
        {

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(clave))
            {
                foreach (Empleado auxEmpleado in personas)
                {

                    if (auxEmpleado.Usuario.Trim().ToLower() == usuario.Trim().ToLower() &&
                         auxEmpleado.Clave.Trim().ToLower() == clave.Trim().ToLower())
                    {
                        return auxEmpleado;

                    }

                }
            }
            return null;
        }

        public static bool AgregarProducto()
        {
            return false;
        }

        public static void cargarProductos()
        {

        }

        public static Producto BuscarProductoPorId(int id)
        {
            for (int i = 0; i < Tienda.Stock.Count; i++)
            {
                if (id == Tienda.Stock[i].Id)
                    return Tienda.Stock[i];

            }
            return null;
        }
        public static Cliente BuscarClientePorId(int id)
        {
            for (int i = 0; i < Tienda.Clientes.Count; i++)
            {
                if (id == Tienda.Clientes[i].Id)
                    return Tienda.Clientes[i];

            }
            return null;
        }
      

        public static List<Cliente> BuscarCliente(string aux)
        {
            List<Cliente> clientesAux = new List<Cliente>();
           
            for (int i = 0; i < clientes.Count; i++)
            {
                if (aux == clientes[i].Nombre)
                    clientesAux.Add(clientes[i]);

                if (aux == clientes[i].Apellido)
                    clientesAux.Add(clientes[i]);

            }
            return clientesAux;
        }

        public static float SumarPrecioArticulosAgregados(List<Producto> auxLista)
        {
            float acumulado = 0;
            for (int i = 0; i < auxLista.Count; i++)
            {
                acumulado += auxLista[i].Precio;
            }
            return acumulado;
        }

        public static List<Cliente> BuscarCliente(int aux)
        {
            List<Cliente> clientesAux = new List<Cliente>();

            for (int i = 0; i < clientes.Count; i++)
            {
                if (aux == clientes[i].Id)
                    clientesAux.Add(clientes[i]);

                if (aux == clientes[i].Dni)
                    clientesAux.Add(clientes[i]);

            }
            return clientesAux;
        }

        public static bool BuscarPorAnimalYCategoria(int id)
        {
            return false;
        }


        public static bool Vender(int id, int cantidad)
        {
            return false;
        }

        public static bool ComprarReponer(Producto p)
        {
            return false;
        }

        public static bool VerStock()
        {
            return false;
        }

    }
}
