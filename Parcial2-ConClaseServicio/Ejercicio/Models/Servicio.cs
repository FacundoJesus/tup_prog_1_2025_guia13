using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Models
{
    internal class Servicio
    {
        private string[] patentes = new string[20];
        private double[] kilometros = new double[20];
        public int CantVeh { get; private set; } = 0;

        public void CrearVehiculo(string pat, double km)
        {
            patentes[CantVeh] = pat;
            kilometros[CantVeh] = km;
            CantVeh++;
        }

        public void CargarViaje(int idx, double km)
        {
            kilometros[idx] += km;
        }

        public double VerKilometraje(string pat)
        {
            double verKilometraje;

            int pos = Buscar(pat);
            if (pos != -1)
            {
                verKilometraje = kilometros[pos];

            }
            else
            {
                verKilometraje = -1;
            }
            return verKilometraje;

        }

        public void Ordenar()
        {
            string xPat;
            double xKm;
            for (int i = 0; i < CantVeh - 1; i++)
            {
                for (int j = i+1;  j < CantVeh; j++) {
                    if (kilometros[i] > kilometros[j])
                    {
                        xKm = kilometros[i];
                        kilometros[i] = kilometros[j];
                        kilometros[j] = xKm;

                        xPat = patentes[i];
                        patentes[i] = patentes[j];
                        patentes[j] = xPat;
                    }
                }
            }
        }

        public int Buscar(string pat) {
            int i = 0;
            int pos = -1;
            while (i < CantVeh && pos ==-1)
            {
                if (patentes[i] == pat)
                {
                    pos = i;
                }
                i++;
            }
            return pos;
        }

        public double CalcularPromedioKMS()
        {
            double promedio = 0;
            double acum = 0;
            if (CantVeh > 0) {
                for (int i=0; i < CantVeh;i++)
                {
                    acum += kilometros[i];
                }
            }
            promedio = acum / CantVeh;
            return promedio;
        }

        public void VerVehiculo(int idx, out string patente, out double kms)
        {
            patente = "";
            kms = 0;
            if (idx >= 0 && idx < CantVeh)
            {
                patente = patentes[idx];
                kms = kilometros[idx];
            }
        }

    }
}
