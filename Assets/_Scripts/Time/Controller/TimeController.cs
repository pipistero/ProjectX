using System;

namespace Time
{
    public class TimeController : ITimeController
    {
        public event Action<TimeData> TimeUpdated;
        public event Action<TimeData> DayUpdated;
        
        public TimeData CurrentTime { get; private set; }

        private readonly TimeSettings _settings;
        
        public TimeController(TimeSettings settings)
        {
            _settings = settings;
            
            CurrentTime = TimeData.CreateDefault();
            
            SubscribeEvents();
        }
        
        public void Tick()
        {
            CurrentTime.Tick(_settings.TickValue, _settings.MaxTickValue);
        }

        public void AddOneDay()
        {
            CurrentTime.AddOneDay();
        }

        private void SubscribeEvents()
        {
            CurrentTime.TimeUpdated += time => TimeUpdated?.Invoke(time);
            CurrentTime.DayUpdated += time => DayUpdated?.Invoke(time);
        }
    }
}