using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Emenu.Productmanagement.Dtos
{
    public class CreateUpdateProductDto : AuditedEntityDto<Guid>
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

        public Guid? CategoryId { get; set; }


        public virtual ICollection<CreateUpdateImageDto> Images { get; set; } = new List<CreateUpdateImageDto>();
    }
}
