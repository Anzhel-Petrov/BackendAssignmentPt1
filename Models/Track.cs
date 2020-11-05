using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAssignmentPt1.Models
{
    public class Track
    {
        public string Title { get; set; }
        public TimeSpan Length { get; set; }
        public string Composer { get; set; }
        public Track(string title, TimeSpan length)
        {
            Title = title;
            Length = length;
        }
    }
}
