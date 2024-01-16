using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Emenu.Productmanagement.Models
{
    public class Category : AuditedAggregateRoot<Guid>
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

       public virtual ICollection<Product> Products { get; set;} = new List<Product>();
    }
}
