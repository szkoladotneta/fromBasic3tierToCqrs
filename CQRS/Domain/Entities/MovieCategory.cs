using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MovieCategory
    {
        public int MovieCategoryId { get; set; }
        public string MovieCategoryName { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
