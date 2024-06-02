﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Warmhouse_Models;
using Warmhouse_Utility;
using System;
using System.Linq;

namespace Warmhouse_DataAccess.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public object WC { get; private set; }

        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch(Exception ex)
            {

            }


            if (!_roleManager.RoleExistsAsync(Warmhouse_Utility.WC.AdminRole).GetAwaiter().GetResult())
            {
                 _roleManager.CreateAsync(new IdentityRole(Warmhouse_Utility.WC.AdminRole)).GetAwaiter().GetResult();
                 _roleManager.CreateAsync(new IdentityRole(Warmhouse_Utility.WC.CustomerRole)).GetAwaiter().GetResult();
            }
            else
            {
                return;
            }

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                FullName = "Admin Tester",
                PhoneNumber = "111111111111"
            }, "Admin123*").GetAwaiter().GetResult();

            ApplicationUser user = _db.ApplicationUser.FirstOrDefault(u => u.Email == "admin@gmail.com");
            _userManager.AddToRoleAsync(user, Warmhouse_Utility.WC.AdminRole).GetAwaiter().GetResult();


        }
    }
}
