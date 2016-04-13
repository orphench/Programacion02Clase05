using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase05
{
    class Auto
    {
        private string Patente;

        public Auto(string patente) 
        {
            this.Patente = patente;
        }
        
        public static bool operator ==(Auto autoUno, Auto autoDos)
        {
            bool comparacion = autoUno.Patente == autoDos.Patente;

            return comparacion;
        }

        public static bool operator !=(Auto autoUno, Auto autoDos)
        {
            return !(autoUno == autoDos);
        }

        
    }
}
