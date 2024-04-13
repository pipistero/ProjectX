namespace Time.Signals
{
    public class DayUpdatedSignal
    {
        public int CurrentDay { get; private set; }

        public DayUpdatedSignal(int currentDay)
        {
            CurrentDay = currentDay;
        }
    }
}