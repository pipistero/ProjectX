using System;
using UnityEngine;
using Widgets.Controller;
using Zenject;

namespace Widgets.Test
{
    public class TestInput : MonoBehaviour
    {
        private IWidgetsController _widgetsController;

        [Inject]
        private void Construct(IWidgetsController widgetsController)
        {
            _widgetsController = widgetsController;
        }
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.O))
                _widgetsController.Open<MenuWidget>();

            if (Input.GetKeyDown(KeyCode.C))
                _widgetsController.Close<MenuWidget>();
        }
    }
}