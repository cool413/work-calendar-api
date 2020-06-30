using System;
using Core.Interfaces;

namespace Core.Models
{
    public abstract class TrackableEntry : ITrack
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}