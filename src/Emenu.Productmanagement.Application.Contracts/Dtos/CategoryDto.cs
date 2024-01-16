using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Emenu.Productmanagement.Dtos
{
    public class CategoryDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; } = string.Empty;
    }
}
