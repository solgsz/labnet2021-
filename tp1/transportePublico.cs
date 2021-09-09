using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public abstract class transportePublico
    {
        public int pasajeros { get; set; }

        public transportePublico(int capacidad)
        {
            pasajeros = capacidad;
        }
        public void avanzar()
        {

        }
        public void detenerse()
        {

        }

    }
}
