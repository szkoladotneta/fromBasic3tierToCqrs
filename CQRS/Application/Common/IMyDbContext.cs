using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    public interface IMyDbContext
    {
        DbSet<Project> Projects { get; set; }
        DbSet<Domain.Entities.Movie> Movies { get; set; }
        DbSet<MovieCategory> MovieCategories { get; set; }
        DbSet<Producer> Producers { get; set; }
        DbSet<ProjectCategory> ProjectCategories { get; set; }

        int SaveChanges();
    }
}
