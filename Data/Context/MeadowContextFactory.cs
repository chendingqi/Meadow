using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public class MeadowContextFactory : IDesignTimeDbContextFactory<MeadowContext>
    {
        MeadowContext IDesignTimeDbContextFactory<MeadowContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MeadowContext>();
            optionsBuilder.UseSqlServer("data source=127.0.0.1;initial catalog=Meadow;user id=sa;password=123456;");
            return new MeadowContext(optionsBuilder.Options);
        }
    }
}
