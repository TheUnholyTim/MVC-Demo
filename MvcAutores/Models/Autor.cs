using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAutores.Models;

public class Autor{
    public int Id { get; set; }
    [MaxLength(200)]
    [Display(Name = "Autor")]
    public string? Nome { get; set; }
    [Display(Name = "Data de Nascimento")]

    [DataType(DataType.Date)]
    public DateTime Dt_nasc { get; set; }
}