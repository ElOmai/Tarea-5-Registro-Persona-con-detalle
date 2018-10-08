using RegistroDetalle.BLL;
using RegistroDetalle.Entidades;
using System;
using System.Windows.Forms;

namespace RegistroDetalle.UI.Registros
{
    public partial class RTipos : Form
    {
        public RTipos()
        {
            InitializeComponent();
        }

        private Tipos LlenaClase()
        {
            Tipos Tipo = new Tipos();
            Tipo.Id = Convert.ToInt32(IDnumericUpDown.Value);
            Tipo.Tipo = TipotextBox.Text;
            return Tipo;
        }

        private void LlenaCampo(Tipos Tipo)
        {
            IDnumericUpDown.Value = Tipo.Id;
            TipotextBox.Text = Tipo.Tipo;
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            TipotextBox.Text = string.Empty;
        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(TipotextBox.Text))
            {
                errorProvider.SetError(TipotextBox, "Campo esta vacio");
                paso = false;
            }

            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Tipos Tipo;
            if (!Validar())
                return;
            Tipo = LlenaClase();

            if (IDnumericUpDown.Value != 0)
                paso = TiposBLL.Guardar(Tipo);


            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Tipos telefono = new Tipos();
            int.TryParse(IDnumericUpDown.Text, out int id);

            if (TiposBLL.Eliminar(id))
                MessageBox.Show("Eliminado");
            else
                errorProvider.SetError(IDnumericUpDown, "Persona no Exite");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Tipos Telefono = new Tipos();
            int.TryParse(IDnumericUpDown.Text, out int id);

            Telefono = TiposBLL.Buscar(id);

            if (Telefono != null)
            {
                MessageBox.Show("Persona Encotrada");
                LlenaCampo(Telefono);
            }
            else
            {
                MessageBox.Show("Persona no Encotrada");
            }
        }
    }
}

