using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_COURSE.Entities
{
    public class Autor
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        public List<Libro> Libros { get; set; }
    }
}
