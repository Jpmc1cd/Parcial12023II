using System;
using System.Collections.Generic;

namespace Parcial12023II.Models;

public partial class Dueño
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Genero { get; set; }

    public string? Direccion { get; set; }

    public string? Email { get; set; }

    public decimal? Telefono { get; set; }

    public int? IdMascota { get; set; }
}
