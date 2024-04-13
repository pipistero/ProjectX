using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Time.Signals
{
    public class TestInvoker : MonoBehaviour
    {
        private TimeController _timeController;

        [Inject]
        private void Construct(TimeController timeController)
        {
            _timeController = timeController;
        }

        private void Awake()
        {
            TickTime();
        }

        private async void TickTime()
        {
            while (true)
            {
                _timeController.Tick();

                await UniTask.WaitForSeconds(1);
            }
        }
    }
}