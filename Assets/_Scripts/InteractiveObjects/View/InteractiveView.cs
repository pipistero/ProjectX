using System;
using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace InteractiveObjects.Controller
{
    public abstract class InteractiveView<TInteractive> : MonoBehaviour
        where TInteractive : IInteractive
    {
        [SerializeField, Required] protected Button _button;

        private TInteractive _interactive;

        public void Start()
        {
            _button.onClick.AddListener(OnInteract);
        }

        [Inject]
        protected virtual void Construct(TInteractive interactive)
        {
            _interactive = interactive;
        }
        
        protected virtual void OnInteract()
        {
            _interactive.Interact();
        }
    }
}