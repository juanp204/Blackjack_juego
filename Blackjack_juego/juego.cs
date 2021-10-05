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

        private void cogercarta(User u)
        {
            int num = rand.Next(maso.Count);
            u.agregar(maso[num]);
            maso.Remove(maso[num]);
        }

        Random rand = new Random();
        User jugador = new User();
        User dealer = new User();
        List<Cartas> maso = new List<Cartas>();

        private void juego_Load(object sender, EventArgs e)
        {
            pnlperdiste.Hide();
            pnlganaste.Hide();
            btnParar.Enabled = true;
            BtnMas.Enabled = true;
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            jugador.Getpuntuacion = 0;
            dealer.Getpuntuacion = 0;
            try
            {
                jugador.masouser.RemoveRange(0, jugador.masouser.Count);
                dealer.masouser.RemoveRange(0, dealer.masouser.Count);
                maso.RemoveRange(0, maso.Count);
            }
            catch (Exception)
            {
                return;
            }
            //foreach(Cartas i in jugador.masouser)
            //{
            //    jugador.masouser.Remove(i);
            //}
            //foreach (Cartas i in dealer.masouser)
            //{
            //    dealer.masouser.Remove(i);
            //}
            //foreach (Cartas i in maso)
            //{
            //    maso.Remove(i);
            //}
            for (int s = 1; s <= 4; s++)
            {
                for (int n = 1; n <= 13; n++)
                {
                    Cartas carta = new Cartas();
                    if (n == 1)
                    {
                        carta.Number = "A";
                    }
                    else if (n == 11)
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
            cogercarta(jugador);
            cogercarta(jugador);
            cogercarta(dealer);
            cogercarta(dealer);
            string numb = jugador.masouser[0].Number;
            string symb = jugador.masouser[0].Symbol;
            label1.Text = numb;
            label2.Text = numb;
            label4.Text = symb;
            label10.Text = symb;
            label11.Text = symb;
            numb = jugador.masouser[1].Number;
            symb = jugador.masouser[1].Symbol;
            label25.Text = numb;
            label26.Text = numb;
            label24.Text = symb;
            label17.Text = symb;
            label16.Text = symb;
            numb = dealer.masouser[0].Number;
            symb = dealer.masouser[0].Symbol;
            label103.Text = numb;
            label104.Text = numb;
            label102.Text = symb;
            label95.Text = symb;
            label94.Text = symb;

        }




        private void button1_Click(object sender, EventArgs e)
        {
            cogercarta(jugador);
            if (jugador.cantidad() == 3)
            {
                string numb = jugador.masouser[2].Number;
                string symb = jugador.masouser[2].Symbol;
                label38.Text = numb;
                label39.Text = numb;
                label37.Text = symb;
                label30.Text = symb;
                label29.Text = symb;
                panel3.Show();
            }
            else if (jugador.cantidad() == 4)
            {
                string numb = jugador.masouser[3].Number;
                string symb = jugador.masouser[3].Symbol;
                label51.Text = numb;
                label52.Text = numb;
                label50.Text = symb;
                label43.Text = symb;
                label42.Text = symb;
                panel4.Show();
            }
            else if (jugador.cantidad() == 5)
            {
                string numb = jugador.masouser[4].Number;
                string symb = jugador.masouser[4].Symbol;
                label64.Text = numb;
                label65.Text = numb;
                label63.Text = symb;
                label56.Text = symb;
                label55.Text = symb;
                panel5.Show();
            }
            else if (jugador.cantidad() == 6)
            {
                string numb = jugador.masouser[5].Number;
                string symb = jugador.masouser[5].Symbol;
                label77.Text = numb;
                label78.Text = numb;
                label76.Text = symb;
                label69.Text = symb;
                label68.Text = symb;
                panel6.Show();
            }
            else if (jugador.cantidad() == 7)
            {
                string numb = jugador.masouser[6].Number;
                string symb = jugador.masouser[6].Symbol;
                label90.Text = numb;
                label91.Text = numb;
                label89.Text = symb;
                label82.Text = symb;
                label81.Text = symb;
                panel7.Show();
            }
            //else if (jugador.cantidad() == 6)
            //{
            //    string numb = jugador.masouser[5].Number;
            //    string symb = jugador.masouser[5].Symbol;
            //    label77.Text = numb;
            //    label78.Text = numb;
            //    label76.Text = symb;
            //    label69.Text = symb;
            //    label68.Text = symb;
            //    panel6.Show();
            //}
            //else if (jugador.cantidad() == 7)
            //{
            //    string numb = jugador.masouser[6].Number;
            //    string symb = jugador.masouser[6].Symbol;
            //    label90.Text = numb;
            //    label91.Text = numb;
            //    label89.Text = symb;
            //    label82.Text = symb;
            //    label81.Text = symb;
            //    panel7.Show();
            //}
            //else
            //{

            //}
            if (jugador.Getpuntuacion > 21)
            {
                jugador.Lose = jugador.Lose++;
                pnlperdiste.Show();
                btnParar.Enabled = false;
                BtnMas.Enabled = false;
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {


            while (dealer.Getpuntuacion < 17)
            {
                cogercarta(dealer);
                timer1.Start();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnregresarP_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1()
            {
                MdiParent = this.MdiParent
            };
            inicio.Show();
            this.MdiParent.Size = inicio.Size;
            this.Close();
        }

        private void btnregresarG_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1()
            {
                MdiParent = this.MdiParent
            };
            inicio.Show();
            this.MdiParent.Size = inicio.Size;
            this.Close();
        }
    }
}
