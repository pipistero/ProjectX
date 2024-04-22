using System;
using UnityEngine;

namespace _Infrastructure.Observable
{
    [Serializable]
    public class ObservableVariable<T> : IObservableVariable<T>
    {
        public event Action<T> ValueChanged;

        [SerializeField] private T _value;
        
        public T Value
        {
            get => _value;
            set
            {
                if (Equals(_value, value)) 
                    return;
                
                _value = value;
                ValueChanged?.Invoke(value);
            }
        }

        public ObservableVariable(T value)
        {
            _value = value;
        }
    }
}