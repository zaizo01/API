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
        [StringLength(20, MinimumLength = 5, ErrorMessage ="EL campo nombre debe tener {1} caracteres o menos")]
        public string nombre { get; set; }
        [Range(18, 120)]
        public int Edad { get; set; }
        [CreditCard]
        public string creditCard { get; set; }
        [Url]
        public Uri url { get; set; }
        public List<Libro> Libros { get; set; }
        
      
    }
}
