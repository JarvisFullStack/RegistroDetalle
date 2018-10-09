using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDetalle.Utilities
{
    public class Utilidades
    {
        public static void LimpiarCampos(Form frm)
        {
            
            foreach (Control item in frm.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }

                if(item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }

                if(item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                    
                }
                

            }

            return;

        }

        public static bool ValidarForm(Form frm, ErrorProvider errorP)
        {
            bool paso = true;
            errorP.Clear();

            foreach (Control item in frm.Controls)
            {
                if(item is TextBox || item is RichTextBox)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)item).Text))
                    {
                        paso = false;
                        errorP.SetError(item, "Debe llenar este campo");
                        item.Focus();
                    }

                    if(item is MaskedTextBox)
                    {
                        paso = false;
                        if(string.IsNullOrWhiteSpace(((MaskedTextBox)item).Text.Replace("-", "")))
                        {
                            errorP.SetError(item, "Debe llenar este campo!!!");
                            item.Focus();
                        }
                    }

                    
                }


            }

            return paso;
        }

        public static bool ValidarGroupBox(GroupBox gb, ErrorProvider errorP)
        {
            bool paso = true;
            errorP.Clear();

            foreach (Control item in gb.Controls)
            {
                if (item is TextBox || item is RichTextBox)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)item).Text))
                    {
                        paso = false;
                        errorP.SetError(item, "Debe llenar este campo");
                        item.Focus();
                    }

                    if (item is MaskedTextBox)
                    {
                        paso = false;
                        if (string.IsNullOrWhiteSpace(((MaskedTextBox)item).Text.Replace("-", "")))
                        {
                            errorP.SetError(item, "Debe llenar este campo!!!");
                            item.Focus();
                        }
                    }


                }


            }

            return paso;
        }

        public static void LlenarGridFromList(DataGridView dg, List<Object> list)
        {
            dg.DataSource = list;
        }
    }
}
