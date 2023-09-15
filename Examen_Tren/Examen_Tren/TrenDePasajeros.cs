using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tren
{
    class TrenDePasajeros : TrenBase
    {
        private int estacionesRecorridas;
        private int pasajerosTransportados;

        public TrenDePasajeros(string nombre, int capacidadPasajeros, int estaciones)
            : base(nombre, 0)
        {
            this.estacionesRecorridas = 0;
            this.pasajerosTransportados = 0;
            this.CapacidadPasajeros = capacidadPasajeros;
            this.Estaciones = estaciones;
        }

        public int CapacidadPasajeros { get; private set; }
        public int Estaciones { get; private set; }

        public override int CapacidadMaxima()
        {
            return CapacidadPasajeros;
        }

        public void RegistrarArriboEstacion()
        {
            estacionesRecorridas++;
            pasajerosTransportados += pasajeros_abordo;
            ArribarEstacion();
        }

        public double PasajerosPorEstacion()
        {
            if (estacionesRecorridas == 0)
            {
                return 0;
            }
            return (double)pasajerosTransportados / estacionesRecorridas;
        }
    }
}
