using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAssignmentPt1.Models
{
    public class MusicCD : Product
    {
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }
        public TimeSpan PlayingTime
        {
            get
            {
                // The lambda expresion below sums the length of the Track ticks in the list of Tracks by calling the Sum method. A single tick represents one hundred nanoseconds or one ten-millionth of a second. 
                // There are 10,000 ticks in a millisecond and 10 million ticks in a second. No wonder that a long data type is used :)

                //var totalTime = new TimeSpan(Tracks.Sum(r => r.Length.Ticks));

                TimeSpan totalTime = new TimeSpan(0);
                foreach (Track t in Tracks)
                {
                    totalTime += t.Length;
                }    
                return totalTime;
            }
        }
        // a read-only property of List collection of custom type Track. Notice that we create an empty instance of the list. If we don't we will get an error 
        //"Object reference not set to an instance of an object" when we call the AddTrack method
        public List<Track> Tracks { get; } = new List<Track>();

        public MusicCD(string artist, string title, decimal price, short released)
        {
            Artist = artist;
            Title = title;
            Price = price;
            Released = released;
        }
        // the method that adds a Track object to the List collection of type Track. When is the list initialized? When we call the method?
        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }
    }
}
