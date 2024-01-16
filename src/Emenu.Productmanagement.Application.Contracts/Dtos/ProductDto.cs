using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Emenu.Productmanagement.Dtos
{
    public class ProductDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string InventoryNumber { get; set; }

        public float Price { get; set; }

        public float Cost { get; set; }

        public Guid? CategoryId { get; set; }

        public virtual ICollection<ImageDto> Images { get; set; } = new List<ImageDto>();
    }
}
