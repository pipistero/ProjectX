using Cysharp.Threading.Tasks;
using UnityEngine;
using Widgets.Interfaces;

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