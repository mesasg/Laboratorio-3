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
    //Clase que ejecuta los metodos respectivos a las acciones que se pueden realizar en la primera
    //pantalla del programa y el menú.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Metodo que cambia la interfaz del panelMain según la opcion seleccionada en el menu
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

        //metodo que llama al metodo cambiarInterfaz al seleccionar la opcion Nuevo Juego del menu
        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            cambiarInterfaz(new nJuego() );
        }

        //Metodo que llama al metodo cambiarInterfaz al darle click al logo del programa
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cambiarInterfaz(new inicio());
        }

        private void btnInfoJugadores_Click(object sender, EventArgs e)
        {
            cambiarInterfaz(new informacionJugadores());
        }

        private void btnInfoJuego_Click(object sender, EventArgs e)
        {
            cambiarInterfaz(new informacionJuego());
        }
    }

}
