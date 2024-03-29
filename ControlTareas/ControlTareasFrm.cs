﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlTareas
{
    public partial class ControlTareasFrm : Form
    {

        DBHelper dbHelper = new DBHelper();
        List<TareaModel> ListaTareas;
        TareaModel _Tarea = null;
        ConfiguracionModel _configuracion;
        const string _RutaPlantillas = "Plantillas";
        public ControlTareasFrm()
        {
            InitializeComponent();

            _configuracion = dbHelper.LeerConfiguracion();
            if (_configuracion == null)
            {
                MessageBox.Show("Se debe configurar la Ruta base y el periodo actual.");
            }
        }

        private void ControlTareasFrm_Load(object sender, EventArgs e)
        {
            dtgItemsCheck.AutoGenerateColumns = false;
            LlenarComboEstadoTarea();
            LlenarComboSprint();
            LlenarComboFuentes();
            LlenarComboTipoTarea();
            if (cmbSprint.Items.Count > 0)
            {
                LlenarGridTareas(Int32.Parse(cmbSprint.SelectedValue.ToString()));
            }
            else
            {
                MessageBox.Show("Debe registrar un sprint para comenzar a registrar tareas");
                cmbSprint.Focus();
            }
        }

        private void LlenarGridTareas(int NumeroSprint = 0, string DatoBusqueda = "")
        {

            if (DatoBusqueda == "")
            {
                ListaTareas = dbHelper.LeerTareasSprint(NumeroSprint);
            }
            else
            {
                ListaTareas = dbHelper.LeerTareasBusqueda(DatoBusqueda);
            }

            PintarGridTareas(ListaTareas);
        }

        private void PintarGridTareas(List<TareaModel> Lista)
        {
            gridTareas.Rows.Clear();
            try
            {
                //Se le agrega el to list a la lista para corregir un error que daba a la hora de cargar los datos
                foreach (TareaModel tarea in Lista.ToList())
                {
                    gridTareas.Rows.Add();
                    gridTareas.Rows[gridTareas.Rows.Count - 1].Cells["Tarea"].Value = tarea.NumeroTarea;
                    gridTareas.Rows[gridTareas.Rows.Count - 1].Cells["Descripcion"].Value = tarea.Descripcion;

                    PintarEstado(tarea.Estado, gridTareas.Rows.Count - 1);
                    PintarTipoTarea(tarea.TipoTarea, gridTareas.Rows.Count - 1);
                }
                lblCantidad.Text = gridTareas.Rows.Count.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void PintarTipoTarea(int TipoTarea, int fila)
        {
            switch (TipoTarea)
            {
                case (int)TipoTareaEnum.ProductBacklogItem:
                    gridTareas.Rows[fila].Cells["TipoTarea"].Value = "PBI";
                    gridTareas.Rows[fila].Cells[0].Style.BackColor = System.Drawing.Color.FromArgb(0, 199, 53);
                    break;
                case (int)TipoTareaEnum.Bug:
                    gridTareas.Rows[fila].Cells["TipoTarea"].Value = "BUG";
                    gridTareas.Rows[fila].Cells[0].Style.BackColor = System.Drawing.Color.FromArgb(0, 157, 201);
                    break;
                case (int)TipoTareaEnum.BugHelpDesk:
                    gridTareas.Rows[fila].Cells["TipoTarea"].Value = "BHD";
                    gridTareas.Rows[fila].Cells[0].Style.BackColor = System.Drawing.Color.FromArgb(229, 5, 47);
                    break;
                case (int)TipoTareaEnum.InternalImprovement:
                    gridTareas.Rows[fila].Cells["TipoTarea"].Value = "Internal";
                    gridTareas.Rows[fila].Cells[0].Style.BackColor = System.Drawing.Color.FromArgb(255, 112, 250);
                    break;
                case (int)TipoTareaEnum.Test:
                    gridTareas.Rows[fila].Cells["TipoTarea"].Value = "Test";
                    gridTareas.Rows[fila].Cells[0].Style.BackColor = System.Drawing.Color.FromArgb(188, 13, 252);
                    break;
                case (int)TipoTareaEnum.QA:
                    gridTareas.Rows[fila].Cells["TipoTarea"].Value = "QA";
                    gridTareas.Rows[fila].Cells[0].Style.BackColor = System.Drawing.Color.FromArgb(95, 47, 0);
                    break;
            }
        }

        private void PintarEstado(int estado, int fila)
        {
            if (estado == (int)EstadoTareaEnum.Creada)
            {
                gridTareas.Rows[fila].Cells["Tarea"].Style.BackColor = System.Drawing.Color.White;
                gridTareas.Rows[fila].Cells["Descripcion"].Style.BackColor = System.Drawing.Color.White;
            }
            else if (estado == (int)EstadoTareaEnum.Iniciada)
            {
                gridTareas.Rows[fila].Cells["Tarea"].Style.BackColor = System.Drawing.Color.FromArgb(254, 246, 91);
                gridTareas.Rows[fila].Cells["Descripcion"].Style.BackColor = System.Drawing.Color.FromArgb(254, 246, 91);
            }
            else if (estado == (int)EstadoTareaEnum.Finalizada)
            {
                gridTareas.Rows[fila].Cells["Tarea"].Style.BackColor = System.Drawing.Color.LightGreen;
                gridTareas.Rows[fila].Cells["Descripcion"].Style.BackColor = System.Drawing.Color.LightGreen;
            }
        }

        private void LlenarComboSprint()
        {
            cmbSprint.DisplayMember = "Numero";
            cmbSprint.ValueMember = "Numero";
            cmbSprint.DataSource = dbHelper.LeerSprints();

            cmbSprintCargado.DisplayMember = "Numero";
            cmbSprintCargado.ValueMember = "Numero";
            cmbSprintCargado.DataSource = dbHelper.LeerSprints();
        }

        private void LlenarComboFuentes()
        {
            cmbFuentes.DisplayMember = "Fuente";
            cmbFuentes.ValueMember = "Id";
            cmbFuentes.DataSource = dbHelper.LeerFuentes();
            cmbFuentes.SelectedIndex = -1;
        }

        private void LlenarComboEstadoTarea()
        {
            DataTable data = new DataTable();
            data.Columns.Add("value");
            data.Columns.Add("text");

            var row = data.NewRow();
            row[0] = (int)EstadoTareaEnum.Creada;
            row[1] = "Creada";

            data.Rows.Add(row);

            row = data.NewRow();
            row[0] = (int)EstadoTareaEnum.Iniciada;
            row[1] = "Iniciada";

            data.Rows.Add(row);

            row = data.NewRow();
            row[0] = (int)EstadoTareaEnum.Finalizada;
            row[1] = "Finalizada";

            data.Rows.Add(row);

            cmbEstado.DisplayMember = "text";
            cmbEstado.ValueMember = "value";
            cmbEstado.DataSource = data;
        }

        private void LlenarComboTipoTarea()
        {
            DataTable data = new DataTable();
            data.Columns.Add("value");
            data.Columns.Add("text");

            var row = data.NewRow();
            row[0] = (int)TipoTareaEnum.ProductBacklogItem;
            row[1] = "PBI";
            data.Rows.Add(row);

            row = data.NewRow();
            row[0] = (int)TipoTareaEnum.Bug;
            row[1] = "Bug";
            data.Rows.Add(row);

            row = data.NewRow();
            row[0] = (int)TipoTareaEnum.BugHelpDesk;
            row[1] = "BHD";
            data.Rows.Add(row);

            row = data.NewRow();
            row[0] = (int)TipoTareaEnum.InternalImprovement;
            row[1] = "Internal";
            data.Rows.Add(row);

            row = data.NewRow();
            row[0] = (int)TipoTareaEnum.Test;
            row[1] = "Test";
            data.Rows.Add(row);

            cmbTipoTareaCargada.DisplayMember = "text";
            cmbTipoTareaCargada.ValueMember = "value";
            cmbTipoTareaCargada.DataSource = data;

            row = data.NewRow();
            row[0] = (int)TipoTareaEnum.QA;
            row[1] = "QA";
            data.Rows.Add(row);

            cmbTipoTareaCargada.DisplayMember = "text";
            cmbTipoTareaCargada.ValueMember = "value";
            cmbTipoTareaCargada.DataSource = data;

            data = new DataTable();
            data.Columns.Add("value");
            data.Columns.Add("text");

            row = data.NewRow();
            row[0] = (int)TipoTareaEnum.ProductBacklogItem;
            row[1] = "PBI";
            data.Rows.Add(row);

            row = data.NewRow();
            row[0] = (int)TipoTareaEnum.Bug;
            row[1] = "Bug";
            data.Rows.Add(row);

            row = data.NewRow();
            row[0] = (int)TipoTareaEnum.BugHelpDesk;
            row[1] = "BHD";
            data.Rows.Add(row);

            row = data.NewRow();
            row[0] = (int)TipoTareaEnum.InternalImprovement;
            row[1] = "Internal";
            data.Rows.Add(row);

            row = data.NewRow();
            row[0] = (int)TipoTareaEnum.Test;
            row[1] = "Test";
            data.Rows.Add(row);

            row = data.NewRow();
            row[0] = (int)TipoTareaEnum.QA;
            row[1] = "QA";
            data.Rows.Add(row);

            cmbTipoTarea.DisplayMember = "text";
            cmbTipoTarea.ValueMember = "value";
            cmbTipoTarea.DataSource = data;
        }

        private void cmbSprint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(cmbSprint.Text, out var n))
                {
                    SprintModel sprint = new SprintModel();
                    sprint.Numero = Int32.Parse(cmbSprint.Text.Trim());
                    dbHelper.RegistrarSprint(sprint);
                    LlenarComboSprint();
                    MessageBox.Show("Sprint registrado");
                }
                else
                {
                    MessageBox.Show("Debe digitar un número entero");
                }
            }
        }

        private void gridTareas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gridTareas.Columns[e.ColumnIndex].Name == "Tarea")
            {
                string NumeroTarea = "";
                if (gridTareas.Rows[e.RowIndex].Cells["Tarea"].Value != null)
                {
                    NumeroTarea = gridTareas.Rows[e.RowIndex].Cells["Tarea"].Value.ToString();
                }

                if (NumeroTarea.Trim() != "")
                {
                    //se modifica la tarea
                    if (dbHelper.VerificaExisteTarea(NumeroTarea, _Tarea.Id))
                    {
                        MessageBox.Show("El número ya existe en otra tarea");
                        gridTareas.Rows[e.RowIndex].Cells["Tarea"].Value = _Tarea.NumeroTarea;
                        return;
                    }

                    if (NumeroTarea != _Tarea.NumeroTarea)
                    {
                        _Tarea.NumeroTarea = NumeroTarea;
                        dbHelper.ActualizarTarea(_Tarea);
                        CargarTarea();
                    }
                }
                else
                {
                    gridTareas.Rows[e.RowIndex].Cells["Tarea"].Value = _Tarea.NumeroTarea;
                    MessageBox.Show("La tarea no debe ir en blanco");
                }
            }
            else if (gridTareas.Columns[e.ColumnIndex].Name == "Descripcion")
            {
                string Descripcion = "";
                if (gridTareas.Rows[e.RowIndex].Cells["Descripcion"].Value != null)
                {
                    Descripcion = gridTareas.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                }

                if (Descripcion.Trim() != "")
                {
                    _Tarea.Descripcion = Descripcion;
                    dbHelper.ActualizarTarea(_Tarea);
                    CargarTarea();
                }
                else
                {
                    gridTareas.Rows[e.RowIndex].Cells["Descripcion"].Value = _Tarea.Descripcion;
                    MessageBox.Show("La descripción no debe ir en blanco");
                }
            }
        }
        private void txtNumeroTarea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbSprint.Items.Count == 0 || cmbSprint.SelectedIndex < 0)
                {
                    MessageBox.Show("Debe seleccionar un sprint para continuar");
                    cmbSprint.Focus();
                    return;
                }

                if (txtNumeroTarea.Text.Trim() == "")
                {
                    MessageBox.Show("El número de tarea no puede quedar en blanco");
                    return;
                }

                if (txtDescripcion.Text.Trim() == "")
                {
                    txtDescripcion.Focus();
                }
                else
                {
                    if (!dbHelper.VerificaExisteTarea(txtNumeroTarea.Text.Trim()))
                    {
                        //crea la tarea
                        TareaModel tarea = new TareaModel();
                        tarea.NumeroTarea = txtNumeroTarea.Text.Trim();
                        tarea.Descripcion = txtDescripcion.Text.Trim();
                        tarea.Sprint = Int32.Parse(cmbSprint.SelectedValue.ToString());
                        tarea.TipoTarea = Int32.Parse(cmbTipoTarea.SelectedValue.ToString());
                        dbHelper.RegistrarTarea(tarea);
                        LlenarGridTareas(Int32.Parse(cmbSprint.SelectedValue.ToString()));
                        LimpiarCampos();
                        gridTareas.Focus();
                    }
                    else
                    {
                        txtNumeroTarea.Focus();
                        MessageBox.Show("El número de tarea ya existe");
                    }
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNumeroTarea.Text = "";
            txtDescripcion.Text = "";
            cmbTipoTarea.SelectedIndex = 0;
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_configuracion == null)
                {
                    MessageBox.Show("Debe realizar la configuracion inicial para continuar.");
                    return;
                }

                if (cmbSprint.Items.Count == 0 || cmbSprint.SelectedIndex < 0)
                {
                    MessageBox.Show("Debe seleccionar un sprint para continuar");
                    cmbSprint.Focus();
                    return;
                }
                if (txtDescripcion.Text.Trim() == "")
                {
                    MessageBox.Show("La descripción no puede quedar en blanco");
                    return;
                }

                if (txtNumeroTarea.Text.Trim() == "")
                {
                    txtNumeroTarea.Focus();
                }
                else
                {
                    if (!dbHelper.VerificaExisteTarea(txtNumeroTarea.Text.Trim()))
                    {
                        //crea la tarea
                        TareaModel tarea = new TareaModel();
                        tarea.NumeroTarea = txtNumeroTarea.Text.Trim();
                        tarea.Descripcion = txtDescripcion.Text.Trim();
                        tarea.Sprint = Int32.Parse(cmbSprint.SelectedValue.ToString());
                        tarea.TipoTarea = Int32.Parse(cmbTipoTarea.SelectedValue.ToString());
                        string descripcion = txtDescripcion.Text.Trim();
                        if (descripcion.Length > 70)
                        {
                            descripcion = descripcion.Substring(0, 70);
                        }
                        tarea.RutaCarpeta = _configuracion.RutaBase + "\\" + _configuracion.Periodo.ToString() + "\\" + Int32.Parse(cmbSprint.SelectedValue.ToString()).ToString("D3") + "\\" + txtNumeroTarea.Text.Trim() + " " + descripcion;

                        if (!Directory.Exists(tarea.RutaCarpeta))
                        {
                            Directory.CreateDirectory(tarea.RutaCarpeta);
                        }

                        dbHelper.RegistrarTarea(tarea);
                        LlenarGridTareas(Int32.Parse(cmbSprint.SelectedValue.ToString()));
                        LimpiarCampos();
                        gridTareas.Focus();
                    }
                    else
                    {
                        txtNumeroTarea.Focus();
                        MessageBox.Show("El número de tarea ya existe");
                    }
                }
            }
        }

        private void cmbSprint_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarTarea();
            LlenarGridTareas(Int32.Parse(cmbSprint.SelectedValue.ToString()));
            gridTareas.Focus();
        }

        private void CargarTarea()
        {
            txtTareaCargada.Text = _Tarea.NumeroTarea;
            txtDesciprcionCargada.Text = _Tarea.Descripcion;
            cmbSprintCargado.SelectedValue = _Tarea.Sprint;
            txtEstimado.Text = _Tarea.Estimado.ToString();
            rtbNotas.Text = _Tarea.Notas;
            cmbEstado.SelectedValue = _Tarea.Estado;
            lblFechaInicio.Text = _Tarea.FechaInicio.ToShortDateString() + " " + _Tarea.FechaInicio.ToShortTimeString();
            lblFechaFin.Text = _Tarea.FechaFin.ToShortDateString() + " " + _Tarea.FechaFin.ToShortTimeString();
            txtPrioridad.Text = _Tarea.Prioridad.ToString();
            txtTareaRevision.Text = _Tarea.NumeroTareaRevision;
            cmbTipoTareaCargada.SelectedValue = _Tarea.TipoTarea.ToString();
            txtRutaCarpetaTarea.Text = _Tarea.RutaCarpeta;
            gridCheckIn.Rows.Clear();
            gridFuentes.Rows.Clear();
            dtgItemsCheck.Rows.Clear();

            if (_Tarea.ListaCheckIn != null)
            {
                foreach (string CheckIn in _Tarea.ListaCheckIn)
                {
                    gridCheckIn.Rows.Add();
                    gridCheckIn.Rows[gridCheckIn.Rows.Count - 1].Cells["CheckIn"].Value = CheckIn;
                }
            }

            if (_Tarea.ListaFuentes != null)
            {
                foreach (string Fuente in _Tarea.ListaFuentes)
                {
                    gridFuentes.Rows.Add();
                    gridFuentes.Rows[gridFuentes.Rows.Count - 1].Cells["Fuentes"].Value = Fuente;
                }
            }

            if (_Tarea.ListaChecks != null)
            {
                foreach (CheckItem Item in _Tarea.ListaChecks)
                {
                    dtgItemsCheck.Rows.Add();
                    dtgItemsCheck.Rows[dtgItemsCheck.Rows.Count - 1].Cells["chkItemMarcado"].Value = Item.Marcada;
                    dtgItemsCheck.Rows[dtgItemsCheck.Rows.Count - 1].Cells["CheckItemText"].Value = Item.Descripcion;
                }
            }
        }

        private void txtTareaCargada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_Tarea != null)
                {
                    if (txtTareaCargada.Text.Trim() == "")
                    {
                        txtTareaCargada.Text = _Tarea.NumeroTarea;
                        MessageBox.Show("El número de la tarea no puede quedar en blanco");
                        return;
                    }

                    _Tarea.NumeroTarea = txtTareaCargada.Text;
                    if (dbHelper.VerificaExisteTarea(_Tarea.NumeroTarea, _Tarea.Id))
                    {
                        MessageBox.Show("Ya existe el número en otra tarea");
                        return;
                    }

                    dbHelper.ActualizarTarea(_Tarea);
                    ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
                    gridTareas.Rows[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)].Cells["Tarea"].Value = _Tarea.NumeroTarea;
                    txtEstimado.Focus();
                }
            }
        }

        private void txtDesciprcionCargada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_Tarea != null)
                {
                    if (txtDesciprcionCargada.Text.Trim() == "")
                    {
                        txtDesciprcionCargada.Text = _Tarea.Descripcion;
                        MessageBox.Show("La descripción no debe ir en blanco");
                    }

                    _Tarea.Descripcion = txtDesciprcionCargada.Text.Trim();
                    dbHelper.ActualizarTarea(_Tarea);
                    ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
                    gridTareas.Rows[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)].Cells["Descripcion"].Value = _Tarea.Descripcion;
                    cmbEstado.Focus();
                }
            }
        }

        private void txtEstimado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_Tarea != null)
                {
                    if (int.TryParse(txtEstimado.Text, out var n))
                    {
                        _Tarea.Estimado = Byte.Parse(txtEstimado.Text);
                        dbHelper.ActualizarTarea(_Tarea);
                        ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
                        txtPrioridad.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Debe digitar un número entero");
                    }
                }
            }
        }

        private void txtCheckIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_Tarea != null)
                {
                    if (txtCheckIn.Text.Trim() == "")
                    {
                        MessageBox.Show("El Check In no debe ir en blanco");
                        return;
                    }

                    if (_Tarea.ListaCheckIn == null)
                    {
                        _Tarea.ListaCheckIn = new List<string>();
                    }

                    _Tarea.ListaCheckIn.Add(txtCheckIn.Text.Trim());

                    dbHelper.ActualizarTarea(_Tarea);
                    ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
                    txtCheckIn.Text = "";
                    CargarTarea();
                }
            }
        }

        private void gridTareas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gridTareas.RowCount > 0 && gridTareas.CurrentCell.RowIndex >= 0)
            {
                int filaActual = gridTareas.CurrentCell.RowIndex;

                if (MessageBox.Show("¿Desea eliminar la tarea?", "Eliminar tarea", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dbHelper.EliminarTarea(ListaTareas[filaActual]);
                    gridTareas.Rows.RemoveAt(filaActual);
                    ListaTareas.RemoveAt(filaActual);
                    LimpiarTarea();
                    lblCantidad.Text = gridTareas.Rows.Count.ToString();

                    if (gridTareas.RowCount > 0)
                    {
                        gridTareas.Rows[0].Cells[0].Selected = true;
                    }
                }
            }
        }

        private void gridCheckIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gridCheckIn.RowCount > 0 && gridCheckIn.CurrentCell.RowIndex >= 0)
            {

                int filaActual = gridCheckIn.CurrentCell.RowIndex;

                if (MessageBox.Show("¿Desea eliminar el Check In?", "Eliminar Check In", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _Tarea.ListaCheckIn.RemoveAt(filaActual);
                    gridCheckIn.Rows.RemoveAt(filaActual);
                    dbHelper.ActualizarTarea(_Tarea);
                    ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
                }
            }
        }


        private void gridFuentes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gridFuentes.RowCount > 0 && gridFuentes.CurrentCell.RowIndex >= 0)
            {
                int filaActual = gridFuentes.CurrentCell.RowIndex;

                if (MessageBox.Show("¿Desea eliminar la fuente?", "Eliminar Fuente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _Tarea.ListaFuentes.RemoveAt(filaActual);
                    gridFuentes.Rows.RemoveAt(filaActual);
                    dbHelper.ActualizarTarea(_Tarea);
                    ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
                }
            }
        }

        private void LimpiarTarea()
        {
            _Tarea = null;
            txtTareaCargada.Text = "";
            try
            {
                cmbSprintCargado.SelectedIndex = 0;
                cmbEstado.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }

            txtEstimado.Text = "";
            txtDesciprcionCargada.Text = "";
            lblFechaInicio.Text = new DateTime(1900, 1, 1).ToLongDateString();
            lblFechaFin.Text = new DateTime(1900, 1, 1).ToLongDateString();
            txtCheckIn.Text = "";
            txtTareaRevision.Text = "";
            cmbFuentes.SelectedIndex = -1;
            gridCheckIn.Rows.Clear();
            gridFuentes.Rows.Clear();
        }

        private void gridCheckIn_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string checkin = "";
            if (gridCheckIn.Rows[e.RowIndex].Cells["CheckIn"].Value != null)
            {
                checkin = gridCheckIn.Rows[e.RowIndex].Cells["CheckIn"].Value.ToString();
            }

            if (checkin != "")
            {
                _Tarea.ListaCheckIn[e.RowIndex] = checkin;
                dbHelper.ActualizarTarea(_Tarea);
                ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
            }
            else
            {
                gridCheckIn.Rows[e.RowIndex].Cells["CheckIn"].Value = _Tarea.ListaCheckIn[e.RowIndex];
                MessageBox.Show("El Check In no puede quedar en blanco");
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
                _Tarea.ListaFuentes[e.RowIndex] = fuentes;
                dbHelper.ActualizarTarea(_Tarea);
                ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
            }
            else
            {
                gridFuentes.Rows[e.RowIndex].Cells["Fuentes"].Value = _Tarea.ListaFuentes[e.RowIndex];
                MessageBox.Show("Las fuentes no pueden quedar en blanco");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "")
            {
                cmbSprint.Enabled = true;
                LlenarGridTareas(Int32.Parse(cmbSprint.SelectedValue.ToString()));
            }
            else
            {
                LlenarGridTareas(0, txtBuscar.Text.Trim());
                cmbSprint.Enabled = false;
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            LlenarGridTareas(Int32.Parse(cmbSprint.SelectedValue.ToString()));
            LimpiarTarea();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtBuscar.Text = "";
                LimpiarTarea();
                LlenarGridTareas(Int32.Parse(cmbSprint.SelectedValue.ToString()));
            }
        }

        private void cmbFuentes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_Tarea != null)
                {
                    if (cmbFuentes.Text.Trim() == "")
                    {
                        MessageBox.Show("Las fuentes no debe ir en blanco");
                        return;
                    }

                    if (_Tarea.ListaFuentes == null)
                    {
                        _Tarea.ListaFuentes = new List<string>();
                    }

                    _Tarea.ListaFuentes.Add(cmbFuentes.Text.Trim());

                    dbHelper.ActualizarTarea(_Tarea);
                    ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
                    var fuente = new FuentesModel();
                    fuente.Fuente = cmbFuentes.Text.Trim();
                    dbHelper.RegistrarFuente(fuente);
                    cmbFuentes.Text = "";
                    LlenarComboFuentes();
                    CargarTarea();
                }
            }
        }

        private void ControlTareasFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var formulario = new MantenimientoCatalogosFrm();
                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    LlenarComboFuentes();
                    LlenarComboSprint();
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                var formulario = new ConfiguracionFrm();
                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    LimpiarTarea();
                    LlenarGridTareas(Int32.Parse(cmbSprint.SelectedValue.ToString()));
                    gridTareas.Focus();
                }
            }
        }

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            if (_Tarea != null)
            {
                _Tarea.Notas = rtbNotas.Text.Trim();
                dbHelper.ActualizarTarea(_Tarea);
                ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
                txtCheckIn.Focus();
            }
        }

        private void gridTareas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                _Tarea = ListaTareas[gridTareas.CurrentCell.RowIndex];
                CargarTarea();
                panelTabs.SelectTab(0);
            }
            catch (Exception ex)
            {
            }
        }

        private void txtPrioridad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_Tarea != null)
                {
                    if (int.TryParse(txtPrioridad.Text, out var n))
                    {
                        _Tarea.Prioridad = Int32.Parse(txtPrioridad.Text);
                        dbHelper.ActualizarTarea(_Tarea);
                        ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
                        txtDesciprcionCargada.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Debe digitar un número entero");
                    }
                }
            }
        }

        private void cmbTipoTareaCargada_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_Tarea != null)
            {
                _Tarea.TipoTarea = Int32.Parse(cmbTipoTareaCargada.SelectedValue.ToString());
                dbHelper.ActualizarTarea(_Tarea);
                LlenarGridTareas(Int32.Parse(cmbSprint.SelectedValue.ToString()));
                gridTareas.Focus();
            }
        }

        private void cmbSprintCargado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_Tarea != null)
            {
                _Tarea.Sprint = Int32.Parse(cmbSprintCargado.SelectedValue.ToString());
                dbHelper.ActualizarTarea(_Tarea);
                LlenarGridTareas(Int32.Parse(cmbSprint.SelectedValue.ToString()));
                gridTareas.Focus();
            }
        }

        private void cmbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_Tarea != null)
            {
                _Tarea.Estado = Byte.Parse(cmbEstado.SelectedValue.ToString());

                if (_Tarea.Estado == (int)EstadoTareaEnum.Creada)
                {
                    _Tarea.FechaInicio = new DateTime(1900, 1, 1);
                    _Tarea.FechaFin = new DateTime(1900, 1, 1);
                }
                else if (_Tarea.Estado == (int)EstadoTareaEnum.Iniciada)
                {
                    _Tarea.FechaInicio = DateTime.Now;
                    _Tarea.FechaFin = new DateTime(1900, 1, 1);
                }
                else
                {
                    _Tarea.FechaFin = DateTime.Now;
                }

                dbHelper.ActualizarTarea(_Tarea);
                ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
                PintarEstado(_Tarea.Estado, ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id));
                CargarTarea();
            }
        }

        private void txtTareaRevision_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_Tarea != null)
                {
                    _Tarea.NumeroTareaRevision = txtTareaRevision.Text;
                    dbHelper.ActualizarTarea(_Tarea);
                    ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
                }
            }
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            if (_Tarea.RutaCarpeta != null && Directory.Exists(_Tarea.RutaCarpeta))
            {
                System.Diagnostics.Process.Start("explorer.exe", _Tarea.RutaCarpeta);
            }
            else
            {
                MessageBox.Show("No se encuentra la ruta.");
            }
        }

        private void btnCrearPlantillas_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaActual = Directory.GetCurrentDirectory();
                string rutaPlantillas = System.IO.Path.Combine(rutaActual, _RutaPlantillas);
                string[] files = System.IO.Directory.GetFiles(rutaPlantillas);
                string nombreArchivo = "";
                string rutaDestino = "";

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    nombreArchivo = System.IO.Path.GetFileName(s);
                    rutaDestino = System.IO.Path.Combine(_Tarea.RutaCarpeta, nombreArchivo);
                    System.IO.File.Copy(s, rutaDestino, false);
                }

                //Plantilla Cambios

                string rutaPantillaCambios = System.IO.Path.Combine(_Tarea.RutaCarpeta, "PlantillaCambios.docx");

                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document document = wordApp.Documents.Open(rutaPantillaCambios);

                wordApp.Visible = false;

                document.Bookmarks["NumeroTarea"].Select();
                wordApp.Selection.TypeText(_Tarea.NumeroTarea);

                document.Bookmarks["NombreTarea"].Select();
                wordApp.Selection.TypeText(_Tarea.Descripcion);

                string fuentes = "";
                if (_Tarea.ListaFuentes != null && _Tarea.ListaFuentes.Count > 0)
                {
                    foreach (string fuente in _Tarea.ListaFuentes)
                    {
                        fuentes += fuente + "/";
                    }

                    fuentes = fuentes.Substring(0, fuentes.Length - 1);
                }

                document.Bookmarks["Fuentes"].Select();
                wordApp.Selection.TypeText(fuentes);

                string checkins = "";

                if (_Tarea.ListaCheckIn != null && _Tarea.ListaCheckIn.Count > 0)
                {
                    foreach (string checkin in _Tarea.ListaCheckIn)
                    {
                        checkins += checkin + "/";
                    }

                    checkins = checkins.Substring(0, checkins.Length - 1);
                }

                document.Bookmarks["CheckIn"].Select();
                wordApp.Selection.TypeText(checkins);

                document.Bookmarks["FechaInicio"].Select();
                wordApp.Selection.TypeText(_Tarea.FechaInicio.ToString("dd/MM/yyyy"));

                document.Bookmarks["FechaFinal"].Select();
                wordApp.Selection.TypeText(_Tarea.FechaFin.ToString("dd/MM/yyyy"));

                document.Save();
                document.Close();
                wordApp.Quit();

                try
                {
                    checkins = checkins.Replace("/", "_");
                    string plantillaCambiosNueva = System.IO.Path.Combine(_Tarea.RutaCarpeta, DateTime.Now.ToString("yyyyMMdd") + " " + "(SIIGC2) " + _Tarea.NumeroTarea.ToString() + "-" + checkins + " " + _Tarea.Descripcion + ".docx");
                    System.IO.File.Move(rutaPantillaCambios, plantillaCambiosNueva);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Renombrar plantilla cambios: ", ex.Message);
                }

                //PlantillaPruebas
                string rutaPlantillaPruebas = System.IO.Path.Combine(_Tarea.RutaCarpeta, "PlantillaPruebas.docx");
                wordApp = new Microsoft.Office.Interop.Word.Application();
                document = wordApp.Documents.Open(rutaPlantillaPruebas);

                wordApp.Visible = false;

                document.Bookmarks["NumeroTarea"].Select();
                wordApp.Selection.TypeText(_Tarea.NumeroTarea);

                document.Bookmarks["NombreTarea"].Select();
                wordApp.Selection.TypeText(_Tarea.Descripcion);

                document.Bookmarks["Sprint"].Select();
                wordApp.Selection.TypeText(_Tarea.Sprint.ToString());

                document.Bookmarks["FechaPrueba"].Select();
                wordApp.Selection.TypeText(_Tarea.FechaFin.ToString("dd/MM/yyyy"));

                document.Bookmarks["TareaRevision"].Select();
                wordApp.Selection.TypeText(_Tarea.NumeroTareaRevision);

                document.Save();
                document.Close();
                wordApp.Quit();

                try
                {
                    string plantillaPruebasNueva = System.IO.Path.Combine(_Tarea.RutaCarpeta, "(DEV) " + _Tarea.NumeroTarea.ToString() + "-" + _Tarea.NumeroTareaRevision + " " + _Tarea.Descripcion + " " + _Tarea.FechaFin.ToString("dd_MM_yyyy") + ".docx");
                    System.IO.File.Move(rutaPlantillaPruebas, plantillaPruebasNueva);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Renombrar plantilla prueba: ", ex.Message);
                }

                MessageBox.Show("Creadas.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRutaCarpetaTarea_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtRutaCarpetaTarea.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una ruta.");
                return;
            }

            _Tarea.RutaCarpeta = txtRutaCarpetaTarea.Text;
            dbHelper.ActualizarTarea(_Tarea);
        }

        private void btnBuscarRutaTarea_Click(object sender, EventArgs e)
        {
            using (var fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    txtRutaCarpetaTarea.Text = fd.SelectedPath;
                    _Tarea.RutaCarpeta = txtRutaCarpetaTarea.Text;
                    dbHelper.ActualizarTarea(_Tarea);

                }
            }
        }

        private void txtDescripcionCheckItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_Tarea != null)
                {
                    if (txtDescripcionCheckItem.Text.Trim() == "")
                    {
                        MessageBox.Show("La descripción no debe ir en blanco");
                        return;
                    }

                    if (_Tarea.ListaChecks == null)
                    {
                        _Tarea.ListaChecks = new List<CheckItem>();
                    }

                    _Tarea.ListaChecks.Add(new CheckItem { Descripcion = txtDescripcionCheckItem.Text.Trim() });

                    dbHelper.ActualizarTarea(_Tarea);
                    ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
                    txtDescripcionCheckItem.Text = "";
                    CargarTarea();
                }
            }
        }

        private void dtgItemsCheck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dtgItemsCheck.RowCount > 0 && dtgItemsCheck.CurrentCell.RowIndex >= 0)
            {

                int filaActual = dtgItemsCheck.CurrentCell.RowIndex;

                if (MessageBox.Show("¿Desea borrar el check Item?", "Eliminar Check Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _Tarea.ListaChecks.RemoveAt(filaActual);
                    dtgItemsCheck.Rows.RemoveAt(filaActual);
                    dbHelper.ActualizarTarea(_Tarea);
                    ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
                }
            }
        }
        private void dtgItemsCheck_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgItemsCheck.Columns[e.ColumnIndex].Name == "CheckItemText")
            {
                _Tarea.ListaChecks[e.RowIndex].Descripcion = dtgItemsCheck.Rows[e.RowIndex].Cells["CheckItemText"].Value.ToString().Trim();
                dbHelper.ActualizarTarea(_Tarea);
                ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
            }
            else if(dtgItemsCheck.Columns[e.ColumnIndex].Name == "chkItemMarcado")
            {
                _Tarea.ListaChecks[e.RowIndex].Marcada = (bool)dtgItemsCheck.Rows[e.RowIndex].Cells["chkItemMarcado"].Value;
                dbHelper.ActualizarTarea(_Tarea);
                ListaTareas[ListaTareas.FindLastIndex(x => x.Id == _Tarea.Id)] = _Tarea;
            }
        }
    }
}
