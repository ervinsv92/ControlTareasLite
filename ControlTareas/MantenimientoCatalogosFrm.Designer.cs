namespace ControlTareas
{
    partial class MantenimientoCatalogosFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridFuentes = new System.Windows.Forms.DataGridView();
            this.Fuentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.gridSprints = new System.Windows.Forms.DataGridView();
            this.Sprint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSprints)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sprints";
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
            this.gridFuentes.Location = new System.Drawing.Point(173, 29);
            this.gridFuentes.MultiSelect = false;
            this.gridFuentes.Name = "gridFuentes";
            this.gridFuentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridFuentes.Size = new System.Drawing.Size(299, 206);
            this.gridFuentes.TabIndex = 15;
            this.gridFuentes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFuentes_CellEndEdit);
            this.gridFuentes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridFuentes_KeyDown);
            // 
            // Fuentes
            // 
            this.Fuentes.HeaderText = "Fuentes";
            this.Fuentes.Name = "Fuentes";
            this.Fuentes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fuentes.Width = 250;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fuentes";
            // 
            // gridSprints
            // 
            this.gridSprints.AllowUserToAddRows = false;
            this.gridSprints.AllowUserToDeleteRows = false;
            this.gridSprints.AllowUserToResizeColumns = false;
            this.gridSprints.AllowUserToResizeRows = false;
            this.gridSprints.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridSprints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSprints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sprint});
            this.gridSprints.Location = new System.Drawing.Point(12, 29);
            this.gridSprints.MultiSelect = false;
            this.gridSprints.Name = "gridSprints";
            this.gridSprints.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSprints.Size = new System.Drawing.Size(155, 206);
            this.gridSprints.TabIndex = 17;
            this.gridSprints.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridSprints_KeyDown);
            // 
            // Sprint
            // 
            this.Sprint.HeaderText = "Sprint";
            this.Sprint.Name = "Sprint";
            this.Sprint.ReadOnly = true;
            this.Sprint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sprint.Width = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Del/Sup eliminar la fila seleccionada";
            // 
            // MantenimientoCatalogosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridSprints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridFuentes);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenimientoCatalogosFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Catalogos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MantenimientoCatalogosFrm_FormClosed);
            this.Load += new System.EventHandler(this.MantenimientoCatalogosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFuentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSprints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridFuentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fuentes;
        private System.Windows.Forms.DataGridView gridSprints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sprint;
    }
}