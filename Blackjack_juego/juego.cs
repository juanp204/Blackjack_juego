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
        User jugador = new User();
        User deler = new User();
        List<Cartas> maso = new List<Cartas>();

        private void juego_Load(object sender, EventArgs e)
        {
            foreach (Cartas i in maso)
            {
                maso.Remove(i);
            }
            for (int s = 1; s<=4; s++)
            {
                for (int n = 1; n <= 13; n++)
                {
                    Cartas carta = new Cartas();
                    if (n == 1)
                    {
                        carta.Number = "A";
                    }
                    else if (n==11)
                    {
                        carta.Number = "J";
                    }
                    else if (n == 12)
                    {
                        carta.Number = "Q";
                    }
                    else if (n == 13)
                    {
                        carta.Number = "K";
                    }
                    else
                    {
                        carta.Number = n.ToString();
                    }
                    if (s == 1)
                    {
                        carta.Symbol = "♥";
                        carta.Colorred = true;
                    }
                    else if (s == 2)
                    {
                        carta.Symbol = "♦";
                        carta.Colorred = true;
                    }
                    else if (s == 3)
                    {
                        carta.Symbol = "♣";
                    }
                    else if (s == 4)
                    {
                        carta.Symbol = "♠";
                    }
                    maso.Add(carta);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = rand.Next(maso.Count);
            jugador.agregar(maso[num]);
            maso.Remove(maso[num]);
            if (jugador.cantidad() == 1)
            {
                label1.Text = jugador.masouser[0].Number;
                label2.Text = jugador.masouser[0].Number;
                panel1.Show();
            }
            if (jugador.cantidad() == 2)
            {
                label25.Text = jugador.masouser[1].Number;
                label26.Text = jugador.masouser[1].Number;
                panel2.Show();
            }
            if (jugador.cantidad() == 3)
            {
                label38.Text = jugador.masouser[2].Number;
                label39.Text = jugador.masouser[2].Number;
                panel3.Show();
            }
            if (jugador.cantidad() == 4)
            {
                label51.Text = jugador.masouser[3].Number;
                label52.Text = jugador.masouser[3].Number;
                panel4.Show();
            }
            if (jugador.cantidad() == 5)
            {
                label1.Text = jugador.masouser[4].Number;
                label2.Text = jugador.masouser[4].Number;
                panel5.Show();
            }
            if (jugador.cantidad() == 6)
            {
                label1.Text = jugador.masouser[5].Number;
                label2.Text = jugador.masouser[5].Number;
                panel6.Show();
            }
            if (jugador.cantidad() == 7)
            {
                label1.Text = jugador.masouser[6].Number;
                label2.Text = jugador.masouser[6].Number;
                panel7.Show();
            }

        }
    }
}
