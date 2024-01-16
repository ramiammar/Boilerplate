using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Emenu.Productmanagement.Models
{
    public class Image : AuditedAggregateRoot<Guid>
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Path { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string PublicId { get; set; } = string.Empty;

        [Required]
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        public virtual Product Product { get; set; } = new Product();
    }
}
