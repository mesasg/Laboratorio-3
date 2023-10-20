using System;
using System.Collections;
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
    /// Clase que contiene los métodos que se ejecutan al interactuar con la interfaz informacionJuego
    /// </summary>
    public partial class informacionJuego : Form
    {
        public informacionJuego()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Método que se ejecuta al darle clicl al botón btnInfoJuego.
        /// Llama al método imprimirInfoJuego de la clase AmigoSecreto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoJuego_Click(object sender, EventArgs e)
        {
            AmigoSecreto imprimir = new AmigoSecreto();
            imprimir.imprimirInfoJuego();
        }

        /// <summary>
        /// Método que se ejecuta al darle click al botón btnProxE.
        /// Le informa al usuario cuando es la próxima endulzada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProxE_Click_1(object sender, EventArgs e)
        {
            DateTime fecha = calFecha.Value;
            AmigoSecreto amigoSecreto = new AmigoSecreto();
            lblProxEndul.Text = amigoSecreto.proxEndulzada(fecha);
        }
    }
}
