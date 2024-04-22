using TMPro;
using UnityEngine;
using Zenject;

namespace Localization
{
    public class LocalizedText : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;

        [Inject]
        private void Construct()
        {
            
        }
    }
}