using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Clase3Corte.Data
{
    public class Movies
    {
        [Key]
        public int IdMovie { get; set; }
        public string Year { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
    }
}
