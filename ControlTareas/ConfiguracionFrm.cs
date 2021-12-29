using System;
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
    public partial class ConfiguracionFrm : Form
    {
        DBHelper dbHelper = new DBHelper();
        ConfiguracionModel configuracion;
        public ConfiguracionFrm()
        {
            InitializeComponent();
            configuracion = dbHelper.LeerConfiguracion();
            if (configuracion == null) {
                configuracion = new ConfiguracionModel();
            }

            txtRutaBase.Text = configuracion.RutaBase;
            txtPeriodoActual.Text = configuracion.Periodo.ToString();
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            int isNumber;            

            if (!Directory.Exists(txtRutaBase.Text.Trim()))
            {
                MessageBox.Show("La ruta no existe.");
                return;
            }
            else if (!int.TryParse(txtPeriodoActual.Text.Trim(), out isNumber) || txtPeriodoActual.Text.Trim().Length != 4) {
                MessageBox.Show("Digite un periodo valido.");
                return;
            }

            configuracion.RutaBase = txtRutaBase.Text.Trim();
            configuracion.Periodo = Int32.Parse(txtPeriodoActual.Text.Trim());

            dbHelper.RegistrarConfiguracion(configuracion);

            string rutaCarpeta = configuracion.RutaBase + "/" + configuracion.Periodo.ToString();
            if (!Directory.Exists(rutaCarpeta)) {
                Directory.CreateDirectory(rutaCarpeta);
            }

            MessageBox.Show("Datos guardados.");
        }

        private void btnBuscarRutaBase_Click(object sender, EventArgs e)
        {
            using (var fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    txtRutaBase.Text = fd.SelectedPath;
                }
            }
        }

        private void btnRemapear_Click(object sender, EventArgs e)
        {
            int isNumber;
            if (!int.TryParse(txtPeriodoMinimo.Text.Trim(), out isNumber) || txtPeriodoMinimo.Text.Trim().Length != 4)
            {
                MessageBox.Show("Digite un periodo valido.");
                return;
            }

            int minimo = Int32.Parse(txtPeriodoMinimo.Text.Trim());
            int actual = DateTime.Now.Year;
            while (minimo<=actual)
            {
                string rutaCarpeta = configuracion.RutaBase + "\\" + minimo.ToString();
                if (Directory.Exists(rutaCarpeta))
                {
                    var rutasSprints =  Directory.GetDirectories(rutaCarpeta);
                    foreach (string rutaSprint in rutasSprints)
                    {
                        string numeroSprint = rutaSprint.Replace(rutaCarpeta+"\\", "");
                        List<TareaModel> tareasSprint = dbHelper.LeerTareasSprint(Int32.Parse(numeroSprint));
                        var rutaTareas = Directory.GetDirectories(rutaSprint);
                        foreach (string rutaTarea in rutaTareas)
                        {
                            string numeroTarea = rutaTarea.Replace(rutaSprint + "\\", "").Split(" ".ToCharArray())[0];
                            
                            //para que no lea las carpetas 00001 ni las tareas 99999
                            if (Int32.Parse(numeroTarea) > 9999 && numeroTarea != "99999") {
                                int idx = tareasSprint.FindIndex(x => x.NumeroTarea == numeroTarea);
                                if (idx > -1) {
                                    tareasSprint[idx].RutaCarpeta = rutaTarea + "\\";
                                    dbHelper.ActualizarTarea(tareasSprint[idx]);
                                }
                            }
                        }
                    }
                }

                minimo++;
            }

            MessageBox.Show("Mapeo terminado.");
        }

        private void ConfiguracionFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
