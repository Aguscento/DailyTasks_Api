using System;
using System.Collections.Generic;

namespace Task.Models;

public partial class Usuario
{
    public int IdusuarioU { get; set; }

    public string NombreU { get; set; } = null!;

    public string EmailU { get; set; } = null!;

    public string ClaveU { get; set; } = null!;

    public bool? ActivoU { get; set; }

    public DateTime? FechaDeCarga { get; set; }

    public virtual ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();
}
