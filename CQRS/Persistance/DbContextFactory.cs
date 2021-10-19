using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class DbContextFactory : DesignTimeDbContextFactoryBase<MyDbContext>
    {
        protected override MyDbContext CreateNewInstance(DbContextOptions<MyDbContext> options)
        {
            return new MyDbContext(options);
        }
    }
}
