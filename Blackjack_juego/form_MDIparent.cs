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
    public partial class form_MDIparent : Form
    {
        public form_MDIparent()
        {
            InitializeComponent();
            Form1 inicio = new Form1
            {
                MdiParent = this
            };
            inicio.Show();
        }
    }
}
