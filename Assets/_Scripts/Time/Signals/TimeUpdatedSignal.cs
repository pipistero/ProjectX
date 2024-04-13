using Zenject;

namespace Time.Signals
{
    public class TimeUpdatedSignal
    {
        public int CurrentTime { get; private set; }

        public TimeUpdatedSignal(int currentTime)
        {
            CurrentTime = currentTime;
        }
    }
}