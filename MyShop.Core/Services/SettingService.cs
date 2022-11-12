using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop.Core.Services.Interfaces;
using MyShop.DataLayer.Entities;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyShop.Core.Generators;

using MyShop.DataLayer.Context;

namespace MyShop.Core.Services
{
    public class SettingService: ISettingService
    {
        private MyShopContext _context;
        public SettingService(MyShopContext context)
        {
            _context = context;
        }

        public int AddSetting(setting setting)
        {
            setting.CreateDtae = DateTime.Now;
            _context.Add(setting);
            _context.SaveChanges();

            return setting.ID;
        }

        public List<setting> GetAllSetting()
        {
            return _context.Settings.Where(s => s.IsDelete == false).ToList();
        }
    }
}
