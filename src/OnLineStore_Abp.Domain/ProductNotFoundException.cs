using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace OnLineStore_Abp
{
    public class ProductNotFoundException : BusinessException
    {
        public ProductNotFoundException(int id):base(OnLineStore_AbpDomainErrorCodes.ProductNotFound)
        {
            WithData("id",id);
        }
    }
}
