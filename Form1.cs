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
    /// Clase que contiene los métodos que se ejecutan al interactuar con la interfaz inicial.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Método que inicializa
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que cambia la interfaz del panelMain según la opcion seleccionada en el menú.
        /// </summary>
        /// <param name="interfaznueva">Nombre de la interfaz que se debe mostrar</param>
        public void cambiarInterfaz(object interfaznueva)
        {
            if (panelMain.Controls.Count>0)
            {
                panelMain.Controls.RemoveAt(0);
                Form interfaz = interfaznueva as Form;
                interfaz.TopLevel = false;
                interfaz.Dock = DockStyle.Fill;
                panelMain.Controls.Add(interfaz);
                panelMain.Tag = interfaz;
                interfaz.Show();
                
            }
        }

        /// <summary>
        /// Método que llama al método cambiarInterfaz al seleccionar la opcion Nuevo Juego del menú.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            cambiarInterfaz(new nJuego());
        }

        /// <summary>
        /// Método que llama al método cambiarInterfaz al dar click en el logo del programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cambiarInterfaz(new inicio());
        }

        /// <summary>
        /// Método que llama al método cambiarInterfaz al seleccionar la opción Información de los Jugadores en el menú.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoJugadores_Click(object sender, EventArgs e)
        {
            cambiarInterfaz(new informacionJugadores());

        }

        /// <summary>
        /// Método que llama al método cambiarInterfaz al seleccionar la opción Información del Juego en el menú.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoJuego_Click(object sender, EventArgs e)
        {
            cambiarInterfaz(new informacionJuego());


        }

    }

}
