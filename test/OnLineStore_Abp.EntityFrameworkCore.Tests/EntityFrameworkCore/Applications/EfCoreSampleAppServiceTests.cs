using OnLineStore_Abp.Samples;
using Xunit;

namespace OnLineStore_Abp.EntityFrameworkCore.Applications;

[Collection(OnLineStore_AbpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<OnLineStore_AbpEntityFrameworkCoreTestModule>
{

}
