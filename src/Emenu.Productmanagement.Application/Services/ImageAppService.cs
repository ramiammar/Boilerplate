using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Emenu.Productmanagement.Dtos;
using Emenu.Productmanagement.Model;
using Emenu.Productmanagement.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Emenu.Productmanagement.Services
{
    public class ImageAppService : ApplicationService, IImageAppService
    {
        private IConfiguration Configurtaion { get; }
        private ClouidnarySetting ClouidnarySetting { get; set; }

        private Cloudinary cloudinary { get; set; }

        private IRepository<Image,Guid> ImageRepository { get; set; }

        public ImageAppService(IConfiguration configurtaion, IRepository<Image, Guid> _ImageRepository) {
            Configurtaion = configurtaion;
            ClouidnarySetting = Configurtaion.GetSection("CloudinarySetting").Get<ClouidnarySetting>();
            Account account = new Account(ClouidnarySetting.CloudName, ClouidnarySetting.ApiKey, ClouidnarySetting.ApiSecret);
            cloudinary = new Cloudinary(account);
            ImageRepository = _ImageRepository;
        }
        

        public Task<ImageDto> SaveImage(CreateUpdateImageDto image)
        {
            ImageDto imageDto = new ImageDto();
            if (image.File != null && image.File.Length > 0) {
                var uploadResult = new ImageUploadResult();
                using (var ms = new MemoryStream())
                {
                    ms.Write(image.File);
                    var uploadImage = new ImageUploadParams()
                    {
                        File = new FileDescription(image.Name, ms)
                    };
                    cloudinary.Upload(uploadImage);
                }
                if (uploadResult.Error == null)
                {
                    imageDto.Path = uploadResult.Uri.ToString();
                    imageDto.PublicId = uploadResult.PublicId;
                    imageDto.Name = image.Name;
                    ImageRepository.InsertAsync(new Image() {
                        Name = image.Name,
                        Path = imageDto.Path,
                        
                    });
                    return Task.FromResult(imageDto);
                }
            }
            return Task.FromResult(imageDto);
        }


        public Task<bool> DeleteImage(Guid id)
        {
            Image image = ImageRepository.GetAsync(id).Result;
            if (image != null)
            {
                var delResult = new DelResResult();
                delResult = cloudinary.DeleteResources(new string[] { id.ToString() });
                if (delResult.Error == null)
                {
                    return Task.FromResult(true);
                }
            }
            return Task.FromResult(false);
        }
    }
}
