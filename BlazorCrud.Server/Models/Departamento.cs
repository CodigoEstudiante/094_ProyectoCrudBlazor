using System;
using System.Collections.Generic;

namespace BlazorCrud.Server.Models;

public partial class Departamento
{
    public int IdDepartamento { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();
}
