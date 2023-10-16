using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    //Clase que contiene todos los metodos que obtienen y guardan la informacion de los jugadores
    internal class Jugadores
    {
        String nombre;
        String correo;
        String endulzadaIdeal;
        String regaloIdeal;
        String amigoSecreto;

        //Metodo que crea un objeto jugador con toda su informacion
        public void jugador(String nombrej, String correoj, String endulzadaIdealj, String regaloIdealj)
        {
            
                this.nombre = nombrej;
                this.correo = correoj;
                this.endulzadaIdeal = endulzadaIdealj;
                this.regaloIdeal = regaloIdealj;
            
            AmigoSecreto nuevoJugador = new AmigoSecreto();
            //nuevoJugador.vectorJugadores( ,jugador);
        }

        public string getNombre() 
        {
            return nombre; 
        }


        public String getCorreo() 
        {
            return correo;
        }

        public string getendulzadaIdeal()
        {
            return endulzadaIdeal;
        }

        public String getRegaloIdeal() 
        {
            return  regaloIdeal;
        }

       /* public string setAmigoSecreto()
        {

        }*/

    }
}
