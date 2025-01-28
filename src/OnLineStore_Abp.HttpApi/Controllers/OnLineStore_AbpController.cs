using OnLineStore_Abp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OnLineStore_Abp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class OnLineStore_AbpController : AbpControllerBase
{
    protected OnLineStore_AbpController()
    {
        LocalizationResource = typeof(OnLineStore_AbpResource);
    }
}
