using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoClassLibrary
{
    public class EscalerasYSerpientesBasico
    {
        List<Jugador> jugadores=new List<Jugador>();

        public EscalerasYSerpientesBasico(string nombre, int cantJugadores) 
        {
            jugadores.Add(new Jugador(nombre));
            for (int n = 1; n < cantJugadores; n++)
            {
                jugadores.Add(new Jugador("Maquina" + 1));
            }
        }
        public EscalerasYSerpientesBasico(int cantJugadores):this("Maquina"+0,cantJugadores) { }

        virtual public void Jugar() { }

        public bool HaFinalizado()
        {
            return false;
        }
    }
}
