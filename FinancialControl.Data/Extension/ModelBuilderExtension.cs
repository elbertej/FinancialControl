using FinancialControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialControl.Data.Extension
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
                                new User { Id = Guid.Parse("7298f79b-a5cf-4331-a133-8b34159931db"), Name = "User Default", Email = "userdefault@financialcontrol.com" }
                                );

            return builder;
        }
    }
}
