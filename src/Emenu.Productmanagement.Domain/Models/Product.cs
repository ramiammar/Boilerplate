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
    public class Product: AuditedAggregateRoot<Guid>
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string InventoryNumber { get; set; } = string.Empty;

        [Required]
        public float Price { get; set; }

        [Required]
        public float Cost { get; set; }

        [ForeignKey("Category")]
        public Guid? CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Image> Images { get; set; } = new List<Image>();
    }
}
