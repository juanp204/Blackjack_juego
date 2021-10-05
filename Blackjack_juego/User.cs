using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_juego
{
    class User
    {
        private int puntuacion = 0;
        private int wins=0;
        private int lose=0;
        public int contadorA = 0;

        public List<Cartas> masouser = new List<Cartas>();

        public int Wins { get => wins; set => wins = value;}
        public int Lose { get => lose; set => lose = value; }
        public int Getpuntuacion { get => puntuacion; set => puntuacion = value;}
        public void agregar(Cartas carta)
        {
            masouser.Add(carta);
            if (carta.Number == "A")
            {
                puntuacion=puntuacion+1;
                contadorA = contadorA + 1;
            }
            else if (carta.Number == "J"|| carta.Number == "Q" || carta.Number == "K")
            {
                puntuacion = puntuacion+10;
            }
            else
            {
                puntuacion = puntuacion + Convert.ToInt32(carta.Number);
            }
            
        }
        public void init(Cartas carta1, Cartas carta2)
        {
            agregar(carta1);
            agregar(carta2);
        }

        public int cantidad()
        {
            return masouser.Count;
        }
    }
}
