using System;
using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using UI.Widgets.Interfaces;

namespace UI.Widgets.Controller
{
    public class WidgetsController : IWidgetsController
    {
        private readonly Dictionary<Type, IWidget> _widgetsMap;
        
        public WidgetsController(IEnumerable<IWidget> widgets)
        {
            _widgetsMap = widgets.ToDictionary(w => w.GetType());
        }
        
        public UniTask InitializeAsync()
        {
            var initializationTasks = new List<UniTask>(_widgetsMap.Count);
            
            foreach (var widget in _widgetsMap.Values)
            {
                widget.Close();

                if (widget is IInitializedWidget initializedWidget)
                {
                    var task = initializedWidget.Initialize();
                    initializationTasks.Add(task);
                }
            }

            return UniTask.WhenAll(initializationTasks);
        }
        
        public async UniTask<TWidget> Open<TWidget>() where TWidget : class, IWidget
        {
            var widget = GetWidget<TWidget>();

            await widget.OnOpen();
            await widget.Open();

            return widget;
        }

        public async UniTask<TWidget> Close<TWidget>() where TWidget : class, IWidget
        {
            var widget = GetWidget<TWidget>();

            await widget.Close();
            await widget.OnClose();

            return widget;
        }

        public TWidget GetWidget<TWidget>() where TWidget : class, IWidget
        {
            try
            {
                return _widgetsMap[typeof(TWidget)] as TWidget;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception($"[WidgetsController] | Widget with type [{typeof(TWidget)}] not found");
            }
        }
    }
}