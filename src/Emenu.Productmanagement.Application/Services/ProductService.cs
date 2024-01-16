using AutoMapper.Internal.Mappers;
using Emenu.Productmanagement.Dtos;
using Emenu.Productmanagement.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Emenu.Productmanagement.Services
{
    public class ProductService: IProductService
    {
        private readonly IRepository<Product, Guid> repository;
        private readonly ImageAppService imageAppService;
        public ProductService(IRepository<Product, Guid> _repository, ImageAppService _imageAppService)
        {
            repository = _repository;
            imageAppService = _imageAppService;
        }

        public Task<ProductDto> CreateAsync(CreateUpdateProductDto input)
        {
            if(input == null) throw new ArgumentNullException(nameof(input));
            var product = repository.InsertAsync(new Product()
            {
                CategoryId = input.CategoryId,
                Cost = input.Cost,
                Description = input.Description,
                Name = input.Name,
                Price = input.Price,
            }).Result;
            foreach(var image in input.Images)
            {
                image.ProductId = product.Id;
                imageAppService.SaveImage(image);
            }
            ProductDto p = new ProductDto()
            {
                Id = product.Id,
                CategoryId = input.CategoryId,
                Cost = input.Cost,
                Description = input.Description,
                Name = input.Name,
                Price = input.Price,
            };
            return Task.FromResult(p);
        }

        public Task DeleteAsync(Guid id)
        {
            var product = repository.GetAsync(id).Result;
            if (product == null) throw new ArgumentNullException(nameof(product));
            repository.DeleteAsync(product);
            foreach (var image in product.Images)
            {
                imageAppService.DeleteImage(image.Id);
            }
            return Task.CompletedTask;
        }

        public Task<ProductDto> GetAsync(Guid id)
        {
            var product = repository.GetAsync(id).Result;
            if (product == null) throw new ArgumentNullException(nameof(product));
            var productDto = new ProductDto()
            {
                CategoryId = product.CategoryId,
                Cost = product.Cost,
                Description = product.Description,
                Name = product.Name,
                Price = product.Price,
                Images = new List<ImageDto>()
            };
            foreach (var image in product.Images)
            {
                productDto.Images.Add(new ImageDto()
                {
                    Id = image.Id,
                    Name = image.Name,
                    Path = image.Path,
                });
            }
            return Task.FromResult(productDto);
        }

        public Task<PagedResultDto<ProductDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            var products = repository.GetPagedListAsync(input.SkipCount, input.MaxResultCount, input.Sorting).Result;
            if (products == null) throw new ArgumentNullException(nameof(products));
            var productsDto = new List<ProductDto>();
            foreach (var product in products)
            {
                var productDto = new ProductDto()
                {
                    CategoryId = product.CategoryId,
                    Cost = product.Cost,
                    Description = product.Description,
                    Name = product.Name,
                    Price = product.Price,
                    Images = new List<ImageDto>()
                };
                foreach (var image in product.Images)
                {
                    productDto.Images.Add(new ImageDto()
                    {
                        Id = image.Id,
                        Name = image.Name,
                        Path = image.Path,
                    });
                }
                productsDto.Add(productDto);
            }
            
            return Task.FromResult(new PagedResultDto<ProductDto>(productsDto.Count, productsDto));
        }

        public Task<ProductDto> UpdateAsync(Guid id, CreateUpdateProductDto input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            var product = repository.GetAsync(id).Result;
            product.CategoryId = input.CategoryId;
            product.Cost = input.Cost;
            product.Description = input.Description;
            product.Name = input.Name;
            product.Price = input.Price;
            repository.UpdateAsync(product);
            ProductDto p = new ProductDto()
            {
                Id = id,
                CategoryId = input.CategoryId,
                Cost = input.Cost,
                Description = input.Description,
                Name = input.Name,
                Price = input.Price,
            };
            return Task.FromResult(p);
        }
    }
}
