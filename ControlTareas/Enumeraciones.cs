using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTareas
{
    public enum EstadoTareaEnum
    {
        Creada = 0,
        Iniciada = 1,
        Finalizada = 2
    }

    public enum TipoTareaEnum
    {
        BugHelpDesk = 0,
        Bug = 1,
        ProductBacklogItem = 2,
        InternalImprovement = 3,
        Test = 4,
        QA = 5
    }
}
