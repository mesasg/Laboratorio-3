using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        String nombre;
        String correo;
        String endulzadaIdeal;
        String regaloIdeal;
        String amigoSecreto;

        /// <summary>
        /// Método que crea un objeto jugador con toda su informacion
        /// </summary>
        /// <param name="nombrej">Nombre del Jugador</param>
        /// <param name="correoj">Correo del Jugador</param>
        /// <param name="endulzadaIdealj">Que le gustaría al jugador recibir de endulzada</param>
        /// <param name="regaloIdealj">Que le gustaría al jugador recibir de regalo</param>
        public void objetoJugador(String nombrej, String correoj, String endulzadaIdealj, String regaloIdealj)
        {
  
            
            Jugadores jugador = new Jugadores();
            jugador.nombre = nombrej;
            jugador.correo = correoj;
            jugador.endulzadaIdeal = endulzadaIdealj;
            jugador.regaloIdeal = regaloIdealj;


            AmigoSecreto infoJugador = new AmigoSecreto();
            infoJugador.vectorJugadores(jugador);
        }


        /*public void objetoJugador()
        {
            Jugadores jugador = new Jugadores();
            jugador.nombre = nombrej;
            jugador.correo = correoj;
            jugador.endulzadaIdeal = endulzadaIdealJ;
            jugador.regaloIdeal = regaloIdealJ;
        }*/

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
        public String getCorreo() 
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

        public void setAmigoSecreto()
        {

        }

    }
}
