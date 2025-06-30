using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RepasoParcial2
{
    internal class Servicio
    {
        private int[] expedientes = new int[100];
        private int[] dnis = new int[100];
        private double[] montos = new double[100];
        private int contador = 0;

        public void RegistrarExpediente(int expediente, int dni, double monto)
        {
            expedientes[contador] = expediente;
            dnis[contador] = dni;
            montos[contador] = monto;
            contador++;
        }

        public void VerExpediente(int i, out int nro, out int dni, out double monto) {

            nro = 0;
            dni = 0;
            monto = 0;

            if (i >= 0 && i < contador)
            {
                nro = expedientes[i];
                dni = dnis[i];
                monto = montos[i];
            }
            
        }

        public void OrdenarExpedientes()
        {
            int xExpediente;
            int xDni;
            double xMonto;
            for (int i = 0; i < contador-1; i++) { 
                for (int j = i+1; j < contador; j++)
                {
                    if (montos[i] < montos[j])
                    {
                        xMonto = montos[i];
                        montos[i] = montos[j];
                        montos[j] = xMonto;

                        xDni = dnis[i];
                        dnis[i] = dnis[j];
                        dnis[j] = xDni;

                        xExpediente = expedientes[i];
                        expedientes[i] = expedientes[j];
                        expedientes[j] = xExpediente;
                    }
                }
            }
        }

        public double CalcularMontoPromedio()
        {
            
            double acumulador = 0;
            for (int i = 0; i < contador; i++) {
                acumulador += montos[i];
            }
            double promedio = acumulador / contador;

            return promedio;
        }

        public int[] MayoresAlPromedio(out int cantidad)
        {
            int[] indxMayores = new int[contador];
            double promedio = CalcularMontoPromedio();
            cantidad = 0;

            for (int i = 0; i < contador; i++)
            {
                if (montos[i] > promedio)
                {
                    indxMayores[cantidad] = i;
                    cantidad++;
                }
            }
            return indxMayores;
        }

        public int VerContador()
        {
            return contador;
        }

        public int[] VerExpedientesPorDNI(int dni, out int cantidad)
        {
            cantidad = 0;
            int[] iMayores = new int[contador];
            for (int i = 0; i < contador;i++)
            {
                if (dnis[i] == dni)
                {
                    iMayores[cantidad] = i;
                    cantidad++;
                }
            }
            return iMayores;
        }

        public int VerExpedientePorNumero(int numero)
        {
            int i = 0;
            int pos = -1;
            while (pos ==-1 && i < contador)
            {
                if (expedientes[i] == numero)
                {
                    pos = i;
                }
                i++;
            }
            return pos;
        }


    }
}
