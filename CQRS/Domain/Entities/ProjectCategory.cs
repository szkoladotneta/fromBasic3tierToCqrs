using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProjectCategory :AuditableEntity
    {
        public int ProjectCategoryId { get; set; }
        public string ProjectCategoryName { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
