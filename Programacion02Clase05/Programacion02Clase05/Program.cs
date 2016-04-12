using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamiento unEstacionamiento = new Estacionamiento("Pepito", 3);
            Auto autoUno = new Auto("AAA001");
            Auto autoDos = new Auto("AAA001");
            Auto autoTres = new Auto("CCC003");
            Auto autoCuatro = new Auto("DDD004");

            unEstacionamiento.estacionarAuto(autoUno);
            unEstacionamiento.estacionarAuto(autoDos);
            unEstacionamiento.estacionarAuto(autoTres);
            unEstacionamiento.estacionarAuto(autoCuatro);

            //unEstacionamiento.estacionarAuto(new Auto("AAA001"));
            //unEstacionamiento.estacionarAuto(new Auto("BBB002"));
            //unEstacionamiento.estacionarAuto(new Auto("CCC003"));
            //unEstacionamiento.estacionarAuto(new Auto("DDD004"));

            

            Console.ReadKey();

        }
    }
}
