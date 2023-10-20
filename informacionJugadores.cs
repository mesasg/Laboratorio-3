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
    /// <summary>
    /// Clase que contiene los métodos que se ejecutal al interactuar con la interfaz informacionJugadores
    /// </summary>
    public partial class informacionJugadores : Form
    { 
        /// <summary>
        /// Método que incializa
        /// </summary>
        public informacionJugadores()
        {
            InitializeComponent();
        }

        int cont = 0;
        /// <summary>
        /// Método que se ejecuta al darle click al botón btnVerIn.
        /// Muestra la información del primer jugador y activa los botones siguiente y anterior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerIn_Click(object sender, EventArgs e)
        {
            cont = 0;
            label2.Visible = true;
     
            lblInfo.Visible = true;
            btnAnt.Visible = true;
            btnSig.Visible = true;
            btnAnt.Enabled = false;
            btImInf.Visible = true;

            AmigoSecreto amigoSecreto = new AmigoSecreto();
            Jugadores[] jugadores1 = amigoSecreto.vectorJugadores();

            Jugadores info = jugadores1[cont];


            label2.Text = "Jugador" + (cont + 1);
            lblInfo.Text = "Nombre: " + info.nombre + Environment.NewLine + "Correo: " + info.correo + Environment.NewLine +
            "Endulzada Ideal: " + info.endulzadaIdeal + Environment.NewLine + "Regalo Ideal: " + info.regaloIdeal + Environment.NewLine +
            "Amigo Secreto: " + info.amigoSecreto;

            cont = cont + 1;
           
        }

      
        /// <summary>
        /// Método que se ejcuta al darle click al botón btnSig.
        /// Muestra la información del siguiente jugador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSig_Click(object sender, EventArgs e)
        {
            AmigoSecreto amigoSecreto = new AmigoSecreto();
            Jugadores[] jugadores1 = amigoSecreto.vectorJugadores();
            int num = jugadores1.Length;

            if (cont < num)
            {
                Jugadores info = jugadores1[cont];

                label2.Text = "Jugador" + (cont + 1);
                lblInfo.Text = "Nombre: " + info.nombre + Environment.NewLine + "Correo: " + info.correo + Environment.NewLine +
                "Endulzada Ideal: " + info.endulzadaIdeal + Environment.NewLine + "Regalo Ideal: " + info.regaloIdeal + Environment.NewLine +
                "Amigo Secreto: " + info.amigoSecreto;

                cont = cont + 1;
            }
            btnAnt.Enabled = true;
        }

        /// <summary>
        /// Método que se ejecutal al darle click al botón btnAnt.
        /// Muestra la infromación del jugador anterior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnt_Click(object sender, EventArgs e)
        {
            cont = cont - 1;
            AmigoSecreto amigoSecreto = new AmigoSecreto();
            Jugadores[] jugadores1 = amigoSecreto.vectorJugadores();
            int num = jugadores1.Length;

            if (cont < num && cont>=0)
            {
                Jugadores info = jugadores1[cont];

                label2.Text = "Jugador" + (cont + 1);
                lblInfo.Text = "Nombre: " + info.nombre + Environment.NewLine + "Correo: " + info.correo + Environment.NewLine +
                "Endulzada Ideal: " + info.endulzadaIdeal + Environment.NewLine + "Regalo Ideal: " + info.regaloIdeal + Environment.NewLine +
                "Amigo Secreto: " + info.amigoSecreto;

            }


        }

        /// <summary>
        /// Método que imprime la información del juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btImInf_Click(object sender, EventArgs e)
        {
            string datos = lblInfo.Text;
            MessageBox.Show(datos);
        }
    }
}
