using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TresEnRaya
{
    public partial class Form1 : Form
    {
        int turno;
        Image cruz = Properties.Resources.cruz;
        Image circulo = Properties.Resources.circulo;
        public Form1()
        {
            InitializeComponent();
        }

        private void cerrarbto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarBTO_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void B3_Click(object sender, EventArgs e)
        {

            if (turno == 1)
            {
                B3.Image = circulo;
                turno = 2;


            }
            else
            {
                B3.Image = cruz;
                turno = 1;

            }
            comp();
            B3.Enabled = false;

        }

        private void A1_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                A1.Image = circulo;
                turno = 2;

            }
            else
            {
                A1.Image = cruz;
                turno = 1;


            }
            comp();
            A1.Enabled = false;

        }

        private void playBto_Click(object sender, EventArgs e)
        {
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
            string j1 = textplayer1.Text;
            string j2 = textplayer2.Text;
            if (textplayer1.Text == "" || textplayer2.Text == "")
            {
                MessageBox.Show("Debes introducir un nombre");
            }
            turno = 1;



        }

        private void textplayer1_TextChanged(object sender, EventArgs e)
        {
            turno = 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            A1.Enabled = false;
            A2.Enabled = false;
            A3.Enabled = false;
            B1.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;
            C1.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;

        }

        private void textplayer2_TextChanged(object sender, EventArgs e)
        {
            turno = 2;
        }

      

      

        private void A2_Click(object sender, EventArgs e)
        {

            if (turno == 1)
            {
                A2.Image =circulo;
                turno = 2;

            }
            else
            {
                A2.Image = cruz;
                turno = 1;

            }
            comp();
            A2.Enabled = false;
        }

        public void B2_Click(object sender, EventArgs e)
        {

            if (turno == 1)
            {
                B2.Image = circulo;
                turno = 2;

            }
            else
            {
                B2.Image = cruz;
                turno = 1;

            }
            comp();
            B2.Enabled = false;
        }

        private void C2_Click(object sender, EventArgs e)
        {

            if (turno == 1)
            {
                C2.Image = Properties.Resources.circulo;
                turno = 2;

            }
            else
            {
                C2.Image = Properties.Resources.cruz;
                turno = 1;

            }
            comp();
            C2.Enabled = false;
        }

        private void A3_Click(object sender, EventArgs e)
        {

            if (turno == 1)
            {
                A3.Image = circulo;
                turno = 2;

            }
            else
            {
                A3.Image = cruz;
                turno = 1;

            }
            comp();
            A3.Enabled = false;
        }

        private void C3_Click(object sender, EventArgs e)
        {

            if (turno == 1)
            {
                C3.Image = circulo;
                turno = 2;

            }
            else
            {
                C3.Image =cruz;
                turno = 1;

            }
            comp();
            C3.Enabled = false;
        }
        public void reini()
        {
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
            A1.Image = null;
            A2.Image = null;
            A3.Image = null;
            B1.Image = null;
            B2.Image = null;
            B3.Image = null;
            C1.Image = null;
            C2.Image = null;
            C3.Image = null;
        }
        public void ganacir()
        {
           
                SoundPlayer Player = new SoundPlayer();
                Player.SoundLocation = ".\\ganar.wav";
                Player.Play();
                MessageBox.Show("GANA CIRCULO");

           
        }
        public void ganacruz()
          {
           
                SoundPlayer Player = new SoundPlayer();
        Player.SoundLocation = ".\\ganar.wav";
                Player.Play();
                MessageBox.Show("GANA CRUZ");

           
            }   


    private void comp()
        {
           if(A1.Image == B1.Image && B1.Image == C1.Image && A1.Image != null && B1.Image != null && C1.Image != null )
            {
                if(A1.Image == circulo || B1.Image == circulo || C1.Image==circulo)
                {
                    ganacir();

                }
                else
                {
                    ganacruz();
                }
                reini();
            }
            if (A2.Image == B2.Image && B2.Image == C2.Image && A2.Image != null && B2.Image != null && C2.Image != null)
            {
                if (A2.Image == circulo || B2.Image == circulo || C2.Image == circulo)
                {
                    ganacir();

                }
                else
                    {
                    ganacruz();
                }
                reini();
            }
            if (A3.Image == B3.Image && B3.Image == C3.Image && A3.Image != null && B3.Image != null && C3.Image != null)
            {

                if (A3.Image == circulo || B3.Image == circulo || C3.Image == circulo)
                {
                    ganacir();

                }
                else
                {
                    ganacruz();
                }
                reini();
            }
            if (A1.Image == A2.Image && A2.Image == A3.Image && A1.Image != null && A2.Image != null && A3.Image != null)
            {
                if (A1.Image == circulo || A2.Image == circulo || A3.Image == circulo)
                {
                    ganacir();

                }
                else
                {
                    ganacruz();
                }
                reini();
            }
            if (B1.Image == B2.Image && B2.Image == B3.Image && B1.Image != null && B2.Image != null && B3.Image != null)
            {
                if (B1.Image == circulo || B2.Image == circulo || B3.Image == circulo)
                {
                    ganacir();

                }
                else
                {
                    ganacruz();
                }
                reini(); ;
            }
            if (C1.Image == C2.Image && C2.Image == C3.Image && C1.Image != null && C2.Image !=null && C3.Image !=null)
            {
                if (C1.Image == circulo || C2.Image == circulo || C3.Image == circulo)
                {
                    ganacir();

                }
                else
                {
                    ganacruz();
                }
                reini();
            }
            if (A1.Image == B2.Image && B2.Image == C3.Image && A1.Image != null && B2.Image != null && C3.Image != null)
            {
                if (A1.Image == circulo || B2.Image == circulo || C3.Image == circulo)
                {
                    ganacir();

                }
                else
                {
                    ganacruz();
                }
                reini();
            }
            if (C1.Image == B2.Image && B2.Image == A3.Image && C1.Image != null && B2.Image != null && A3.Image != null)
            {
                if (C1.Image == circulo || B2.Image == circulo || A3.Image == circulo)
                {
                    ganacir();

                }
                else
                {
                    ganacruz();
                }
                reini();
            }
            if (A1.Image != null && B1.Image != null && C1.Image != null && A2.Image != null && B2.Image != null && C2.Image != null && A3.Image != null && B3.Image != null && C3.Image != null)
            {
                MessageBox.Show("EMPATE");
                reini();
            }
        }
            
               

    private void tres_Raya_Click(object sender, EventArgs e)
        {

        }

        private void B1_Click_1(object sender, EventArgs e)
        {

            if (turno == 1)
            {
                B1.Image = circulo;
                turno = 2;

            }
            else
            {
                B1.Image = cruz;
                turno = 1;


            }
            comp();
            B1.Enabled = false;
        }

        private void C1_Click_1(object sender, EventArgs e)
        {

            if (turno == 1)
            {
                C1.Image =circulo;
                turno = 2;

            }
            else
            {
                C1.Image = cruz;
                turno = 1;
            }
            comp();
            C1.Enabled = false;
        }
    }
}

