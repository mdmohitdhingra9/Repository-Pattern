using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryPattern.Models.Common.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        public Guid AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
