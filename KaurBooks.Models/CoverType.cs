using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaurBooks.Models
{
<<<<<<< HEAD
    class CoverType
=======
    public class CoverType
>>>>>>> b0c9eab4087d1f76bb5b34406c8cc6bb41f95799
    {
         
        [Key]

        public int Id { get; set; }

<<<<<<< HEAD
        [Display(Name = "Category Name")]
=======
        [Display(Name = "Cover Type List")]
>>>>>>> b0c9eab4087d1f76bb5b34406c8cc6bb41f95799
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }

    }
}

