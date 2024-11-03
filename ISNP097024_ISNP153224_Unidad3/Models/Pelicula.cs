using System.ComponentModel.DataAnnotations;

namespace ISNP097024_ISNP153224_Unidad3.Models
{
    public class Pelicula
    {
        [Key]

        public int idPelicula { get; set; }
        public string titulo { get; set; }
        public string autor {  get; set; }
        public string sinopsis { get; set; }
        public string duracion {  get; set; }
        public string clasificacion {  get; set; }

    }
}
