using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShop.Core.Services.Interfaces;
using System.Collections.Generic;

namespace MyShop.Web.Pages.Admin.Setting
{
    public class IndexModel : PageModel
    {
        private ISettingService _settingService;
        public IndexModel(ISettingService settingService)
        {
            _settingService = settingService;
        }

        [BindProperty]
        public List<MyShop.DataLayer.Entities.setting> Setting { get; set; }
        public void OnGet()
        {
            Setting=_settingService.GetAllSetting();
        }
    }
}
