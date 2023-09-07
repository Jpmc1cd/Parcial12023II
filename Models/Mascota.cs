using System;
using System.Collections.Generic;

namespace Parcial12023II.Models;

public partial class Mascota
{
    public int Id { get; set; }

    public string? NombreMascota { get; set; }

    public string? TipoMascota { get; set; }

    public string? Genero { get; set; }

    public string? Raza { get; set; }
}
