using System.Collections.Generic;

namespace Entidades
{
    public static class Tienda
    {
        public static List<Empleado> empleados;
        public static List<Producto> ProductosDisponibles;
        public static List<Producto> stock;
        public static List<Producto> catalogo;
        public static List<Producto> compraActualDelClienteSeleccionado;
        public static List<Cliente> clientes;
        public static float saldoTienda;


        static Tienda()
        {
            empleados = new List<Empleado>();
            ProductosDisponibles = new List<Producto>();
            catalogo = new List<Producto>();
            clientes = new List<Cliente>();
            compraActualDelClienteSeleccionado = new List<Producto>();
            stock = new List<Producto>();
            saldoTienda = 10000000;


            CargarEmpleadosActuales();
            CargarClientes();
            CargarProducto();
        }


        public static List<Cliente> Clientes
        {
            get { return clientes; }

        }
        public static List<Producto> Stock
        {
            get { return ProductosDisponibles; }

        }

        public static List<Empleado> Empleados
        {
            get { return empleados; }

        }


        public static List<Producto> CompraActualDelClienteSeleccionado
        {
            get { return compraActualDelClienteSeleccionado; }

        }


        public static bool CargarEmpleados(Empleado p)
        {

            foreach (Empleado item in empleados)
            {
                if (item != p)
                {
                    empleados.Add(p);
                    return true;
                }
            }
            return false;
        }

        public static void SumarProductosDeEsteRubroAlCarrito(List<Producto> auxListaAAgregarCarrito)
        {
            foreach (Producto item in auxListaAAgregarCarrito)
            {
                compraActualDelClienteSeleccionado.Add(item);
            }
        }

        public static void ComprarStock(List<Producto> auxListaAAgregarCarrito)
        {
            foreach (Producto item in auxListaAAgregarCarrito)
            {
                stock.Add(item);
            }
        }

        public static void CargarEmpleadosActuales()
        {
            Empleado e1 = new Empleado("María", "Perez", 33333333, 90000, "maria", "maria123");
            Empleado e2 = new Empleado("Pedro", "Aldobar", 33333334, 90000, "pedro", "pedro123");

            Administrador a1 = new Administrador("Ian", "Del Rio", 33333335, 90000, "ian", "ian123");

            empleados.Add(e1);
            empleados.Add(e2);
            empleados.Add(a1);
        }

        public static void CargarProducto()
        {
            //Gatos
            Producto p1 = new Producto("Alimento ", "Purina", 1500, Producto.EAnimal.Gato, Producto.ECategoria.Alimentos, Producto.EMedida.Kilos,
                "Alimento rico en proteína animal de alto valor biológico, contiene minerales como calcio, fósforo, potasio y hierro, vitaminas A, D y E, fibras y ácidos grasos esenciales." +
                "Se puede almacenar por mucho más tiempo sin que se deteriore, y evita la aparición de hongos o bacterias. Además, este tipo de alimento ayuda a eliminar el sarro y a retrasar " +
                "la formación de la placa dental con el proceso de masticación y trituración.",15);
            Producto p2 = new Producto("Alimento ", "CatChow", 1200, Producto.EAnimal.Gato, Producto.ECategoria.Alimentos, Producto.EMedida.Kilos,
                "Alimento rico en proteína animal de alto valor biológico, contiene minerales como calcio, fósforo, potasio y hierro, vitaminas A, D y E, fibras y ácidos grasos esenciales.",2);
            Producto p3 = new Producto("Alimento", "Agility", 1100, Producto.EAnimal.Gato, Producto.ECategoria.Alimentos, Producto.EMedida.Kilos,
                "Alimento rico en proteína animal de alto valor biológico, contiene minerales como calcio, fósforo, potasio y hierro, vitaminas A, D y E, fibras y ácidos grasos esenciales.",15);
            Producto p4 = new Producto("Comedero", "Generico", 524, Producto.EAnimal.Gato, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, "");
            Producto p5 = new Producto("Chaleco Térmico", "Generico", 524, Producto.EAnimal.Gato, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, "");
            Producto p6 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Gato, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, "");
            Producto p7 = new Producto("Pala", "Generico", 524, Producto.EAnimal.Gato, Producto.ECategoria.EstéticaEHigiene, Producto.EMedida.Unidades, "");
            Producto p8 = new Producto("Piedras", "Generico", 524, Producto.EAnimal.Gato, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, "");
            Producto p9 = new Producto("Cama Almohadón", "Generico", 524, Producto.EAnimal.Gato, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, "");
            Producto p10 = new Producto("Raton mecánico", "Generico", 524, Producto.EAnimal.Gato, Producto.ECategoria.Juguetes, Producto.EMedida.Unidades, "");
            Producto p11 = new Producto("Caña Pescar", "Generico", 524, Producto.EAnimal.Gato, Producto.ECategoria.Juguetes, Producto.EMedida.Unidades, "");
            Producto p12 = new Producto("Jaula Viaje", "Generico", 524, Producto.EAnimal.Gato, Producto.ECategoria.ViajesYPaseo, Producto.EMedida.Unidades, "");
            Producto p13 = new Producto("Bolso Viaje", "DogHoGenericola", 524, Producto.EAnimal.Gato, Producto.ECategoria.ViajesYPaseo, Producto.EMedida.Unidades, "");


            //Perros
            Producto p16 = new Producto("Alimento", "Generico", 325, Producto.EAnimal.Perro, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, "");
            Producto p17 = new Producto("Alimento", "Generico", 1200, Producto.EAnimal.Perro, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, "");
            Producto p18 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perro, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, "");
            Producto p19 = new Producto("Comida Seca Adulto", "Generico", 524, Producto.EAnimal.Perro, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, "");
            Producto p20 = new Producto("Comida Seca Adulto", "Generico", 524, Producto.EAnimal.Perro, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, "");
            Producto p21 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perro, Producto.ECategoria.EstéticaEHigiene, Producto.EMedida.Unidades, "");
            Producto p22 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perro, Producto.ECategoria.EstéticaEHigiene, Producto.EMedida.Unidades, "");
            Producto p23 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perro, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, "");
            Producto p24 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perro, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, "");
            Producto p25 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perro, Producto.ECategoria.Juguetes, Producto.EMedida.Unidades, "");
            Producto p26 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perro, Producto.ECategoria.Juguetes, Producto.EMedida.Unidades, "");
            Producto p27 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perro, Producto.ECategoria.ViajesYPaseo, Producto.EMedida.Unidades, "");
            Producto p28 = new Producto("Pretal", "Generico", 524, Producto.EAnimal.Perro, Producto.ECategoria.ViajesYPaseo, Producto.EMedida.Unidades, "");


            //Aves
            Producto p31 = new Producto("Comedero", "Generico", 325, Producto.EAnimal.Ave, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, "");
            Producto p32 = new Producto("Jaula", "MetalicBirds", 1200, Producto.EAnimal.Ave, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, "");
            Producto p33 = new Producto("Pretal", "DogHola", 524, Producto.EAnimal.Ave, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, "");
            Producto p34 = new Producto("Comida Seca Adulto", "DogChow", 524, Producto.EAnimal.Ave, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, "");
            Producto p35 = new Producto("Comida Seca Adulto", "DogHola", 524, Producto.EAnimal.Ave, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, "");



            //Peces
            Producto p38 = new Producto("Comedero", "Generico", 325, Producto.EAnimal.Gato, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, "");
            Producto p39 = new Producto("Follage Plastico", "Generico", 1200, Producto.EAnimal.Pez, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, "");
            Producto p40 = new Producto("Jaula", "Generico", 524, Producto.EAnimal.Pez, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, "");
            Producto p41 = new Producto("Comida Pez Dorado", "Generico", 524, Producto.EAnimal.Pez, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, "");
            Producto p42 = new Producto("Comida Starfish", "Generico", 524, Producto.EAnimal.Pez, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, "");
            Producto p43 = new Producto("Pecera", "Generico", 524, Producto.EAnimal.Pez, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, "");
            Producto p44 = new Producto("Comida CatFish", "Generico", 524, Producto.EAnimal.Pez, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, "");


            //Roedores
            Producto p45 = new Producto("Comedero", "Generico", 325, Producto.EAnimal.Roedor, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, "");
            Producto p46 = new Producto("Rueda Ejercicio", "Generico", 1200, Producto.EAnimal.Roedor, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, "");
            Producto p47 = new Producto("Cueva", "Generico", 524, Producto.EAnimal.Roedor, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, "");
            Producto p68 = new Producto("Alimento Cobayo", "Generico", 524, Producto.EAnimal.Roedor, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, "");
            Producto p49 = new Producto("Heno", "Generico", 524, Producto.EAnimal.Roedor, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, "");
            Producto p50 = new Producto("Jaula acondicionada", "Generico", 524, Producto.EAnimal.Roedor, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, "");



            //Reptiles
            Producto p53 = new Producto("Comedero", "Generico", 325, Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, "");
            Producto p54 = new Producto("Follage decorativo", "Generico", 1200, Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, "");
            Producto p55 = new Producto("Terrario acondicionado", "Generico", 524, Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, "");
            Producto p56 = new Producto("Tenebrios", "Generico", 524, Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, "");
            Producto p57 = new Producto("Zophobas Seca Adulto", "Generico", 524, Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.Alimentos, Producto.EMedida.Unidades, "");
            Producto p58 = new Producto("Tortuguero", "Generico", 524, Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, "");



            ProductosDisponibles.Add(p1);
            ProductosDisponibles.Add(p2);
            ProductosDisponibles.Add(p3);
            ProductosDisponibles.Add(p4);
            ProductosDisponibles.Add(p5);
            ProductosDisponibles.Add(p6);
            ProductosDisponibles.Add(p7);
            ProductosDisponibles.Add(p8);
            ProductosDisponibles.Add(p9);
            ProductosDisponibles.Add(p10);
            ProductosDisponibles.Add(p11);
            ProductosDisponibles.Add(p12);
            ProductosDisponibles.Add(p13);
            ProductosDisponibles.Add(p16);
            ProductosDisponibles.Add(p17);
            ProductosDisponibles.Add(p18);
            ProductosDisponibles.Add(p19);
            ProductosDisponibles.Add(p20);
            ProductosDisponibles.Add(p21);
            ProductosDisponibles.Add(p22);
            ProductosDisponibles.Add(p23);
            ProductosDisponibles.Add(p24);
            ProductosDisponibles.Add(p25);
            ProductosDisponibles.Add(p26);
            ProductosDisponibles.Add(p27);
            ProductosDisponibles.Add(p28);
            ProductosDisponibles.Add(p31);
            ProductosDisponibles.Add(p32);
            ProductosDisponibles.Add(p33);
            ProductosDisponibles.Add(p34);
            ProductosDisponibles.Add(p35);
            ProductosDisponibles.Add(p38);
            ProductosDisponibles.Add(p39);
            ProductosDisponibles.Add(p40);
            ProductosDisponibles.Add(p41);
            ProductosDisponibles.Add(p42);
            ProductosDisponibles.Add(p43);
            ProductosDisponibles.Add(p44);
            ProductosDisponibles.Add(p45);
            ProductosDisponibles.Add(p46);
            ProductosDisponibles.Add(p47);
            ProductosDisponibles.Add(p49);
            ProductosDisponibles.Add(p50);
            ProductosDisponibles.Add(p53);
            ProductosDisponibles.Add(p54);
            ProductosDisponibles.Add(p55);
            ProductosDisponibles.Add(p56);
            ProductosDisponibles.Add(p57);
            ProductosDisponibles.Add(p58);



        }


        public static void CargarEnSistemaStockTienda()
        {
            
        }
        public static void CargarClientes()
        {
            List<Producto> prodc1 = new List<Producto>();
            Producto p1 = new Producto("Comedero", "Generico", 325, Producto.EAnimal.Ave, Producto.ECategoria.BebederosYComederos, Producto.EMedida.Unidades, "");
            Producto p2 = new Producto("Jaula", "MetalicBirds", 1200, Producto.EAnimal.Ave, Producto.ECategoria.Accesorios, Producto.EMedida.Unidades, "");
            Producto p3 = new Producto("Pretal", "DogHola", 524, Producto.EAnimal.Ave, Producto.ECategoria.HogarYCamas, Producto.EMedida.Unidades, "");
            prodc1.Add(p1);
            prodc1.Add(p2);
            prodc1.Add(p3);


            Cliente c1 = new Cliente("Marta", "Mendoza", 33860614, 20000, prodc1,"Av. Corriente 2025",2);

            Cliente c3 = new Cliente("Franco", "Morla", 7241432, 20000, prodc1,"Av. San Martin 1280",1);

            Cliente c4 = new Cliente("Lisa", "Prado", 12111524, 20000,prodc1,"Pedraza 327",3);

            clientes.Add(c1);
            clientes.Add(c3);
            clientes.Add(c4);

        }

        public static bool ValidarDni(string cadena)
        {
            if(cadena.Length < 9)
            {
                if(ValidarCadenaNumerica(cadena))
                    return true;
            }
            return false;
        }
        public static bool ValidarCadenaNumerica(string cadena) 
        { 
            foreach (char auxChar in cadena) 
            { 
                if (char.IsDigit(auxChar)) 
                    return true; 
            } 
            return false; 
        }

        



        public static Empleado LogIn(string usuario, string clave)
        {

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(clave))
            {
                foreach (Empleado auxEmpleado in empleados)
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

        public static List<Producto> BuscarProducto(string aux)
        {
            List<Producto> listaAux = new List<Producto>();
            for (int i = 0; i < Tienda.ProductosDisponibles.Count; i++)
            {
                if (Tienda.Stock[i].Nombre.ToString().Trim().ToLower() == aux)
                {
                    listaAux.Add(Tienda.Stock[i]);
                }
                if (Tienda.Stock[i].Marca.ToString().Trim().ToLower() == aux)
                {
                    listaAux.Add(Tienda.Stock[i]);

                }
                if (aux == Tienda.Stock[i].Animal.ToString().Trim().ToLower())
                {
                    listaAux.Add(Tienda.Stock[i]);
                }
            }
            return listaAux;
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
                if (aux == clientes[i].Nombre.ToString().Trim().ToLower())
                {
                    clientesAux.Add(clientes[i]);
                    break;
                }

                if (aux == clientes[i].Apellido.ToString().Trim().ToLower())
                {
                    clientesAux.Add(clientes[i]);
                    break;
                }

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

        public static float RestarPrecioArticuloBorrado(float auxTotalActual, int producto)
        {
            return auxTotalActual - producto;
        }

        public static float RestarSumaDeSaldoTienda(float auxTotalaRestar)
        {
            float saldoTiendaActualizado;
            saldoTiendaActualizado = Tienda.saldoTienda - auxTotalaRestar;
            Tienda.saldoTienda = saldoTiendaActualizado;
            return saldoTiendaActualizado;

        }

        public static float SumarADeSaldoTienda(float auxTotalaRestar)
        {
            float saldoTiendaActualizado;
            saldoTiendaActualizado = Tienda.saldoTienda + auxTotalaRestar;
            Tienda.saldoTienda = saldoTiendaActualizado;
            return saldoTiendaActualizado;

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

        public static bool AgregarEmpleado(Empleado empleado)
        {
            for (int i = 0; i < empleados.Count; i++)
            {
                if (empleado != empleados[i])
                {
                    empleados.Add(empleado);
                    return true;
                }
            }
            return false;
        }

        public static bool AgregarCliente(Cliente cliente)
        {
            for (int i = 0; i < empleados.Count; i++)
            {
                if (cliente != clientes[i])
                {
                    clientes.Add(cliente);
                    return true;
                }
            }
            return false;
        }
    }
}
