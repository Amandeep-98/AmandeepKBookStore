using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaurBooks.Models
{
    public class CoverType
    {
         
        [Key]

        public int Id { get; set; }

        [Display(Name = "Cover Type List")]
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }

    }
}

