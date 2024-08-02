using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MitreAttackWebApp.Models
{
    public class AttackDbContext : DbContext
    {
        public AttackDbContext() : base("name=MitreAttackDB")
        {
        }

        public DbSet<Attack> Attacks { get; set; }
    }
}