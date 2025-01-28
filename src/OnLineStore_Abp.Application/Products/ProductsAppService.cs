using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using OnLineStore_Abp.Bases;
using OnLineStore_Abp.Modules;
using OnLineStore_Abp.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace OnLineStore_Abp.Products
{
    public class ProductsAppService :BaseApplicationService, IProductAppService
    {
        #region fields
        private readonly IRepository<Product, int> productRepo;
        #endregion

        #region ctor
        public ProductsAppService(IRepository<Product,int> productRepo)
        {
            this.productRepo = productRepo;
        }
        #endregion
        #region IProductAppService
        [Authorize(OnLineStore_AbpPermissions.CreateEditProductPermission)]
        public async Task<ProductDto> CreateProductAsync(CreateUpdateProductDto input)
        {
            var validateResult = new CreateUpdateProductValidator().Validate(input);
            if (!validateResult.IsValid)
            {
                var exception = GetValidationException(validateResult);
                throw exception;
            }
            var product = ObjectMapper.Map<CreateUpdateProductDto,Product>(input);
            var inserted = await productRepo.InsertAsync(product, autoSave:true);
            return ObjectMapper.Map<Product, ProductDto>(inserted);
        }

        [Authorize(OnLineStore_AbpPermissions.DeleteProductPermission)]
        public async Task<bool> DeleteProductAsync(int id)
        {
            var existingProduct = await productRepo.GetAsync(id);
            if (existingProduct == null) 
            {
                return false;
            }
            await productRepo.DeleteAsync(existingProduct);
            return true;
        }

        [Authorize(OnLineStore_AbpPermissions.ListProductPermission)]
        public async Task<PagedResultDto<ProductDto>> GetListAsync(GetProductListDto input)
        {
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Product.Id);
            }
            var products = await productRepo
                                    .WithDetailsAsync(product=>product.Category)
                                    .Result
                                    .AsQueryable()
                                    .WhereIf(!input.Filter.IsNullOrWhiteSpace()
                                                ,product=>product.NameAr.Contains(input.Filter) ||
                                                        product.NameEn.Contains(input.Filter))
                                    .WhereIf(input.CategoryId.HasValue
                                                , product => product.CategoryId == input.CategoryId) 
                                    .Skip(input.SkipCount)
                                    .Take(input.MaxResultCount)
                                    .OrderBy(input.Sorting)
                                    .ToListAsync();
            var totalCount = input.Filter == null
                ? await productRepo.CountAsync()
                : await productRepo.CountAsync(product => product.NameAr.Contains(input.Filter) ||
                                                        product.NameEn.Contains(input.Filter));
            return new PagedResultDto<ProductDto>(
                totalCount,
                ObjectMapper.Map<List<Product>, List<ProductDto>>(products)
                );
        }

        [Authorize(OnLineStore_AbpPermissions.GetProductPermission)]
        public async Task<ProductDto> GetProductAsync(int id)
        {
            var product = await productRepo
                                    .WithDetailsAsync(product => product.Category)
                                    .Result
                                    .FirstOrDefaultAsync(x=>x.Id == id);
            if(product == null) {
                //throw new Exception("Product not found");
                // better do that
                throw new ProductNotFoundException(id);
            }
            return ObjectMapper.Map<Product, ProductDto>(product);
        }

        [Authorize(OnLineStore_AbpPermissions.CreateEditProductPermission)]
        public async Task<ProductDto> UpdateProductAsync(CreateUpdateProductDto input)
        {
            var validateResult = new CreateUpdateProductValidator().Validate(input);
            if (!validateResult.IsValid)
            {
                var exception = GetValidationException(validateResult);
                throw exception;
            }
            var existing = await productRepo.GetAsync(input.Id);
            if (existing == null)
            {
                throw new ProductNotFoundException(input.Id);
            }
            var mapped = ObjectMapper.Map<CreateUpdateProductDto, Product>(input,existing);
            var updated = await productRepo.UpdateAsync(mapped,autoSave:true);
            return ObjectMapper.Map<Product, ProductDto>(updated);
        }
        #endregion
    }
}
