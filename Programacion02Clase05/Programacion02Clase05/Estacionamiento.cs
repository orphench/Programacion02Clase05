using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase05
{
    class Estacionamiento
    {
        public string nombreDelEstacionamiento;
        public Auto[] listadoDeAutos; //Array de objetos
        public int cantidadDeCocheras;

        public Estacionamiento(string dueño, int cantidad)
        {
            this.nombreDelEstacionamiento = dueño;
            this.cantidadDeCocheras = cantidad;
            this.listadoDeAutos = new Auto[cantidad];
        }

        public bool estacionarAuto(Auto unAuto)
        {
            bool lleno = false;

            if (this != unAuto)
            {
                for (int i = 0; i < this.listadoDeAutos.GetLength(0); i++)//this.listadoDeAutos.cantidadDeCocheras
                {

                    if (this.listadoDeAutos.GetValue(i) == null)//this.listadoDeAutos.GetValue(i) == null o listadoDeAutos(i) == (object)null
                    {
                        this.listadoDeAutos[i] = unAuto;
                        //Console.WriteLine("Estaciono {0}", unAuto.Patente);
                        break;
                    }
                    if (i == this.cantidadDeCocheras - 1)
                    {
                        lleno = true;
                        //Console.WriteLine("La cochera esta llena");
                    }
                }
            }

            else 
            {
                //El auto ya esta
            }
            return lleno;
        }

        public static bool operator ==(Estacionamiento unEstacionamiento, Auto unAuto)
        {
            bool respuesta = false;

            foreach (Auto autoRecorriendo in unEstacionamiento.listadoDeAutos)
            {
                if ((object)autoRecorriendo != null && autoRecorriendo == unAuto)//cortocircuito
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }

        public static bool operator !=(Estacionamiento unEstacionamineto, Auto unAuto)
        {
            return !(unEstacionamineto == unAuto);
        }
        
    }  
}
