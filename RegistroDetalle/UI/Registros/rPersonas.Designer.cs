namespace RegistroDetalle.UI.Registros
{
    partial class rPersonas
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label personaIdLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.IDPersonaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuargar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.NacimientoDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TelefonoGroupBox = new System.Windows.Forms.GroupBox();
            this.TipoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TelefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DetalleDataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemoverFila = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            nombreLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            personaIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IDPersonaNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.TelefonoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(30, 68);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 16);
            nombreLabel.TabIndex = 32;
            nombreLabel.Text = "Nombre:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matriculaLabel.Location = new System.Drawing.Point(30, 107);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(68, 16);
            matriculaLabel.TabIndex = 31;
            matriculaLabel.Text = "Direccion:";
            // 
            // personaIdLabel
            // 
            personaIdLabel.AutoSize = true;
            personaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            personaIdLabel.Location = new System.Drawing.Point(26, 14);
            personaIdLabel.Name = "personaIdLabel";
            personaIdLabel.Size = new System.Drawing.Size(78, 16);
            personaIdLabel.TabIndex = 30;
            personaIdLabel.Text = "Persona ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(30, 153);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 16);
            label1.TabIndex = 36;
            label1.Text = "Cedula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(216, 156);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 16);
            label2.TabIndex = 38;
            label2.Text = "F. Nacimiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(6, 35);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 16);
            label3.TabIndex = 38;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(183, 36);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(39, 16);
            label4.TabIndex = 41;
            label4.Text = "Tipo:";
            // 
            // IDPersonaNumericUpDown
            // 
            this.IDPersonaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPersonaNumericUpDown.Location = new System.Drawing.Point(105, 12);
            this.IDPersonaNumericUpDown.Name = "IDPersonaNumericUpDown";
            this.IDPersonaNumericUpDown.Size = new System.Drawing.Size(171, 22);
            this.IDPersonaNumericUpDown.TabIndex = 35;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.Location = new System.Drawing.Point(105, 65);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(293, 22);
            this.NombreTextBox.TabIndex = 34;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionTextBox.Location = new System.Drawing.Point(105, 107);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(293, 22);
            this.DireccionTextBox.TabIndex = 33;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::RegistroDetalle.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(278, -4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 52);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuargar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(1, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 66);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::RegistroDetalle.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(277, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 60);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuargar
            // 
            this.btnGuargar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuargar.FlatAppearance.BorderSize = 0;
            this.btnGuargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuargar.Image = global::RegistroDetalle.Properties.Resources.save;
            this.btnGuargar.Location = new System.Drawing.Point(148, 6);
            this.btnGuargar.Name = "btnGuargar";
            this.btnGuargar.Size = new System.Drawing.Size(75, 60);
            this.btnGuargar.TabIndex = 1;
            this.btnGuargar.UseVisualStyleBackColor = false;
            this.btnGuargar.Click += new System.EventHandler(this.btnGuargar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::RegistroDetalle.Properties.Resources._new;
            this.btnNuevo.Location = new System.Drawing.Point(12, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 60);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // NacimientoDateTimePicker1
            // 
            this.NacimientoDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NacimientoDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NacimientoDateTimePicker1.Location = new System.Drawing.Point(315, 155);
            this.NacimientoDateTimePicker1.Name = "NacimientoDateTimePicker1";
            this.NacimientoDateTimePicker1.Size = new System.Drawing.Size(83, 22);
            this.NacimientoDateTimePicker1.TabIndex = 39;
            // 
            // TelefonoGroupBox
            // 
            this.TelefonoGroupBox.Controls.Add(this.TipoTextBox);
            this.TelefonoGroupBox.Controls.Add(this.button1);
            this.TelefonoGroupBox.Controls.Add(this.TelefonoMaskedTextBox);
            this.TelefonoGroupBox.Controls.Add(label4);
            this.TelefonoGroupBox.Controls.Add(label3);
            this.TelefonoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoGroupBox.Location = new System.Drawing.Point(33, 197);
            this.TelefonoGroupBox.Name = "TelefonoGroupBox";
            this.TelefonoGroupBox.Size = new System.Drawing.Size(369, 77);
            this.TelefonoGroupBox.TabIndex = 40;
            this.TelefonoGroupBox.TabStop = false;
            this.TelefonoGroupBox.Text = "Agregar Telefono";
            this.TelefonoGroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TipoTextBox
            // 
            this.TipoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoTextBox.Location = new System.Drawing.Point(221, 33);
            this.TipoTextBox.Name = "TipoTextBox";
            this.TipoTextBox.Size = new System.Drawing.Size(96, 22);
            this.TipoTextBox.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::RegistroDetalle.Properties.Resources._new;
            this.button1.Location = new System.Drawing.Point(323, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 22);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelefonoMaskedTextBox
            // 
            this.TelefonoMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoMaskedTextBox.Location = new System.Drawing.Point(77, 33);
            this.TelefonoMaskedTextBox.Mask = "(###)-###-####";
            this.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox";
            this.TelefonoMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.TelefonoMaskedTextBox.TabIndex = 44;
            // 
            // DetalleDataGridView1
            // 
            this.DetalleDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView1.Location = new System.Drawing.Point(33, 281);
            this.DetalleDataGridView1.Name = "DetalleDataGridView1";
            this.DetalleDataGridView1.Size = new System.Drawing.Size(373, 124);
            this.DetalleDataGridView1.TabIndex = 41;
            this.DetalleDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalleDataGridView1_CellClick);
            // 
            // btnRemoverFila
            // 
            this.btnRemoverFila.Location = new System.Drawing.Point(33, 411);
            this.btnRemoverFila.Name = "btnRemoverFila";
            this.btnRemoverFila.Size = new System.Drawing.Size(110, 23);
            this.btnRemoverFila.TabIndex = 42;
            this.btnRemoverFila.Text = "Remover Fila";
            this.btnRemoverFila.UseVisualStyleBackColor = true;
            this.btnRemoverFila.Click += new System.EventHandler(this.btnRemoverFila_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // CedulaMaskedTextBox
            // 
            this.CedulaMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaMaskedTextBox.Location = new System.Drawing.Point(105, 150);
            this.CedulaMaskedTextBox.Mask = "###-#######-###";
            this.CedulaMaskedTextBox.Name = "CedulaMaskedTextBox";
            this.CedulaMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.CedulaMaskedTextBox.TabIndex = 43;
            // 
            // rPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 507);
            this.Controls.Add(this.CedulaMaskedTextBox);
            this.Controls.Add(this.btnRemoverFila);
            this.Controls.Add(this.DetalleDataGridView1);
            this.Controls.Add(this.TelefonoGroupBox);
            this.Controls.Add(this.NacimientoDateTimePicker1);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.IDPersonaNumericUpDown);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(personaIdLabel);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "rPersonas";
            this.Text = "rPersonas";
            this.Load += new System.EventHandler(this.rPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDPersonaNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.TelefonoGroupBox.ResumeLayout(false);
            this.TelefonoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IDPersonaNumericUpDown;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuargar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DateTimePicker NacimientoDateTimePicker1;
        private System.Windows.Forms.GroupBox TelefonoGroupBox;
        private System.Windows.Forms.DataGridView DetalleDataGridView1;
        private System.Windows.Forms.Button btnRemoverFila;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox TelefonoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CedulaMaskedTextBox;
        private System.Windows.Forms.TextBox TipoTextBox;
    }
}