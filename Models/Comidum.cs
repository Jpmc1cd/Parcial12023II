using System;
using System.Collections.Generic;

namespace Parcial12023II.Models;

public partial class Comidum
{
    public int Id { get; set; }

    public string? TipoComida { get; set; }

    public int? IdMascota { get; set; }

    public string? Sabor { get; set; }
}
