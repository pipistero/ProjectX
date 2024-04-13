namespace Time
{
    public interface ITimeController
    {
        TimeData CurrentTime { get; }
        
        void Tick();
        void AddOneDay();
    }
}