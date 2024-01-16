using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Emenu.Productmanagement.Dtos
{
    public class ImageDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public string PublicId { get; set; }

        public Guid? ProductId { get; set; }
    }
}
