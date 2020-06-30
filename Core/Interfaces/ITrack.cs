using System;

namespace Core.Interfaces
{
    public interface ITrack
    {
        DateTime CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}