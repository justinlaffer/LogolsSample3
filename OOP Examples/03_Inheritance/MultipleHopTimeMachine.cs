using System;
using System.Collections.Generic;

namespace TimeMachine
{
    public sealed class MultipleHopTimeMachine : TimeMachine
    {
        public override void TimeTravel(int year)
        {
            base.TimeTravel(year + 5);
            base.TimeTravel(year);
        }       
    }
}