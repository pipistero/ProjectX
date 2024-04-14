using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Widgets.Test
{
    public class MenuWidget : Widget, IInitializedWidget
    {
        public UniTask Initialize()
        {
            Debug.Log("TestWidget initialization");

            return UniTask.CompletedTask;
        }
    }
}