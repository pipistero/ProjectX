using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Widgets
{
    public abstract class Widget : SerializedMonoBehaviour, IWidget
    {
        [FoldoutGroup("Visual dependencies")] 
        [SerializeField, Required] protected CanvasGroup _canvasGroup;
        
        [FoldoutGroup("Visual dependencies")] 
        [SerializeField, Required] protected Canvas _canvas;
        
        public WidgetStatus Status { get; protected set; }

        public UniTask Open()
        {
            gameObject.SetActive(true);
            
            Status = WidgetStatus.Open;
            
            return UniTask.CompletedTask;
        }

        public UniTask Close()
        {
            gameObject.SetActive(false);
            
            Status = WidgetStatus.Close;
            
            return UniTask.CompletedTask;
        }
    }
}