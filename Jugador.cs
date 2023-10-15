using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    //Clase que contiene todos los metodos que obtienen y guardan la informacion de los jugadores
    internal class Jugador
    {
        String nombre;
        String correo;
        String endulzadaIdeal;
        String regaloIdeal;
        String amigoSecreto;

        //Metodo que crea un objeto jugador con toda su informacion
        public Jugador(String nombrej, String correoj, String endulzadaIdealj, String regaloIdealj)
        {
            this.nombre = nombrej;
            this.correo = correoj;
            this.endulzadaIdeal = endulzadaIdealj;
            this.regaloIdeal = regaloIdealj;
        }



    }
}
