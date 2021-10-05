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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlrecarga.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlrecarga.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTutorial.Text = "La idea es sacar cartas de la baraja\ny ir sumando sin pasarse de 21\n\n-";
            this.MdiParent.Size = this.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            juego jug = new juego
            {
                MdiParent = this.MdiParent
            };
            this.MdiParent.Size = jug.Size;
            jug.Show();
            this.Close();
        }
    }
}
