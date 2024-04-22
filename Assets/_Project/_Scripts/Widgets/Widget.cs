using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;
using Widgets.Animations;
using Widgets.Interfaces;

namespace Widgets
{
    public abstract class Widget : MonoBehaviour, IWidget
    {
        [FoldoutGroup("Visual")] 
        [SerializeField, Required] protected CanvasGroup _canvasGroup;
        
        [FoldoutGroup("Visual")] 
        [SerializeField, Required] protected Canvas _canvas;

        [FoldoutGroup("Animations")] 
        [SerializeField, Required, ChildGameObjectsOnly] protected WidgetAnimation _widgetAnimation;
        
        public WidgetStatus Status { get; private set; }

        public async UniTask Open()
        {
            gameObject.SetActive(true);

            await AnimateOpen();
            
            Status = WidgetStatus.Open;
        }

        public async UniTask Close()
        {
            await AnimateClose();
                
            gameObject.SetActive(false);
            
            Status = WidgetStatus.Close;
        }

        private UniTask AnimateOpen() => _widgetAnimation.AnimateOpen(this);
        private UniTask AnimateClose() => _widgetAnimation.AnimateClose(this);
    }
}