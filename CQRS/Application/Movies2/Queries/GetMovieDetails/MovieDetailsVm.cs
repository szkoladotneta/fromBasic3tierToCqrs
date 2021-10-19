using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Movies2.Queries.GetMovieDetails
{
    public record MovieDetailsVm(int MovieId, 
        string MovieName, 
        string Director, 
        string Country, 
        int? Length, 
        DateTime? ReminderDate, 
        bool? IsLost, 
        string LostReason, 
        string MovieCategoryName, 
        string ProducerName);
}
