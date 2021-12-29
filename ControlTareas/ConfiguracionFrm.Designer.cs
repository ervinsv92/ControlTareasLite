
namespace ControlTareas
{
    partial class ConfiguracionFrm
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
            this.tabPeriodo = new System.Windows.Forms.TabControl();
            this.tabConfiguracion = new System.Windows.Forms.TabPage();
            this.btnGuardarConfiguracion = new System.Windows.Forms.Button();
            this.txtPeriodoActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarRutaBase = new System.Windows.Forms.Button();
            this.txtRutaBase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCarpetas = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeriodoMinimo = new System.Windows.Forms.TextBox();
            this.btnRemapear = new System.Windows.Forms.Button();
            this.tabPeriodo.SuspendLayout();
            this.tabConfiguracion.SuspendLayout();
            this.tabCarpetas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPeriodo
            // 
            this.tabPeriodo.Controls.Add(this.tabConfiguracion);
            this.tabPeriodo.Controls.Add(this.tabCarpetas);
            this.tabPeriodo.Location = new System.Drawing.Point(4, 4);
            this.tabPeriodo.Name = "tabPeriodo";
            this.tabPeriodo.SelectedIndex = 0;
            this.tabPeriodo.Size = new System.Drawing.Size(794, 443);
            this.tabPeriodo.TabIndex = 0;
            // 
            // tabConfiguracion
            // 
            this.tabConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabConfiguracion.Controls.Add(this.btnGuardarConfiguracion);
            this.tabConfiguracion.Controls.Add(this.txtPeriodoActual);
            this.tabConfiguracion.Controls.Add(this.label2);
            this.tabConfiguracion.Controls.Add(this.btnBuscarRutaBase);
            this.tabConfiguracion.Controls.Add(this.txtRutaBase);
            this.tabConfiguracion.Controls.Add(this.label1);
            this.tabConfiguracion.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguracion.Name = "tabConfiguracion";
            this.tabConfiguracion.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguracion.Size = new System.Drawing.Size(786, 417);
            this.tabConfiguracion.TabIndex = 0;
            this.tabConfiguracion.Text = "Configuracion";
            // 
            // btnGuardarConfiguracion
            // 
            this.btnGuardarConfiguracion.Location = new System.Drawing.Point(363, 388);
            this.btnGuardarConfiguracion.Name = "btnGuardarConfiguracion";
            this.btnGuardarConfiguracion.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarConfiguracion.TabIndex = 11;
            this.btnGuardarConfiguracion.Text = "Guardar";
            this.btnGuardarConfiguracion.UseVisualStyleBackColor = true;
            this.btnGuardarConfiguracion.Click += new System.EventHandler(this.btnGuardarConfiguracion_Click);
            // 
            // txtPeriodoActual
            // 
            this.txtPeriodoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodoActual.Location = new System.Drawing.Point(9, 76);
            this.txtPeriodoActual.Name = "txtPeriodoActual";
            this.txtPeriodoActual.Size = new System.Drawing.Size(130, 23);
            this.txtPeriodoActual.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Periodo actual";
            // 
            // btnBuscarRutaBase
            // 
            this.btnBuscarRutaBase.Location = new System.Drawing.Point(524, 23);
            this.btnBuscarRutaBase.Name = "btnBuscarRutaBase";
            this.btnBuscarRutaBase.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRutaBase.TabIndex = 8;
            this.btnBuscarRutaBase.Text = "...";
            this.btnBuscarRutaBase.UseVisualStyleBackColor = true;
            this.btnBuscarRutaBase.Click += new System.EventHandler(this.btnBuscarRutaBase_Click);
            // 
            // txtRutaBase
            // 
            this.txtRutaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaBase.Location = new System.Drawing.Point(9, 23);
            this.txtRutaBase.Name = "txtRutaBase";
            this.txtRutaBase.Size = new System.Drawing.Size(509, 23);
            this.txtRutaBase.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ruta Base";
            // 
            // tabCarpetas
            // 
            this.tabCarpetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabCarpetas.Controls.Add(this.btnRemapear);
            this.tabCarpetas.Controls.Add(this.txtPeriodoMinimo);
            this.tabCarpetas.Controls.Add(this.label3);
            this.tabCarpetas.Location = new System.Drawing.Point(4, 22);
            this.tabCarpetas.Name = "tabCarpetas";
            this.tabCarpetas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarpetas.Size = new System.Drawing.Size(786, 417);
            this.tabCarpetas.TabIndex = 1;
            this.tabCarpetas.Text = "Remapeo carpetas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Periodo Minimo";
            // 
            // txtPeriodoMinimo
            // 
            this.txtPeriodoMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodoMinimo.Location = new System.Drawing.Point(9, 23);
            this.txtPeriodoMinimo.Name = "txtPeriodoMinimo";
            this.txtPeriodoMinimo.Size = new System.Drawing.Size(130, 23);
            this.txtPeriodoMinimo.TabIndex = 11;
            // 
            // btnRemapear
            // 
            this.btnRemapear.Location = new System.Drawing.Point(145, 23);
            this.btnRemapear.Name = "btnRemapear";
            this.btnRemapear.Size = new System.Drawing.Size(75, 23);
            this.btnRemapear.TabIndex = 12;
            this.btnRemapear.Text = "Remapear";
            this.btnRemapear.UseVisualStyleBackColor = true;
            this.btnRemapear.Click += new System.EventHandler(this.btnRemapear_Click);
            // 
            // ConfiguracionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPeriodo);
            this.Name = "ConfiguracionFrm";
            this.Text = "Configuración";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfiguracionFrm_FormClosed);
            this.tabPeriodo.ResumeLayout(false);
            this.tabConfiguracion.ResumeLayout(false);
            this.tabConfiguracion.PerformLayout();
            this.tabCarpetas.ResumeLayout(false);
            this.tabCarpetas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPeriodo;
        private System.Windows.Forms.TabPage tabConfiguracion;
        private System.Windows.Forms.TabPage tabCarpetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRutaBase;
        private System.Windows.Forms.Button btnBuscarRutaBase;
        private System.Windows.Forms.Button btnGuardarConfiguracion;
        private System.Windows.Forms.TextBox txtPeriodoActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemapear;
        private System.Windows.Forms.TextBox txtPeriodoMinimo;
        private System.Windows.Forms.Label label3;
    }
}