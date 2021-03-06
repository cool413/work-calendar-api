﻿using System;
using Common.Interfaces;

namespace Common.Models
{
    public abstract class TrackableEntry : ITrack
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}