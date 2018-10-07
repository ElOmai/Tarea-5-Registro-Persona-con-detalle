using RegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RegistroDetalle.BLL;

namespace RegistroDetalle.UI
{
    public partial class RPersonas : Form
    {
        public List<TelefonosDetalle> Detalle { get; set; }
        public RPersonas()
        {
            InitializeComponent();
            this.Detalle = new List<TelefonosDetalle>();
        }
        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            FechaNacimientodateTimePicker.Value = DateTime.Now;

            this.Detalle = new List<TelefonosDetalle>();


        }

        private Persona LlenaClase()
        {
            Persona persona = new Persona
            {
                PersonaId = Convert.ToInt32(IDnumericUpDown.Value),
                Nombre = NombretextBox.Text,
                Cedula = CedulamaskedTextBox.Text,
                FechaNacimiento = FechaNacimientodateTimePicker.Value,

                Telefonos = this.Detalle
            };

            return persona;
        }

        private void LlenaCampo(Persona persona)
        {
            IDnumericUpDown.Value = persona.PersonaId;
            NombretextBox.Text = persona.Nombre;
            CedulamaskedTextBox.Text = persona.Cedula;
            DirecciontextBox.Text = persona.Direccion;
            FechaNacimientodateTimePicker.Value = persona.FechaNacimiento;

            this.Detalle = persona.Telefonos;
            CargarGrid();
        }
        private void CargarGrid()
        {
            TelefonosdataGridView.DataSource = null;
            TelefonosdataGridView.DataSource = this.Detalle;
        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider.SetError(NombretextBox, "Campo esta vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {
                errorProvider.SetError(DirecciontextBox, "Campo esta vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CedulamaskedTextBox.Text.Replace("-", "")))
            {
                errorProvider.SetError(CedulamaskedTextBox, "Campo esta vacio");
            }
            if (this.Detalle.Count == 0)
            {
                errorProvider.SetError(TelefonosdataGridView, "Debe Agregar algun telefono");
                TelefonomaskedTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (TelefonosdataGridView.DataSource != null)
            {
                this.Detalle = (List<TelefonosDetalle>)TelefonosdataGridView.DataSource;

                this.Detalle.Add(
                    new TelefonosDetalle(
                         id: (int)IDnumericUpDown.Value,
                         personaId: (int)IDnumericUpDown.Value,
                        tipoTelefono: TipocomboBox.Text,
                        telefono: TelefonomaskedTextBox.Text
                        )
                        );
            }
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            if (TelefonosdataGridView.Rows.Count > 0 && TelefonosdataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(TelefonosdataGridView.CurrentRow.Index);

                CargarGrid();

            }
        }
        private bool ExiteEnLaBaseDeDatos()
        {
            Persona persona = PersonasBLL.Buscar((int)IDnumericUpDown.Value);
            return (persona != null);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Persona persona;
            if (!Validar())
                return;
            persona = LlenaClase();

            if (IDnumericUpDown.Value == 0)
                paso = PersonasBLL.Guardar(persona);
            else
            {
                if (!ExiteEnLaBaseDeDatos())
                {
                    MessageBox.Show("Nose puede Modificar No Exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = PersonasBLL.Modificar(persona);
            }
            Limpiar();

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Persona persona = new Persona();
            int.TryParse(IDnumericUpDown.Text, out int id);

            if (PersonasBLL.Eliminar(id))
                MessageBox.Show("Eliminado");
            else
                errorProvider.SetError(IDnumericUpDown, "Persona no Exite");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Persona persona = new Persona();
            int.TryParse(IDnumericUpDown.Text, out int id);

            persona = PersonasBLL.Buscar(id);

            if (persona != null)
            {
                MessageBox.Show("Persona Encotrada");
                LlenaCampo(persona);
            }
            else
            {
                MessageBox.Show("Persona no Encotrada");
            }
        }
    }
}