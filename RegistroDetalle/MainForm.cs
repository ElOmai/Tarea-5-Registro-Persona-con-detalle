using RegistroDetalle.UI;
using System;
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
