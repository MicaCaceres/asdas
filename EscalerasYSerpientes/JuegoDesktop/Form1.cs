using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using JuegoClassLibrary;
using ObserverLibClass;

namespace JuegoDesktop
{
    public partial class Form1 : Form, IObservador
    {
        EscalerasYSerpientesBasico juego;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDatos fDatos = new FormDatos();

            if (fDatos.ShowDialog() == DialogResult.OK)
            {
                juego = new EscalerasYSerpientesBasico("juanito", 30);
            }

            fDatos.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (juego.HaFinalizado() == false)
            {
                juego.Jugar();

                /*
                for (int n = 0; n<juego.CantidadJugadores; n++)
                {
                    Jugador jug = juego.VerJugador(n);
                    listBox1.Items.Add(jug);
                }
                */
            }
        }

        void IObservador.NotificarCambioPosicion(Sujeto sender)
        {
            listBox1.Items.Add(sender);
        }
    }
}
