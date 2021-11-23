using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaurBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        ISP_Call SP_Call { get; }
        object CoverType { get; }

        void Save();
    }

    
    class CoverType
    {

        [Key]

        public int Id { get; set; }

        [Display(Name = "Category Name")]
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }

    }
}
