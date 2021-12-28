using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTareas
{
   
    public class DBHelper
    {
        private LiteRepository GetConexion() {
            return new LiteRepository("ControlTareas.db");
        }

        public void RegistrarSprint(SprintModel sprint)
        {
            using (var db = GetConexion())
            {
                //validar si el sprint existe
                var res = db.Query<SprintModel>().Where(x => x.Numero == sprint.Numero).ToList();
               
                if (res.Count == 0)
                {
                    db.Insert(sprint);
                }
            }
        }

        public void RegistrarConfiguracion(ConfiguracionModel configuracion)
        {
            using (var db = GetConexion())
            {
                //validar si el sprint existe
                var res = db.Query<ConfiguracionModel>().Where(x => x.Id == configuracion.Id).ToList();

                if (res.Count == 0)
                {
                    db.Insert(configuracion);
                }
                else {
                    db.Update(configuracion);
                }
            }
        }

        public List<SprintModel> LeerSprints()
        {
            List<SprintModel> Lista;
            using (var db = GetConexion())
            {
                Lista = db.Query<SprintModel>().OrderByDescending(x => x.Numero).ToList();
            }

            return Lista;
        }

        public ConfiguracionModel LeerConfiguracion()
        {
            ConfiguracionModel configuracion;
            using (var db = GetConexion())
            {
                configuracion = db.Query<ConfiguracionModel>().FirstOrDefault();
            }

            return configuracion;
        }

        public Boolean VerificaExisteTarea(String NumeroTarea, int ID = 0) {
            Boolean existeTarea = false;
            using (var db = GetConexion())
            {
                var Lista = db.Query<TareaModel>().Where(x => x.NumeroTarea == NumeroTarea && x.Id != ID && x.NumeroTarea != "99999").ToList();

                if (Lista.Count > 0) {
                    existeTarea = true;
                }
            }

            return existeTarea;
        }

        public void RegistrarTarea(TareaModel Tarea) {
            using (var db = GetConexion())
            {
                db.Insert(Tarea);
            }
        }

        public List<TareaModel> LeerTareasSprint(int NumeroSprint) {
            List<TareaModel> Lista = null;
            using (var db = GetConexion())
            {
                Lista = db.Query<TareaModel>().Where(x => x.Sprint == NumeroSprint).ToList();
                Lista = Lista.OrderBy(x => x.TipoTarea).ThenBy(x=>x.Prioridad).ThenByDescending(x=>x.FechaRegistro).ToList();
            }

            return Lista;
        }

        public void ActualizarTarea(TareaModel tarea) {

            using (var db = GetConexion()) {
                db.Update(tarea);
            }
        }

        public void EliminarTarea(TareaModel tarea)
        {
            using (var db = GetConexion())
            {
                db.Delete<TareaModel>(tarea.Id);
            }
        }

        public List<TareaModel> LeerTareasBusqueda(string DatoBusqueda)
        {
            List<TareaModel> Lista = null;
            using (var db = GetConexion())
            {
                var col = db.Database.GetCollection<TareaModel>("TareaModel");
                Lista = col.Find(x => x.NumeroTarea.Contains(DatoBusqueda) || x.Descripcion.Contains(DatoBusqueda) || x.ListaCheckIn.Any(a => a.Contains(DatoBusqueda)) || x.Notas.Contains(DatoBusqueda)).OrderByDescending(x => x.FechaRegistro).ToList<TareaModel>();
            }

            return Lista;
        }

        public void RegistrarFuente(FuentesModel Fuente) {

            using (var db = GetConexion())
            {

                var fuentes = db.Query<FuentesModel>().Where(x => x.Fuente.ToLower() == Fuente.Fuente.ToLower());

                if (fuentes.Count() == 0) {
                    db.Insert(Fuente);
                }
            }
        }

        public List<FuentesModel> LeerFuentes() {
            List<FuentesModel> Lista = null;

            using (var db = GetConexion())
            {
                Lista = db.Query<FuentesModel>().OrderBy(x => x.Fuente).ToList();
            }

            return Lista;
        }

        public void EliminarSprint(SprintModel sprint)
        {
            using (var db = GetConexion())
            {
                db.Delete<SprintModel>(sprint.Id);
            }
        }

        public void EliminarFuente(FuentesModel fuente)
        {
            using (var db = GetConexion())
            {
                db.Delete<FuentesModel>(fuente.Id);
            }
        }

        public Boolean ExisteSprintEnTarea(int NumeroSprint)
        {
            Boolean existeEnTarea = false;
            using (var db = GetConexion())
            {
                //validar si el sprint existe
                var res = db.Query<TareaModel>().Where(x => x.Sprint == NumeroSprint).ToList();

                if (res.Count > 0)
                {
                    existeEnTarea = true;
                }
            }

            return existeEnTarea;
        }

        public void ActualizarFuente(FuentesModel fuente)
        {
            using (var db = GetConexion())
            {
                db.Update(fuente);
            }
        }
    }
}
