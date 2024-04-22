using System;

namespace Time
{
    public class TimeData
    {
        public event Action<TimeData> TimeUpdated;
        public event Action<TimeData> DayUpdated;
        
        public int CurrentDay { get; private set; }
        public int CurrentTime { get; private set; }
        
        public void Tick(int tickValue, int maxValue)
        {
            CurrentTime += tickValue;

            if (CurrentTime >= maxValue)
            {
                CurrentTime = 0;
                AddOneDay();
            }
            
            TimeUpdated?.Invoke(this);
        }

        public void AddOneDay()
        {
            CurrentDay++;
            
            DayUpdated?.Invoke(this);
        }

        public static TimeData CreateDefault()
        {
            return new TimeData()
            {
                CurrentDay = 1,
                CurrentTime = 0
            };
        }
    }
}