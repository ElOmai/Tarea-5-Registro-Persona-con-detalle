namespace RegistroDetalle.UI
{
    partial class RPersonas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TelefonosdataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.CedulamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FechaNacimientodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TipocomboBox = new System.Windows.Forms.ComboBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.registroDetalleDBDataSet1 = new RegistroDetalle.RegistroDetalleDBDataSet1();
            this.tiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposTableAdapter = new RegistroDetalle.RegistroDetalleDBDataSet1TableAdapters.TiposTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroDetalleDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(73, 13);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IDnumericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "F.Nacimiento";
            // 
            // TelefonosdataGridView
            // 
            this.TelefonosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TelefonosdataGridView.Location = new System.Drawing.Point(12, 222);
            this.TelefonosdataGridView.Name = "TelefonosdataGridView";
            this.TelefonosdataGridView.Size = new System.Drawing.Size(361, 150);
            this.TelefonosdataGridView.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cédula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tipo";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(73, 45);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(120, 20);
            this.NombretextBox.TabIndex = 9;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(73, 91);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(120, 20);
            this.DirecciontextBox.TabIndex = 10;
            // 
            // CedulamaskedTextBox
            // 
            this.CedulamaskedTextBox.Location = new System.Drawing.Point(73, 137);
            this.CedulamaskedTextBox.Mask = "000-0000000-0";
            this.CedulamaskedTextBox.Name = "CedulamaskedTextBox";
            this.CedulamaskedTextBox.Size = new System.Drawing.Size(83, 20);
            this.CedulamaskedTextBox.TabIndex = 11;
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(76, 196);
            this.TelefonomaskedTextBox.Mask = "(999) 000-0000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(80, 20);
            this.TelefonomaskedTextBox.TabIndex = 12;
            // 
            // FechaNacimientodateTimePicker
            // 
            this.FechaNacimientodateTimePicker.Location = new System.Drawing.Point(87, 170);
            this.FechaNacimientodateTimePicker.Name = "FechaNacimientodateTimePicker";
            this.FechaNacimientodateTimePicker.Size = new System.Drawing.Size(180, 20);
            this.FechaNacimientodateTimePicker.TabIndex = 13;
            // 
            // TipocomboBox
            // 
            this.TipocomboBox.FormattingEnabled = true;
            this.TipocomboBox.Location = new System.Drawing.Point(217, 196);
            this.TipocomboBox.Name = "TipocomboBox";
            this.TipocomboBox.Size = new System.Drawing.Size(121, 21);
            this.TipocomboBox.TabIndex = 14;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(345, 193);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(28, 23);
            this.Agregarbutton.TabIndex = 15;
            this.Agregarbutton.Text = "+";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click_1);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(217, 16);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 16;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Removerbutton
            // 
            this.Removerbutton.Location = new System.Drawing.Point(12, 378);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(75, 23);
            this.Removerbutton.TabIndex = 17;
            this.Removerbutton.Text = "Remover Fila";
            this.Removerbutton.UseVisualStyleBackColor = true;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(15, 433);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 18;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click_1);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(135, 433);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 19;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(263, 433);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 20;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click_1);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // registroDetalleDBDataSet1
            // 
            this.registroDetalleDBDataSet1.DataSetName = "RegistroDetalleDBDataSet1";
            this.registroDetalleDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposBindingSource
            // 
            this.tiposBindingSource.DataMember = "Tipos";
            this.tiposBindingSource.DataSource = this.registroDetalleDBDataSet1;
            // 
            // tiposTableAdapter
            // 
            this.tiposTableAdapter.ClearBeforeFill = true;
            // 
            // RPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 488);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.TipocomboBox);
            this.Controls.Add(this.FechaNacimientodateTimePicker);
            this.Controls.Add(this.TelefonomaskedTextBox);
            this.Controls.Add(this.CedulamaskedTextBox);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TelefonosdataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "RPersonas";
            this.Text = "RPersonas";
            this.Load += new System.EventHandler(this.RPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroDetalleDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView TelefonosdataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.MaskedTextBox CedulamaskedTextBox;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.DateTimePicker FechaNacimientodateTimePicker;
        private System.Windows.Forms.ComboBox TipocomboBox;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private RegistroDetalleDBDataSet1 registroDetalleDBDataSet1;
        private System.Windows.Forms.BindingSource tiposBindingSource;
        private RegistroDetalleDBDataSet1TableAdapters.TiposTableAdapter tiposTableAdapter;
    }
}