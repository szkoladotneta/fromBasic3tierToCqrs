using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Movie : AuditableEntity
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Director { get; set; }
        public string Country { get; set; }
        public int? Length { get; set; }
        public DateTime? ReminderDate { get; set; }
        public bool? IsLost { get; set; }
        public string LostReason { get; set; }
        public int MovieCategoryId { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public int ProducerId { get; set; }
        public virtual Producer Producer { get; set; }

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
