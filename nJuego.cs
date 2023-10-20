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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnCantJugadores_Click(object sender, EventArgs e)
        {
            string cantidadJ = txtCantJugadores.Text;
            int cantJugadores;

            if (int.TryParse(cantidadJ, out cantJugadores) && cantJugadores>1)
            {
                this.cantidadJugadores = cantJugadores;
                pCantJ.Visible = false;
                pJugInfo.Visible = true;
                pInfoJuego.Visible = true;
                
                AmigoSecreto numJugadores = new AmigoSecreto();
                numJugadores.setCantJugadores(cantJugadores);
            }
            else
            {
                MessageBox.Show("Ingrese un número de jugadores válido." + Environment.NewLine + "(La cantidad min de jugadores que se necesitan" +
                    " para realizar la asignación de amigos secretos es 2)");

                txtCantJugadores.Clear();
            }

            
        }

        int cantEndul;
        int frecuEndul;
        float valEndul;
        float valRegalo;
        DateTime inicio;
        DateTime fin;


        /// <summary>
        /// Método que se ejecuta cuanto se le da click al botón btnInfJue.
        /// Valida y envía la información de los text boxs a la otras clases.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnInfJue_Click(object sender, EventArgs e)
        {
            string numEndulzadas = txbEndulzadas.Text;
            string frecEdulzadas = txbDias.Text;
            string valorEndulzadas = txbValEndulzadas.Text;
            string valorRegalo = txbValRegalo.Text;
            DateTime fechaInicio = fechaIniJ.Value;
            DateTime fechaFin = fechaFinJ.Value;

            inicio = fechaInicio;
            fin = fechaFin;


            if (int.TryParse(numEndulzadas, out cantEndul) && int.TryParse(frecEdulzadas, out frecuEndul)
                && float.TryParse(valorEndulzadas, out valEndul) && float.TryParse(valorRegalo, out valRegalo))
            {

                if (cantEndul < 0)
                {
                    MessageBox.Show("La cantidad de endulzadas no puede ser negativa");
                }
                if (frecuEndul <= 0)
                {
                    MessageBox.Show("La frecuencia de las endulzadas debe de ser min 1." + Environment.NewLine +
                        "(La frecuencia son los dias trancurridos entre endulzadas)");
                }
                if (valRegalo < 0)
                {
                    MessageBox.Show("El valor del regalo no puede ser negativo, si no desean dar regalo establece el valor a 0");
                }
                if (valEndul < 0)
                {
                    MessageBox.Show("El valor de las endulzadas no puede ser negativo, si no desean dar endulzadas establece el valor a 0");
                }
                if (fechaInicio > fechaFin)
                {
                    MessageBox.Show("Las fechas no concuerdan");
                }
                else
                {
                    AmigoSecreto amigoSecreto = new AmigoSecreto();
                    amigoSecreto.setCantEndulzadas(cantEndul);
                    amigoSecreto.setFrecEndulzadas(frecuEndul);
                    amigoSecreto.setValEndulzadas(valEndul);
                    amigoSecreto.setValRegalo(valRegalo);
                    amigoSecreto.setFechaInicio(inicio);
                    amigoSecreto.setFechaDescu(fin);

                    lblEndul.Visible = false;
                    label1.Text = string.Empty;
                    label11.Visible = false;
                    label2.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    txbEndulzadas.Visible = false;
                    txbDias.Visible = false;
                    txbValEndulzadas.Visible = false;
                    txbValRegalo.Visible = false;
                    fechaIniJ.Visible = false;
                    fechaIniJ.Enabled = false;
                    fechaFinJ.Visible = false;
                    fechaFinJ.Enabled = false;
                    btnInfJue.Visible = false;
                    label1.Text = "Datos Guardados";

                }

            }
            else
            {
                MessageBox.Show("Por favor escribe todos los datos en números, la cantidad y la frecuencia de las endulzadas deben ser enteros");
            }


        }


        public List<Jugadores> personas = new List<Jugadores>();
        int cont = 0;
        /// <summary>
        /// Método que se ejecuta al dar click en el botón btnInfJuga.
        /// Crea un objeto de la clase Jugadores con la información de las text box y lo agrega a una lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnInfJuga_Click(object sender, EventArgs e)
        {

            if (cont<cantidadJugadores)
            {
                string nombre = txbNombre.Text;
                string correo = txbCorreo.Text;
                string endulzada = txbEndulzada.Text;
                string regalo = txbRegalo.Text;

                Jugadores persona = new Jugadores
                {
                    nombre = nombre,
                    correo = correo,
                    endulzadaIdeal = endulzada,
                    regaloIdeal = regalo,
                    amigoSecreto = null

                };
                personas.Add(persona);
                cont = cont + 1;
                lblJugador.Text = "Jugador " + (cont+1);
                txbNombre.Clear();
                txbCorreo.Clear();
                txbEndulzada.Clear();
                txbRegalo.Clear();
            }
            if (cont == cantidadJugadores)
            {
               
                btnInfJuga.Enabled = false;
                lblJugador.Visible = false;
                label3.Visible = false;
                label5.Visible = false;
                label4.Text = string.Empty;
                label6.Visible = false;
                txbNombre.Visible = false;
                txbCorreo.Visible = false;
                txbEndulzada.Visible = false;
                txbRegalo.Visible = false;
                btnInfJuga.Visible = false;
                btnAsignar.Visible = true;

            }


        }



        /// <summary>
        /// Método que guarda la lista con los amigos secretos
        /// </summary>
        /// <param name="listaActualizada">Lista con los amigos secretos declarados</param>
        public void setLista(List<Jugadores> listaActualizada)
        {
            personas = listaActualizada;
        }



        /// <summary>
        /// Método que envia la lista personas.
        /// </summary>
        /// <returns>Lista personas</returns>
        public List<Jugadores> enviarLista()
        {
            return (personas);
        }



        /// <summary>
        /// Método que se ejecuta al dar click al botón btnAsignar.
        /// Llama a la función amigosSecreto y muestra en pantalla las asignaciones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Jugadores amigosSecre = new Jugadores();
            amigosSecre.amigosSecreto(personas);

        }




    }
}
