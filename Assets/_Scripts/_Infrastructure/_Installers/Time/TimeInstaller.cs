using Time;
using Time.Signals;
using UnityEngine;
using Zenject;

namespace _Infrastructure._Installers.Time
{
    public class TimeInstaller : MonoInstaller
    {
        [SerializeField] private TimeSettings _timeSettings; 
        
        public override void InstallBindings()
        {
            SignalBusInstaller.Install(Container);
            
            InstallSignals();
            InstallTimeSettings();
            InstallTimeController();
        }

        private void InstallSignals()
        {
            Container.DeclareSignal<TimeUpdatedSignal>();
            Container.DeclareSignal<DayUpdatedSignal>();
        }

        private void InstallTimeSettings()
        {
            Container
                .Bind<TimeSettings>()
                .FromInstance(_timeSettings)
                .AsSingle();
        }

        private void InstallTimeController()
        {
            Container
                .Bind<TimeController>()
                .AsSingle();
        }
    }
}