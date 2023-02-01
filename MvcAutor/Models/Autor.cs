using System.ComponentModel.DataAnnotations;

namespace MvcAutor.Models;

public class Autor{
    public int Id { get; set; }
    public string Nome { get; set; }
    [DataType(DataType.Date)]
    public DateTime Dt_nasc { get; set; }
}