using OnLineStore_Abp.Samples;
using Xunit;

namespace OnLineStore_Abp.EntityFrameworkCore.Domains;

[Collection(OnLineStore_AbpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<OnLineStore_AbpEntityFrameworkCoreTestModule>
{

}
