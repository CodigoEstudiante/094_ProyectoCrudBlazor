using System;
using System.Collections.Generic;

namespace BlazorCrud.Server.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public int IdDepartamento { get; set; }

    public int Sueldo { get; set; }

    public DateTime FechaContrato { get; set; }

    public virtual Departamento IdDepartamentoNavigation { get; set; } = null!;
}
