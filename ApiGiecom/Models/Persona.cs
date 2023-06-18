using System;
using System.Collections.Generic;

namespace ApiGiecom.Models;

public partial class Persona
{
    public int Id { get; set; }

    public string? PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public string? Telefono { get; set; }
}
