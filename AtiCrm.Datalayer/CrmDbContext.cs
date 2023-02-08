using AtiCrm.Datalayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtiCrm.Datalayer
{
    public class CrmDbContext : DbContext
    {

        public CrmDbContext()
        {
        }

        public CrmDbContext(DbContextOptions<CrmDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=.;database=aticrm;trusted_connection=yes");
        }

        public DbSet<t_partner> t_partner { get; set; }
        public DbSet<t_partner_event> t_partner_event { get;set; }
    }
}
