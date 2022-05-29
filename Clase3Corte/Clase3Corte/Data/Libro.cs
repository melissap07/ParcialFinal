using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Clase3Corte.Data
{
    public class Libro
    {
        [Key]
        public int IdLibro { get; set; }
        public string? Titulo { get; set; }
        public string? Editorial { get; set; }
        public string? Autor { get; set; }
        public int Pagina { get; set; }
        public string? Descripcion { get; set; }
    }
}