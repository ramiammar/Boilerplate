using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Emenu.Productmanagement.Dtos
{
    public class CreateUpdateCategoryDto : AuditedEntityDto<Guid>
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
    }
}
