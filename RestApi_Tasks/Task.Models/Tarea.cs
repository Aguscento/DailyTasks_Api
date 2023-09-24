using System;
using System.Collections.Generic;

namespace Task.Models;

public partial class Tarea
{
    public int IdtareaT { get; set; }

    public int IdusuarioUT { get; set; }

    public string NombreT { get; set; } = null!;

    public string? DescripcionT { get; set; }

    public DateTime FechaDeTareaT { get; set; }

    public TimeSpan? HoraDeTareaT { get; set; }

    public DateTime? FechaDeCargaT { get; set; }

    public virtual Usuario IdusuarioUTNavigation { get; set; } = null!;
}
