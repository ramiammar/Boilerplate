using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Emenu.Productmanagement.Dtos
{
    public class CreateUpdateImageDto : AuditedEntityDto<Guid>
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public byte[] File { get; set; }

        public Guid? ProductId { get; set; }
    }
}
