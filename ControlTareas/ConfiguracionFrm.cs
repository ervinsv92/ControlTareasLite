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

            var prueba = int.TryParse(txtPeriodoActual.Text.Trim(), out isNumber);

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
    }
}
