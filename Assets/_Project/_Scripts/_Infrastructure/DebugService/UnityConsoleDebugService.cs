using UnityEngine;

namespace Infrastructure.DebugService
{
    public class UnityConsoleDebugService : IDebugService
    {
        public void DebugMessage(string message, object sender)
        {
            Debug.Log($"{message}; Sender - {sender}");
        }

        public void DebugError(string message, object sender)
        {
            Debug.LogError($"{message}; Sender - {sender}");
        }

        public void DebugWarning(string message, object sender)
        {
            Debug.LogWarning($"{message}; Sender - {sender}");
        }
    }
}