using System;
using Time.Signals;
using TMPro;
using UnityEngine;
using Zenject;

namespace Time
{
    public class TestUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _timeText;
        [SerializeField] private TextMeshProUGUI _dayText;
        
        private SignalBus _signalBus;

        [Inject]
        private void Construct(SignalBus signalBus)
        {
            _signalBus = signalBus;
        }

        private void Awake()
        {
            _signalBus.Subscribe<TimeUpdatedSignal>(OnTimeUpdated);
            _signalBus.Subscribe<DayUpdatedSignal>(OnDayUpdated);
        }

        private void OnDayUpdated(DayUpdatedSignal signal)
        {
            _dayText.text = $"Day = {signal.CurrentDay}";
        }

        private void OnTimeUpdated(TimeUpdatedSignal signal)
        {
            _timeText.text = $"Time = {signal.CurrentTime}";
        }
    }
}