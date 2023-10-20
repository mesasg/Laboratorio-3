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
    /// Clase que contiene los métodos que obtienen y guardan la información del juego y los jugadores.
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
        /// Método que guarda la cantidad de personas que participarán en el amigo secreto
        /// </summary>
        /// <param name="cantJuga">Cantidad de personas que perticiparán en el juego</param>
        public void setCantJugadores(int cantJuga)
        {

           cantidadJugadores = cantJuga;

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
        /// Método que guarda la cantidad de endulzadas
        /// </summary>
        /// <param name="cantEndul">La cantidad de veces que se van a endulzar durante el juego</param>
        public void setCantEndulzadas(int cantEndul)
        {
            cantidadEndulzadas = cantEndul;
        }


        /// <summary>
        /// Método que guarda la frecuencia de endulzadas en días
        /// </summary>
        /// <param name="frecEndul">El número de días que transcurriran entre endulzadas</param>
        public void setFrecEndulzadas(int frecEndul)
        {
            frecuenciaEndulzadas = frecEndul;
        }


        /// <summary>
        /// Método que guarda el valor que deben tener las endulzadas
        /// </summary>
        /// <param name="valEndul">El costo min de la endulzada</param>
        public void setValEndulzadas(float valEndul)
        {
            valorEndulzadas = valEndul;
        }

        /// <summary>
        /// Método que guarda el valor que debe tener el regalo del descubrimiento
        /// </summary>
        /// <param name="valRegalo">El costo min del regalo</param>
        public void setValRegalo(float valRegalo)
        {
            valorRegalo = valRegalo;
        }

        /// <summary>
        /// Método que guarda la fecha en la que se acaba el juego
        /// </summary>
        /// <param name="fechaFin">Fecha del fin del juego, el descubrimiento</param>
        public void setFechaDescu(DateTime fechaFin)
        {
            descubrimiento = fechaFin;
           
        }

        /// <summary>
        /// Método que guarda la fecha en la que inicia el juego
        /// </summary>
        /// <param name="fechaInicio">Fecha en la que inicia el juego</param>
        public void setFechaInicio (DateTime fechaInicio)
        {
            inicio = fechaInicio;
        }



        /// <summary>
        /// Método que guarda la información de los jugadores en un vector
        /// </summary>
        /// <returns>El vector con los objetos de la clase jugador</returns>
        public Jugadores[] vectorJugadores()
        {

            nJuego nJuego = new nJuego();
            List<Jugadores> jugadores = nJuego.enviarLista();

            Jugadores[] vectorJugadores = jugadores.ToArray();

            return (vectorJugadores);

        }


        /// <summary>
        /// Método que calcula cuándo es la próxima endulzada.
        /// </summary>
        /// <param name="fecha">Fecha que el usuario selecciona en el calendario</param>
        /// <returns>Cuándo es la próxima endulzada</returns>
        public string proxEndulzada(DateTime fecha)
        {
            
            int revision = DateTime.Compare(fecha, descubrimiento);

            
            if (revision<0)
            {
                TimeSpan diasTranscu = inicio.Subtract(fecha);
                int dias = diasTranscu.Days;
                int endulPasadas = dias / frecuenciaEndulzadas;
                int edulFaltan = cantidadEndulzadas - endulPasadas;

                if (edulFaltan > 0)
                {
                    
                    int ultEndul = dias % frecuenciaEndulzadas;
                    int proxima = frecuenciaEndulzadas - ultEndul;
                    DateTime proxEndulzada = fecha.AddDays(proxima);
                    string proxFecha = proxEndulzada.ToString();
                    return ("La próxima endulzada es el: " + proxFecha);
                }
                else
                {
                    return ("Ya diste todas las endulzadas");
                }
               
            }
            else
            {
                if (revision == 0)
                {
                    return ("No hay más endulzdas, hoy es el descubrimiento.");
                }
                if (revision > 0)
                {
                    return ("Ya pasó el descubrimiento");
                }
                else  
                {
                    return ("Ya se terminó el juego");
                }
                
            }

        }

        /// <summary>
        /// Método que imprime la información del juego.
        /// </summary>
        public void imprimirInfoJuego()
        {
            MessageBox.Show("Inicio del juego: " + inicio.ToString() + Environment.NewLine + "Fecha Descubrimiento: " + descubrimiento.ToString() +
            Environment.NewLine + "Inicio del juego:" + cantidadEndulzadas.ToString() + Environment.NewLine + "Frecuencia de las endulzadas: " 
            + frecuenciaEndulzadas.ToString() + " días" + Environment.NewLine + "Valor de las endulzadas: " +valorEndulzadas.ToString() +
            Environment.NewLine + "Valor Regalo: " + valorRegalo.ToString());

        }


    }
}
