using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    //Clase que contiene los metodos que se ejecutan al realizar acciones en la interfaz nuevoJuego1
    public partial class nJuego : Form
    {
        public nJuego()
        {
            InitializeComponent();
        }


        int cantidadJugadores;

        //Obtiene la cantidad de jugadores y valida el dato ingresado, lo manda a clase Amigo secreto
        public void btnCantJugadores_Click(object sender, EventArgs e)
        {
            string cantidadJ = txtCantJugadores.Text;
            int cantJugadores;
            

            if (!(int.TryParse(cantidadJ, out cantJugadores) && cantJugadores>0))
            {
                MessageBox.Show("Ingrese un número de jugadores válido");
               
            }
            else
            {
                int cantidadJugadores = cantJugadores;
                pCantJ.Visible = false;
                pJugInfo.Visible = true;
                pInfoJuego.Visible = true;

                AmigoSecreto numJugadores = new AmigoSecreto();
                numJugadores.getcantJugadores(cantJugadores);
                

            }

            
        }

        

        private void btnInfJuga_Click(object sender, EventArgs e)
        {
            for (int j = 1;j>=cantidadJugadores; j++)
            { 
                string nombre = txbNombre.Text;
                string correo = txbCorreo.Text;
                string endulzada = txbEndulzada.Text;
                string regalo = txbRegalo.Text;

                Jugadores jugador = new Jugadores();
                jugador.jugador(nombre, correo, endulzada, regalo);

                lblJugador.Text = ("Jugador" + j);

            }
            
            lblJugador.Visible=false;
            label3.Visible=false;
            label4.Visible=false;
            label5.Visible=false;
            label6.Visible=false;
            txbNombre.Visible=false;
            txbCorreo.Visible=false;
            txbEndulzada.Visible = false;
            txbRegalo.Visible=false;
            btnInfJuga.Visible=false;
            btnAsignar.Visible = true;

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
           
             for (int i= 1; i <= cantidadJugadores; i++)
             {
                // llama funcion que asigna amigo secreto
                label4.Text = ($"De: admin@amigosecreto.com -- Para: (jugador 1) --- Asunto: Asignación de Amigo Secreto -- Tu Amigo Secreto es... -- (el return de la funcion) ");
             }

        }

        private void btnInfJue_Click(object sender, EventArgs e)
        {
            string numEndulzadas = txbEndulzadas.Text;
            string frecEdulzadas = txbDias.Text;
            string valorEndulzadas = txbValEndulzadas.Text;
            string valorRegalo = txbValRegalo.Text;
           // string inicio = fechaIniJ.date; sacar la fecha del calendario

           

        }
    }
}
