using Microsoft.Extensions.Localization;
using OnLineStore_Abp.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace OnLineStore_Abp;

[Dependency(ReplaceServices = true)]
public class OnLineStore_AbpBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<OnLineStore_AbpResource> _localizer;

    public OnLineStore_AbpBrandingProvider(IStringLocalizer<OnLineStore_AbpResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
