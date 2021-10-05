using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_juego
{
    class Cartas
    {
        private string number;
        private string symbol;
        private bool colorred = false;

        public string Number { get => number; set => number = value;}
        public string Symbol { get => symbol; set => symbol = value;}
        public bool Colorred { get => colorred; set => colorred = value;}
    }
}
