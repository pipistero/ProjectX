namespace Infrastructure.GameBootstraper
{
    public interface IGameBootstrap
    {
        bool IsInitialized { get; }
        
        void Bootstrap();
    }
}