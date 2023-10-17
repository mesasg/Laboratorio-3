using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    /// <summary>
    /// Clase que contiene los métodos que obtienen y guardan la información del juego y los jugadores
    /// </summary>
    public class AmigoSecreto
    {
        /// <summary>
        /// Constructor de la clase AmigoSecreto
        /// </summary>
        public AmigoSecreto() { }

        int cantidadJugadores;
        int cantidadEndulzadas;
        int frecuenciaEndulzadas;
        float valorEndulzadas;
        float valorRegalo;
        DateTime inicio;
        DateTime descubrimiento;


        /// <summary>
        /// Método que asigna valores a las variables de la clase AmigoSeceto
        /// </summary>
        /// <param name="cantEndul">Cantidad de veces que se van a endulzar durante el juego</param>
        /// <param name="frecEndul">El número de días que transcurriran entre endulzadas</param>
        /// <param name="valEndul">El costo min de las endulzadas</param>
        /// <param name="valRegalo">El costo min del regalo</param>
        public void informacionJuego(int cantEndul, int frecEndul, float valEndul, float valRegalo, DateTime fechaInicio, DateTime fechaFin)
        {
            this.cantidadEndulzadas = cantEndul;
            this.frecuenciaEndulzadas= frecEndul;
            this.valorEndulzadas= valEndul;
            this.valorRegalo = valRegalo;
            this.inicio = fechaInicio;
            this.descubrimiento = fechaFin;
            
        }

        /// <summary>
        /// Método que recibe la cantidad de personas que participarán en el amigo secreto
        /// </summary>
        /// <returns>La cantidad de personas que jugarán</returns>
        public void setCantJugadores(int cantuga)
        {

           this.cantidadJugadores = cantuga;

        }

        /// <summary>
        /// Método que obtiene la cantidad de jugadores que participarán en el amigo secreto
        /// </summary>
        /// <returns>La cantidad de personas que jugarán</returns>
        public int getCantJugadores()
        {
            
            return (cantidadJugadores);

        }

        /// <summary>
        /// Método que obtiene la cantidad de endulzadas
        /// </summary>
        /// <returns>La cantidad de veces que se van a endulzar durante el juego</returns>
        public int getCantEndulzadas()
        {
            return (cantidadEndulzadas);
        }
        
        /// <summary>
        /// Método que obtiene la frecuencia de enduolzadas en días
        /// </summary>
        /// <returns>El número de días que transcurriran entre endulzadas</returns>
        public int getFrecEndulzadas()
        {
            return (frecuenciaEndulzadas) ;
        }
        
        /// <summary>
        /// Método que obtiene el valor que deben costar las endulzadas
        /// </summary>
        /// <returns>El costo min de la endulzada</returns>
        public float getValEndulzadas()
        {
            return (valorEndulzadas);
        }
       
        /// <summary>
        /// Método que obtiene el valor que debe costar el regalo del descubrimiento
        /// </summary>
        /// <returns>El costo min del regalo</returns>
        public float getValRegalo()
        {
            return (valorRegalo);
        }


        /// <summary>
        /// Método que guarda la información de los jugadores en un vector
        /// </summary>
        /// <returns></returns>
        public void vectorJugadores(Jugadores infoJugador)
        {
            int n = getCantJugadores();

            
            AmigoSecreto[] jugadores = new AmigoSecreto[n];
            for (int i = 0; i < n; i++)
            {
                    jugadores[i] = infoJugador;

            }

        }
        
        


    }
}
