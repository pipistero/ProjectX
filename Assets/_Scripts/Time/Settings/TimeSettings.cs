using UnityEngine;

namespace Time
{
    [CreateAssetMenu(menuName = "Time/Time settings", fileName = "New Time settings")]
    public class TimeSettings : ScriptableObject
    {
        [field: SerializeField] public int MaxTickValue { get; private set; }
        [field: SerializeField] public int TickValue { get; private set; }
    }
}