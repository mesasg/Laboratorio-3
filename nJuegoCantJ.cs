using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    //Clase que contiene los metodos que se ejecutan al realizar acciones en la interfaz nuevoJuego1
    public partial class nJuegoCantJ : Form
    {
        public nJuegoCantJ()
        {
            InitializeComponent();
        }

        

        //Obtiene la cantidad de jugadores y valida el dato ingresado, lo manda a clase Amigo secreto
        public void btnCantJugadores_Click(object sender, EventArgs e)
        {
            string cantidadJ = txtCantJugadores.Text;
            int cantJugadores;

            if (!(int.TryParse(cantidadJ, out cantJugadores) && cantJugadores>1))
            {
                MessageBox.Show("Ingrese un número de jugadores válido");
               
            }
            else
            {
                Form1 nuevo = new Form1();
                nuevo.cambiarInterfaz(new nJuegoJugadores());

                AmigoSecreto numJugadores = new AmigoSecreto();
                numJugadores.getcantJugadores(cantJugadores);
               

            }

            
        }
    }
}
