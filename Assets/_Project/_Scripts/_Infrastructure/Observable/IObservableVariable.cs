using System;

namespace _Infrastructure.Observable
{
    public interface IObservableVariable<T>
    {
        event Action<T> ValueChanged;

        T Value { get; set; }
    }
}