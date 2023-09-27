using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.DTO
{
    public class TareaDTO
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaDeTarea { get; set; }
        public TimeSpan? HoraDeTareaT { get; set; }
    }
}
