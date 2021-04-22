using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TresEnRaya
{
    class Posicion
    {
        private int jugador;
        private PictureBox pic;

        public Posicion()
        {
            this.jugador = 0;
        }

        public int Jugador { get => jugador; set => jugador = value; }
        public PictureBox Pic { get => pic; set => pic = value; }

        public void Reiniciar()
        {
            this.jugador = 0;
            pic.BackgroundImage = null;
        }
    }
}

