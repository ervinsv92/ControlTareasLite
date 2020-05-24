namespace ControlTareas
{
    partial class ControlTareasFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlTareasFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbFuentes = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSprintCargado = new System.Windows.Forms.ComboBox();
            this.txtEstimado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gridFuentes = new System.Windows.Forms.DataGridView();
            this.Fuentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCheckIn = new System.Windows.Forms.DataGridView();
            this.CheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesciprcionCargada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTareaCargada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridTareas = new System.Windows.Forms.DataGridView();
            this.Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSprint = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumeroTarea = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ttControles = new System.Windows.Forms.ToolTip(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cmbFuentes);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtCheckIn);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cmbSprintCargado);
            this.panel1.Controls.Add(this.txtEstimado);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblFechaFin);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblFechaInicio);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.gridFuentes);
            this.panel1.Controls.Add(this.gridCheckIn);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDesciprcionCargada);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTareaCargada);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(625, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 552);
            this.panel1.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 535);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(220, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "Del/Sup eliminar fila seleccionada";
            // 
            // cmbFuentes
            // 
            this.cmbFuentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuentes.FormattingEnabled = true;
            this.cmbFuentes.Location = new System.Drawing.Point(221, 259);
            this.cmbFuentes.Name = "cmbFuentes";
            this.cmbFuentes.Size = new System.Drawing.Size(322, 24);
            this.cmbFuentes.TabIndex = 14;
            this.ttControles.SetToolTip(this.cmbFuentes, "Enter para registrar sprint");
            this.cmbFuentes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFuentes_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(218, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Fuentes";
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckIn.Location = new System.Drawing.Point(6, 260);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(209, 23);
            this.txtCheckIn.TabIndex = 25;
            this.ttControles.SetToolTip(this.txtCheckIn, "Enter para registrar Check In");
            this.txtCheckIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckIn_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Check In";
            // 
            // cmbSprintCargado
            // 
            this.cmbSprintCargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSprintCargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSprintCargado.FormattingEnabled = true;
            this.cmbSprintCargado.Location = new System.Drawing.Point(110, 28);
            this.cmbSprintCargado.Name = "cmbSprintCargado";
            this.cmbSprintCargado.Size = new System.Drawing.Size(68, 24);
            this.cmbSprintCargado.TabIndex = 23;
            this.ttControles.SetToolTip(this.cmbSprintCargado, "Al cambiar se afecta en BD");
            this.cmbSprintCargado.SelectedIndexChanged += new System.EventHandler(this.cmbSprintCargado_SelectedIndexChanged);
            // 
            // txtEstimado
            // 
            this.txtEstimado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstimado.Location = new System.Drawing.Point(184, 28);
            this.txtEstimado.Name = "txtEstimado";
            this.txtEstimado.Size = new System.Drawing.Size(64, 23);
            this.txtEstimado.TabIndex = 22;
            this.ttControles.SetToolTip(this.txtEstimado, "Enter para editar tiempo estimado");
            this.txtEstimado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstimado_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(181, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Estimado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(110, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sprint";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.Color.White;
            this.lblFechaFin.Location = new System.Drawing.Point(90, 206);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(80, 17);
            this.lblFechaFin.TabIndex = 18;
            this.lblFechaFin.Text = "1900/01/01";
            this.ttControles.SetToolTip(this.lblFechaFin, "Cambia segun lo seleccionado en el estado");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fecha Fin: ";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.White;
            this.lblFechaInicio.Location = new System.Drawing.Point(90, 179);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(80, 17);
            this.lblFechaInicio.TabIndex = 16;
            this.lblFechaInicio.Text = "1900/01/01";
            this.ttControles.SetToolTip(this.lblFechaInicio, "Cambia segun lo seleccionado en el estado");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha Inicio: ";
            // 
            // gridFuentes
            // 
            this.gridFuentes.AllowUserToAddRows = false;
            this.gridFuentes.AllowUserToDeleteRows = false;
            this.gridFuentes.AllowUserToResizeColumns = false;
            this.gridFuentes.AllowUserToResizeRows = false;
            this.gridFuentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridFuentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFuentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fuentes});
            this.gridFuentes.Location = new System.Drawing.Point(221, 289);
            this.gridFuentes.MultiSelect = false;
            this.gridFuentes.Name = "gridFuentes";
            this.gridFuentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridFuentes.Size = new System.Drawing.Size(323, 240);
            this.gridFuentes.TabIndex = 14;
            this.ttControles.SetToolTip(this.gridFuentes, "Se puede editar desde el grid");
            this.gridFuentes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFuentes_CellEndEdit);
            this.gridFuentes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridFuentes_KeyDown);
            // 
            // Fuentes
            // 
            this.Fuentes.HeaderText = "Fuentes";
            this.Fuentes.Name = "Fuentes";
            this.Fuentes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fuentes.Width = 275;
            // 
            // gridCheckIn
            // 
            this.gridCheckIn.AllowUserToAddRows = false;
            this.gridCheckIn.AllowUserToDeleteRows = false;
            this.gridCheckIn.AllowUserToResizeColumns = false;
            this.gridCheckIn.AllowUserToResizeRows = false;
            this.gridCheckIn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCheckIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckIn});
            this.gridCheckIn.Location = new System.Drawing.Point(6, 289);
            this.gridCheckIn.MultiSelect = false;
            this.gridCheckIn.Name = "gridCheckIn";
            this.gridCheckIn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCheckIn.Size = new System.Drawing.Size(209, 240);
            this.gridCheckIn.TabIndex = 8;
            this.ttControles.SetToolTip(this.gridCheckIn, "Se puede editar desde el grid");
            this.gridCheckIn.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCheckIn_CellEndEdit);
            this.gridCheckIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridCheckIn_KeyDown);
            // 
            // CheckIn
            // 
            this.CheckIn.HeaderText = "Check In";
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CheckIn.Width = 160;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(6, 143);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 12;
            this.ttControles.SetToolTip(this.cmbEstado, "Al cambiar se modifica en BD junto con las fechas de inicio y fin");
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Estado";
            // 
            // txtDesciprcionCargada
            // 
            this.txtDesciprcionCargada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesciprcionCargada.Location = new System.Drawing.Point(6, 84);
            this.txtDesciprcionCargada.Name = "txtDesciprcionCargada";
            this.txtDesciprcionCargada.Size = new System.Drawing.Size(537, 23);
            this.txtDesciprcionCargada.TabIndex = 10;
            this.ttControles.SetToolTip(this.txtDesciprcionCargada, "Enter para editar descripción");
            this.txtDesciprcionCargada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesciprcionCargada_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripción";
            // 
            // txtTareaCargada
            // 
            this.txtTareaCargada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTareaCargada.Location = new System.Drawing.Point(6, 28);
            this.txtTareaCargada.Name = "txtTareaCargada";
            this.txtTareaCargada.Size = new System.Drawing.Size(98, 23);
            this.txtTareaCargada.TabIndex = 8;
            this.ttControles.SetToolTip(this.txtTareaCargada, "Enter para editar número de tarea");
            this.txtTareaCargada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTareaCargada_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tarea";
            // 
            // gridTareas
            // 
            this.gridTareas.AllowUserToAddRows = false;
            this.gridTareas.AllowUserToDeleteRows = false;
            this.gridTareas.AllowUserToResizeColumns = false;
            this.gridTareas.AllowUserToResizeRows = false;
            this.gridTareas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarea,
            this.Descripcion});
            this.gridTareas.Location = new System.Drawing.Point(12, 114);
            this.gridTareas.MultiSelect = false;
            this.gridTareas.Name = "gridTareas";
            this.gridTareas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridTareas.RowTemplate.Height = 23;
            this.gridTareas.Size = new System.Drawing.Size(607, 417);
            this.gridTareas.TabIndex = 1;
            this.ttControles.SetToolTip(this.gridTareas, "Enter para editar tarea o descripción");
            this.gridTareas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTareas_CellEndEdit);
            this.gridTareas.CurrentCellChanged += new System.EventHandler(this.gridTareas_CurrentCellChanged);
            this.gridTareas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridTareas_KeyDown);
            // 
            // Tarea
            // 
            this.Tarea.HeaderText = "Tarea";
            this.Tarea.Name = "Tarea";
            this.Tarea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tarea.Width = 90;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Descripcion.Width = 470;
            // 
            // cmbSprint
            // 
            this.cmbSprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSprint.FormattingEnabled = true;
            this.cmbSprint.Location = new System.Drawing.Point(12, 29);
            this.cmbSprint.Name = "cmbSprint";
            this.cmbSprint.Size = new System.Drawing.Size(92, 24);
            this.cmbSprint.TabIndex = 2;
            this.ttControles.SetToolTip(this.cmbSprint, "Enter para registrar sprint");
            this.cmbSprint.SelectedIndexChanged += new System.EventHandler(this.cmbSprint_SelectedIndexChanged);
            this.cmbSprint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSprint_KeyDown);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(110, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(509, 23);
            this.txtBuscar.TabIndex = 4;
            this.ttControles.SetToolTip(this.txtBuscar, "ESC para buscar por Sprint");
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sprint ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tarea";
            // 
            // txtNumeroTarea
            // 
            this.txtNumeroTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTarea.Location = new System.Drawing.Point(12, 85);
            this.txtNumeroTarea.Name = "txtNumeroTarea";
            this.txtNumeroTarea.Size = new System.Drawing.Size(92, 23);
            this.txtNumeroTarea.TabIndex = 9;
            this.ttControles.SetToolTip(this.txtNumeroTarea, "Enter para registrar tarea");
            this.txtNumeroTarea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroTarea_KeyDown);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(112, 85);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(507, 23);
            this.txtDescripcion.TabIndex = 11;
            this.ttControles.SetToolTip(this.txtDescripcion, "Enter para registrar tarea");
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(113, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Descripción";
            // 
            // ttControles
            // 
            this.ttControles.Tag = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(10, 537);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Cantidad: ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(76, 537);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(28, 17);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "     ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(492, 537);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "F1: Sprint y Funtes";
            // 
            // ControlTareasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1180, 557);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNumeroTarea);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbSprint);
            this.Controls.Add(this.gridTareas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ControlTareasFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Tareas Lite";
            this.Load += new System.EventHandler(this.ControlTareasFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlTareasFrm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridTareas;
        private System.Windows.Forms.ComboBox cmbSprint;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesciprcionCargada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTareaCargada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridFuentes;
        private System.Windows.Forms.DataGridView gridCheckIn;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumeroTarea;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEstimado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSprintCargado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fuentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.ToolTip ttControles;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cmbFuentes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

