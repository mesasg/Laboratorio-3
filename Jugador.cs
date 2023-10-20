using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    /// <summary>
    /// Clase que contiene todos los métodos que obtienen y guardan la información de los jugadores
    /// </summary>
    public class Jugadores
    {
        /// <summary>
        /// Constructor de la clase Jugadores
        /// </summary>
        public Jugadores() { }

        public string nombre;
        public string correo;
        public string endulzadaIdeal;
        public string regaloIdeal;
        public string amigoSecreto;


        /// <summary>
        /// Método que crea un objeto jugador con toda su informacion
        /// </summary>
        /// <param name="nombrej">Nombre del Jugador</param>
        /// <param name="correoj">Correo del Jugador</param>
        /// <param name="endulzadaIdealj">Que le gustaría al jugador recibir de endulzada</param>
        /// <param name="regaloIdealj">Que le gustaría al jugador recibir de regalo</param>
        public void infoJugador(String nombrej, String correoj, String endulzadaIdealj, String regaloIdealj)
        {
            
            this.nombre = nombrej;
            this.correo = correoj;
            this.endulzadaIdeal = endulzadaIdealj;
            this.regaloIdeal = regaloIdealj;


        }


        /// <summary>
        /// Método que obtiene el nombre del jugador
        /// </summary>
        /// <returns>El nombre del jugador</returns>
        public string getNombre() 
        {
            return nombre; 
        }


        /// <summary>
        /// Método que obtiene el correo del jugador
        /// </summary>
        /// <returns>El correo el jugador</returns>
        public string getCorreo() 
        {
            return correo;
        }


        /// <summary>
        /// Método que obtiene la endulzada ideal del jugador
        /// </summary>
        /// <returns>La endulzada ideal del jugador</returns>
        public string getendulzadaIdeal()
        {
            return endulzadaIdeal;
        }


        /// <summary>
        /// Método que obtiene el regalo ideal del jugador
        /// </summary>
        /// <returns>El regalo ideal del jugador</returns>
        public String getRegaloIdeal() 
        {
            return  regaloIdeal;
        }

       
        /// <summary>
        /// Método que asigna los amigos secretos y simula un correo a cada jugador para informarle a quien tiene.
        /// </summary>
        public void amigosSecreto(List<Jugadores> jugadores)
        {
          

            while (true)
            {

                List<Jugadores> amigos = new List<Jugadores>(jugadores);
                Random random = new Random();

                bool asignacion = true;

                
                for (int i = 0; i < jugadores.Count; i++)
                {
                    
                    int posicionL = random.Next(amigos.Count);

                    if (jugadores[i] != amigos[posicionL])
                    {
                        Jugadores jugador = jugadores[i];
                        Jugadores amigoSecreto = amigos[posicionL];

                        MessageBox.Show("De: admin@amigosecreto.com" + Environment.NewLine + $"Para:" + jugador.nombre + Environment.NewLine +
                            "Asunto: Asignación de Amigo Secreto" + Environment.NewLine + $"Tu Amigo Secreto es..." + amigoSecreto.nombre );

                        amigos.RemoveAt(posicionL);
                        jugador.amigoSecreto = amigoSecreto.nombre;
                    }
                    else
                    {
                        asignacion = false;
                        break;
                    }

                }

                if (asignacion)
                {
                    break;
                }
            }


            nJuego nJuego = new nJuego();
            nJuego.setLista(jugadores);
           
            
        }

       

    }
}
