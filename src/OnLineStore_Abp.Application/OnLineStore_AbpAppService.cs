using System;
using System.Collections.Generic;
using System.Text;
using OnLineStore_Abp.Localization;
using Volo.Abp.Application.Services;

namespace OnLineStore_Abp;

/* Inherit your application services from this class.
 */
public abstract class OnLineStore_AbpAppService : ApplicationService
{
    protected OnLineStore_AbpAppService()
    {
        LocalizationResource = typeof(OnLineStore_AbpResource);
    }
}
