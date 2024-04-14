using Zenject;

namespace _Infrastructure._Installers.Signals
{
    public class BusSignalInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            SignalBusInstaller.Install(Container);
        }
    }
}