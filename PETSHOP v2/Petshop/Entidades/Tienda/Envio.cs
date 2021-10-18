using System.Collections.Generic;

namespace Entidades
{
    public static class Envio
    {
        public enum EFormaEnvio
        {
            moto,
            miniflete
        }

        public static float distancia;
        public static float peso;
        public static EFormaEnvio formaEnvio;



        public static EFormaEnvio CalcularFormadeEnvio(Cliente auxCliente, List<Producto> auxProductos)
        {
            EFormaEnvio formaDeEnvio = EFormaEnvio.moto;
            float acumulado;

            acumulado = auxCliente.Distancia + CalcularPeso(auxProductos);

            if (acumulado > 5)
            {
                formaDeEnvio = Envio.EFormaEnvio.miniflete;
            }
            else
            {
                formaDeEnvio = Envio.EFormaEnvio.moto;
            }

                return formaDeEnvio;
        }

        public static float CalcularPeso(List<Producto> auxProductos)
        {
            float acumulado = 0;

            for (int i = 0; i < auxProductos.Count; i++)
            {
                acumulado += auxProductos[i].Cantidad;
            }
            return acumulado;
        }

    }
}
