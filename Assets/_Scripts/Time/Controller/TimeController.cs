using System;
using Time.Signals;
using Zenject;

namespace Time
{
    public class TimeController : ITimeController
    {
        public TimeData CurrentTime { get; private set; }

        private readonly TimeSettings _settings;
        private readonly SignalBus _signalBus;
        
        public TimeController(TimeSettings settings, SignalBus signalBus)
        {
            _settings = settings;
            _signalBus = signalBus;
            
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
            CurrentTime.TimeUpdated += currentTime => _signalBus.Fire(new TimeUpdatedSignal(currentTime));
            CurrentTime.DayUpdated += currentDay => _signalBus.Fire(new DayUpdatedSignal(currentDay));
        }
    }
}