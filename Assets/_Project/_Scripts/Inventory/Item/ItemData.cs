using Sirenix.OdinInspector;
using UnityEngine;

namespace Inventory.Item
{
    [CreateAssetMenu(menuName = "Items/New item", fileName = "New ItemData")]
    public class ItemData : ScriptableObject
    {
        [Title("Base")]
        [SerializeField, Required] private ItemType _itemType;
        
        [Title("Texts")]
        [SerializeField, Required] private string _nameKey;
        [SerializeField, Required] private string _descriptionKey;

        public ItemType ItemType => _itemType;

        public string NameKey => _nameKey;
        public string DescriptionKey => _descriptionKey;
    }
}