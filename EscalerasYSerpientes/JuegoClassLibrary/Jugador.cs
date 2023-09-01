using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObserverLibClass;

namespace JuegoClassLibrary
{
    public class Jugador : Sujeto
    {
        public string Nombre { get; set; }

        int posicionActual;
        public int PosicionActual 
        {
            get
            {
                return posicionActual;
            }
            set
            {
                if (posicionActual != value)
                {
                    posicionActual = value;
                    NotificarATodosSobrePosicion();
                }
            }
        }
        public int PosicionAnterior { get; private set; }
        public int Avance { get; private set; }
        public bool HaLlegado { get; private set; }

        public Jugador(string nombre) 
        {
            this.Nombre = nombre;
        }

        public virtual void Mover() 
        {
            
        }

        public override string ToString()
        {
            return $"{Nombre} Movió desde {PosicionAnterior} a {PosicionActual} ({Avance})";
        }

    }
}
