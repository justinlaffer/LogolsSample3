using System;
using System.Collections.Generic;

namespace TimeMachine
{
    public interface ITimeMachine
    {
        decimal DistanceTraveled {get; set;}

        void TimeTravel(int year);
    }
}