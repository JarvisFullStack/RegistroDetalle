using RegistroDetalle.BLL;
using RegistroDetalle.Entidades;
using RegistroDetalle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDetalle.UI.Registros
{
    public partial class rPersonas : Form
    {

        public List<TelefonosDetalle> Detalle { get; set; }
        public int RowSelected { get; set; }
        public rPersonas()
        {
            InitializeComponent();
            this.Detalle = new List<TelefonosDetalle>();
        }


        //metodos auxiliares
        private void Limpiar()
        {
            MyErrorProvider.Clear();
            Utilidades.LimpiarCampos(this);
            this.Detalle = new List<TelefonosDetalle>();
            CargarGrid();

        }

        private Personas LlenaClase()
        {
            Personas persona = new Personas();
            persona.PersonaId = Convert.ToInt32(IDPersonaNumericUpDown.Value);
            persona.Nombre = NombreTextBox.Text;
            persona.Cedula = CedulaMaskedTextBox.Text;
            persona.Direccion = DireccionTextBox.Text;
            persona.FechaNacimiento = NacimientoDateTimePicker1.Value;

            persona.Telefonos = this.Detalle;

            return persona;

        }

        private void LlenaCampos(Personas persona)
        {
            IDPersonaNumericUpDown.Value = persona.PersonaId;
            NombreTextBox.Text = persona.Nombre;
            CedulaMaskedTextBox.Text = persona.Cedula;
            DireccionTextBox.Text = persona.Direccion;
            NacimientoDateTimePicker1.Value = persona.FechaNacimiento;

            this.Detalle = persona.Telefonos;
            CargarGrid();
        }

        private void CargarGrid()
        {
            this.DetalleDataGridView1.DataSource = null;
            this.DetalleDataGridView1.DataSource = Detalle;
        }

        private void rPersonas_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuargar_Click(object sender, EventArgs e)
        {
            bool paso = Utilidades.ValidarForm(this, MyErrorProvider);
            if (paso == true)
            {
                paso = this.Detalle.Count() > 0;
            }

            if (paso == false)
            {
                MyErrorProvider.SetError(DetalleDataGridView1, "Debe agregar algun telefono");
                TelefonoMaskedTextBox.Focus();

            }

            if (paso == true)
            {
                Personas persona = LlenaClase();
                MessageBox.Show("Se lleno la clase");
                if (persona.PersonaId > 0)
                {
                    if (PersonasBLL.Modificar(persona) == true)
                    {

                        if (Detalle.Count != 0)
                        {
                            foreach (var item in Detalle)
                            {
                                PersonasBLL.EliminarDetalle(item.Id);
                            }

                        }
                        MessageBox.Show("Modificado Correctamente!!!");
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar modificar el registro!!!");
                    }
                }
                else
                {
                    if (PersonasBLL.Guardar(persona) == true)
                    {
                        MessageBox.Show("Guardado Correctamente!!!");
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar guardar el registro!!!");
                    }
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView1.DataSource != null)
            {
                this.Detalle = (List<TelefonosDetalle>)DetalleDataGridView1.DataSource;
            }
            if (Utilidades.ValidarGroupBox(TelefonoGroupBox, MyErrorProvider) == true)
            {
                TelefonosDetalle telefonosDetalle = new TelefonosDetalle();
                telefonosDetalle.Id = 0;
                telefonosDetalle.PersonaId = (int)IDPersonaNumericUpDown.Value;
                telefonosDetalle.Telefono = TelefonoMaskedTextBox.Text;
                telefonosDetalle.TipoTelefono = TipoTextBox.Text;
                this.Detalle.Add(telefonosDetalle);
                CargarGrid();
                TelefonoMaskedTextBox.Focus();
                TelefonoMaskedTextBox.Clear();
                TipoTextBox.Clear();
            }

        }

        private void btnRemoverFila_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView1.Rows.Count > 0 && DetalleDataGridView1.CurrentRow != null)
            {
                if (RowSelected >= 0)
                {
                    Personas persona = LlenaClase();

                    TelefonosDetalle tel = persona.Telefonos.ElementAt(RowSelected);
                    Detalle.Add(new TelefonosDetalle(tel.Id, tel.PersonaId, tel.TipoTelefono, tel.Telefono));
                    persona.Telefonos.RemoveAt(RowSelected);
                    DetalleDataGridView1.DataSource = null;
                    DetalleDataGridView1.DataSource = persona.Telefonos;
                    RowSelected = -1;
                    MessageBox.Show("Eliminado!");
                }
            }
            
        }

        private void DetalleDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.RowSelected = e.RowIndex;
        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IDPersonaNumericUpDown.Value > 0)
            {
                if (PersonasBLL.Eliminar(Convert.ToInt32(IDPersonaNumericUpDown.Value)) == true)
                {
                    MessageBox.Show("Registro eliminado correctamente!!!");
                }
                else
                {
                    MessageBox.Show("Error al intentar eliminar el registro!!!");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (IDPersonaNumericUpDown.Value > 0)
            {
                Personas persona = PersonasBLL.Buscar(Convert.ToInt32(IDPersonaNumericUpDown.Value));
                LlenaCampos(persona);
                MessageBox.Show("Registro encontrado!!!");

            }
        }
    }
}

