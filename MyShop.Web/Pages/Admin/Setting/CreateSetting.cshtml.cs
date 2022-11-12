using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShop.Core.Services.Interfaces;

namespace MyShop.Web.Pages.Admin.Setting
{
    public class CreateSettingModel : PageModel
    {
        private ISettingService _settingService;
        public CreateSettingModel(ISettingService settingService)
        {
            _settingService = settingService;
        }

        [BindProperty] 
        public DataLayer.Entities.setting Setting { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _settingService.AddSetting(Setting);
            return RedirectToPage("Index");
        }
    }
}
