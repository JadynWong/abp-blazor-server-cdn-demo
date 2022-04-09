using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.Blazor.Pages.Components.FontAwesome
{
    public class FontAwesomeViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("/Pages/Shared/Components/FontAwesome/Default.cshtml");
        }
    }
}
