using RegistroDetalle.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDetalle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registroDePersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPersonas rp = new RPersonas();
            rp.Show();
        }
    }
}
