using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlTareas
{
    public partial class MantenimientoCatalogosFrm : Form
    {
        List<SprintModel> ListaSprints;
        List<FuentesModel> ListaFuentes;
        DBHelper dbHelper = new DBHelper();
        public MantenimientoCatalogosFrm()
        {
            InitializeComponent();
        }

        private void MantenimientoCatalogosFrm_Load(object sender, EventArgs e)
        {
            ListaSprints = dbHelper.LeerSprints();
            ListaFuentes = dbHelper.LeerFuentes();

            gridSprints.Rows.Clear();
            if (ListaSprints != null)
            {

                foreach (SprintModel sprint in ListaSprints)
                {
                    gridSprints.Rows.Add();
                    gridSprints.Rows[gridSprints.RowCount - 1].Cells["Sprint"].Value = sprint.Numero;
                }
            }

            gridFuentes.Rows.Clear();
            if (ListaFuentes != null)
            {
                foreach (FuentesModel fuente in ListaFuentes)
                {
                    gridFuentes.Rows.Add();
                    gridFuentes.Rows[gridFuentes.RowCount - 1].Cells["Fuentes"].Value = fuente.Fuente;
                }
            }
        }

        private void gridSprints_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                int fila = gridSprints.CurrentCell.RowIndex;

                if (MessageBox.Show("¿Desea eliminar el sprint?", "Eliminar sprint", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dbHelper.ExisteSprintEnTarea(ListaSprints[fila].Numero))
                    {
                        MessageBox.Show("Existen tareas en este sprint, no se puede eliminar");
                    }
                    else
                    {
                        dbHelper.EliminarSprint(ListaSprints[fila]);
                        ListaSprints.RemoveAt(fila);
                        gridSprints.Rows.RemoveAt(fila);
                    }
                }
            }
        }

        private void gridFuentes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("¿Desea eliminar la fuente?", "Eliminar fuente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int fila = gridFuentes.CurrentCell.RowIndex;
                    dbHelper.EliminarFuente(ListaFuentes[fila]);
                    ListaFuentes.RemoveAt(fila);
                    gridFuentes.Rows.RemoveAt(fila);
                }
            }
        }

        private void gridFuentes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string fuentes = "";
            if (gridFuentes.Rows[e.RowIndex].Cells["Fuentes"].Value != null)
            {
                fuentes = gridFuentes.Rows[e.RowIndex].Cells["Fuentes"].Value.ToString();
            }

            if (fuentes != "")
            {
                ListaFuentes[e.RowIndex].Fuente = fuentes;
                dbHelper.ActualizarFuente(ListaFuentes[e.RowIndex]);
            }
            else
            {
                gridFuentes.Rows[e.RowIndex].Cells["Fuentes"].Value = ListaFuentes[e.RowIndex].Fuente;
                MessageBox.Show("Las fuentes no pueden quedar en blanco");
            }
        }

        private void MantenimientoCatalogosFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
