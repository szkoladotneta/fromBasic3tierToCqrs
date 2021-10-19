using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Models
{
    public class MovieVM
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
        public string MovieCategoryName { get; set; }
        public int ProducerId { get; set; }
        public string ProducerName { get; set; }
    }
}
