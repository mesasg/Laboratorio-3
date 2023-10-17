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
    /// <summary>
    /// Clase que contiene los métodos que se ejecutan al interactuar con la interfaz nuevoJuego
    /// </summary>
    public partial class nJuego : Form
    {
       /// <summary>
       /// Método que inicializa
       /// </summary>
        public nJuego()
        {
            InitializeComponent();
        }


        int cantidadJugadores;

        /// <summary>
        /// Método que se ejecuta al dar click al botón btnCantJugadores.
        /// Obtiene la cantidad de jugadores, valida el dato y lo manda a la clase AmigoSecreto
        /// </summary>
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
                numJugadores.setCantJugadores(cantJugadores);
                

            }

            
        }

        
        /// <summary>
        /// Método que se ejecuta al dar click en el botón btnInfJuga.
        /// Envía la información ingresada en cada text box a la clase Jugadores y prepara el panel para que muestre otra información después.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfJuga_Click(object sender, EventArgs e)
        {
            for (int j = 1;j>=cantidadJugadores; j++)
            { 
                string nombre = txbNombre.Text;
                string correo = txbCorreo.Text;
                string endulzada = txbEndulzada.Text;
                string regalo = txbRegalo.Text;

                Jugadores jugador = new Jugadores();
                jugador.objetoJugador(nombre, correo, endulzada, regalo);

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

        /// <summary>
        /// Método que se ejecuta al dar click al botón btnAsignar.
        /// Asigna los amigos secretos y simula un correo informando a cada jugador a quien debe endulzar.
        /// </summary>
        
        private void btnAsignar_Click(object sender, EventArgs e)
        {
           
             for (int i= 1; i <= cantidadJugadores; i++)
             {
                // llama funcion que asigna amigo secreto
                label4.Text = ($"De: admin@amigosecreto.com -- Para: (jugador 1) --- Asunto: Asignación de Amigo Secreto -- Tu Amigo Secreto es... -- (el return de la funcion) ");
             }

        }

        /// <summary>
        /// Método que se ejecuta cuanto se le da click al botón btnInfJue.
        /// Valida y envía la información de los text boxs a la clase Amigo Secreto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfJue_Click(object sender, EventArgs e)
        {
            string numEndulzadas = txbEndulzadas.Text;
            string frecEdulzadas = txbDias.Text;
            string valorEndulzadas = txbValEndulzadas.Text;
            string valorRegalo = txbValRegalo.Text;
            // string inicio = fechaIniJ.date; sacar la fecha del calendario
            DateTime fechaInicio = fechaIniJ.Value;
            DateTime fechaFin = fechaFinJ.Value;

            int cantEndul;
            int frecEndul;
            float valEndul;
            float valRegalo;


            if (!(int.TryParse(numEndulzadas, out cantEndul) || int.TryParse(frecEdulzadas, out frecEndul) || float.TryParse(valorEndulzadas, out valEndul) || float.TryParse(valorRegalo, out valRegalo) 
                || fechaInicio>DateTime.Now || fechaFin>DateTime.Now))
            {
                
                if (cantEndul<0)
                {
                    MessageBox.Show("La cantidad de endulzadas no puede ser negativa");
                }
                if (frecEndul<0)
                {
                    MessageBox.Show("La frecuencia de las endulzadas no puede negativa");
                }
                if (valRegalo<0)
                {
                    MessageBox.Show("El valor del regalo no puede ser negativo, si no desean dar regalo establece el valor a 0");
                }
                if (valEndul <0)
                {
                    MessageBox.Show("El valor de las endulzadas no puede ser negativo, si no desean dar endulzadas establece el valor a 0");
                }
                if (fechaInicio < DateTime.Now && fechaFin < DateTime.Now)
                {
                    MessageBox.Show("Si no vas a jugar con viajeros del tiempo, te recomendamos revisar las fechas que seleccionaste");
                }
                else
                {
                    MessageBox.Show("Por favor revisa los datos ingresados");
                }

            }
           else
            {
                AmigoSecreto info = new AmigoSecreto();
                info.informacionJuego(cantEndul, frecEndul, valEndul, valRegalo, fechaInicio, fechaFin);
            }

        }
    }
}
