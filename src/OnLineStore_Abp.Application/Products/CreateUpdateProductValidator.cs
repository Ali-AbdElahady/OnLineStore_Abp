using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore_Abp.Products
{
    public class CreateUpdateProductValidator : AbstractValidator<CreateUpdateProductDto>
    {
        public CreateUpdateProductValidator()
        {
            RuleFor(x => x.NameAr)
                .NotEmpty()
                .MaximumLength(OnLineStore_AbpConsts.GeneralTextMaxLength)
                .WithErrorCode(OnLineStore_AbpDomainErrorCodes.InvalidProductDataName)
                .WithMessage("Product name in Arabic is invalid");
            RuleFor(x => x.NameEn)
                .NotEmpty()
                .MaximumLength(OnLineStore_AbpConsts.GeneralTextMaxLength)
                .WithErrorCode(OnLineStore_AbpDomainErrorCodes.InvalidProductDataName)
                .WithMessage("Product name in Englis is invalid");
            RuleFor(x => x.DescriptionAr)
                .NotEmpty()
                .MaximumLength(OnLineStore_AbpConsts.GeneralTextMaxLength)
                .WithErrorCode(OnLineStore_AbpDomainErrorCodes.InvalidProductDataDescription)
                .WithMessage("Product description in Arabic is invalid");
            RuleFor(x => x.NameAr)
                .NotEmpty()
                .MaximumLength(OnLineStore_AbpConsts.GeneralTextMaxLength)
                .WithErrorCode(OnLineStore_AbpDomainErrorCodes.InvalidProductDataDescription)
                .WithMessage("Product description in English is invalid");
            RuleFor(x => x.CategoryId)
                .NotEmpty()
                .WithErrorCode(OnLineStore_AbpDomainErrorCodes.InvalidProductDataDescription)
                .WithMessage("Product description in English is invalid");
        }
    }
}
