using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-MJGGV3B;initial catalog=EasyCashDb;integrated Security=true");
        }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<CustomerAccountProcess> CustomerAccountsProcess { get; set; }
    }
}
