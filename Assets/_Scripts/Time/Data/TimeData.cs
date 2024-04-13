using System;

namespace Time
{
    public class TimeData
    {
        public event Action<int> TimeUpdated;
        public event Action<int> DayUpdated;
        
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
            
            TimeUpdated?.Invoke(CurrentTime);
        }

        public void AddOneDay()
        {
            CurrentDay++;
            
            DayUpdated?.Invoke(CurrentDay);
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