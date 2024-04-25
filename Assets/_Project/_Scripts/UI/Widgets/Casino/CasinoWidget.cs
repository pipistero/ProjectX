using _Infrastructure.Observable;
using Cysharp.Threading.Tasks;
using Localization;
using Localization.Service;
using TMPro;
using UnityEngine;
using Zenject;

namespace UI.Widgets.Casino
{
    public class CasinoWidget : Widget
    {
        [SerializeField] private ObservableVariable<int> _coinsCount;
        [SerializeField] private TextMeshProUGUI _coinsText;

        private ILocalizationService _localizationService;
        
        private string _coinsRawText;

        [Inject]
        private void Construct(ILocalizationService localizationService)
        {
            _localizationService = localizationService;
            _localizationService.LanguageChanged += _ => _coinsRawText = _localizationService.Get("CoinsText");
        }
        
        public override UniTask OnOpen()
        {
            _coinsRawText = _localizationService.Get("CoinsText");
            
            _coinsCount.Value = 0;
            _coinsCount.ValueChanged += coins => _coinsText.text = $"{_coinsRawText} = {coins}"; 

            return UniTask.CompletedTask;
        }

        private void Update()
        {
            if (Status != WidgetStatus.Open)
                return;
            
            _coinsCount.Value++;
            
            if (Input.GetKeyDown(KeyCode.E))
                _localizationService.ChangeLanguage(LanguageType.English);
            
            if (Input.GetKeyDown(KeyCode.R))
                _localizationService.ChangeLanguage(LanguageType.Russian);
        }
    }
}