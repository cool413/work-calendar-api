using System;

namespace Common.Interfaces
{
    public interface ITrack
    {
        DateTime CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}