using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_juego
{
    public partial class juego : Form
    {
        public juego()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        List<Cartas> maso = new List<Cartas>();

        private void juego_Load(object sender, EventArgs e)
        {
            for (int s = 1; s<=4; s++)
            {
                for (int n = 1; n <= 13; n++)
                {
                    Cartas carta = new Cartas();
                    if (n == 1)
                    {
                        carta.number = "A";
                    }
                    else if (n==11)
                    {
                        carta.number = "J";
                    }
                    else if (n == 12)
                    {
                        carta.number = "Q";
                    }
                    else if (n == 13)
                    {
                        carta.number = "K";
                    }
                    else
                    {
                        carta.number = n.ToString();
                    }
                    carta.symbol = s;
                    maso.Add(carta);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = maso[rand.Next(maso.Count)].number;
        }
    }
}
