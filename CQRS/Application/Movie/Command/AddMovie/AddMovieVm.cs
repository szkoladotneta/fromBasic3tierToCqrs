using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Movie.Command.AddMovie
{
    public class AddMovieVm
    {
        public string MovieName { get; set; }
        public string Director { get; set; }
        public string Country { get; set; }
        public int? Length { get; set; }
        public DateTime? ReminderDate { get; set; }
        public bool? IsLost { get; set; }
        public string LostReason { get; set; }
        public string MovieCategoryName { get; set; }
        public string ProducerName { get; set; }
    }
}
