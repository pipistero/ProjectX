using System.Collections.Generic;
using Localization.Asset;
using Localization.Service;
using UnityEngine;
using Zenject;

namespace _Infrastructure._Installers.Localization
{
    public class LocalizationInstaller : MonoInstaller
    {
        [SerializeField] private List<BaseLanguageAsset> _assets;
        
        public override void InstallBindings()
        {
            Container
                .Bind<ILocalizationService>()
                .FromInstance(new LocalizationService(_assets))
                .AsSingle();
        }
    }
}