using _Infrastructure.Observable;
using Cysharp.Threading.Tasks;
using Localization.Asset;
using TMPro;
using UnityEngine;

namespace Widgets.Casino
{
    public class CasinoWidget : Widget
    {
        [SerializeField] private ObservableVariable<int> _coinsCount;
        [SerializeField] private TextMeshProUGUI _coinsText;
        
        public override UniTask OnOpen()
        {
            _coinsCount.Value = 0;
            _coinsCount.ValueChanged += coins => _coinsText.text = $"Coins = {coins}"; 

            return UniTask.CompletedTask;
        }

        private void Update()
        {
            if (Status != WidgetStatus.Open)
                return;
            
            _coinsCount.Value++;
        }
    }
}