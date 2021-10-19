using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Project: AuditableEntity
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ProjectCategoryId { get; set; }
        public ProjectCategory ProjectCategory { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
