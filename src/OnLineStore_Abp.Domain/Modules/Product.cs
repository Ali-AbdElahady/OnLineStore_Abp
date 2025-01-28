using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
namespace OnLineStore_Abp.Modules;

public class Product : FullAuditedEntity<int>
{
    public string NameAr { get; set; }
    public string NameEn { get; set; }
    public string DescriptionAr { get; set; }
    public string DescriptionEn { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
}
