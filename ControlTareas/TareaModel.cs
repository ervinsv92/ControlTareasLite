using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTareas
{
    public class TareaModel
    {
        public int Id { get; set; }
        public string NumeroTarea { get; set; }
        public string Descripcion { get; set; }
        public int Sprint { get; set; }
        public byte Estado { get; set; }
        public byte Estimado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaRegistro { get; set; }
        public List<string> ListaCheckIn { get; set; }
        public List<string> ListaFuentes { get; set; }
        public string Notas { get; set; }
        public int Prioridad { get; set; }
        public int TipoTarea { get; set; }

        public TareaModel() {
            this.FechaRegistro = DateTime.Now;
            this.Estado = (int)EstadoTareaEnum.Creada;
            this.FechaInicio = new DateTime(1900, 1, 1);
            this.FechaFin = new DateTime(1900, 1, 1);
            this.TipoTarea = (int)TipoTareaEnum.ProductBacklogItem;
            this.Prioridad = 99999;//Prioridad por defecto para que salga de ultimo al crearlo
        }
    }
}
