using Time;
using UnityEngine;
using Zenject;

namespace _Infrastructure._Installers.Time
{
    public class TimeInstaller : MonoInstaller
    {
        [SerializeField] private TimeSettings _timeSettings; 
        
        public override void InstallBindings()
        {
            InstallTimeSettings();
            InstallTimeController();
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