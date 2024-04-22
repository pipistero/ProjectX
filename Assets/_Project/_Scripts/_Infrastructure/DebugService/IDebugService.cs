namespace Infrastructure.DebugService
{
    public interface IDebugService
    {
        void DebugMessage(string message, object sender);
        void DebugError(string message, object sender);
        void DebugWarning(string message, object sender);
    }
}