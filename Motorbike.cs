﻿using System.Runtime.Serialization;

namespace Business_Logic
{
    [DataContract]
    public class Motorbike : Transport
    {
        public Motorbike()
        {
            this.speed = 90;
            this.carryingCapacity = 20;
            this.timeBeforeAvailability = 0;
        }

    }
}