using RaveTown.Events;
using System;
using UnityEngine;



namespace RaveTown.Items
{
[CreateAssetMenu(fileName = "New Inventory", menuName = "Items/Inventory")]
    public class Inventory : ScriptableObject
    {
        
        [SerializeField] private VoidEvent onInventoryItemsUpdated = null;
        [SerializeField] private ItemSlot testItemSlot = new ItemSlot();

        public ItContainer ItContainer { get;} = new ItContainer(9);
        public void OnEnable() => ItContainer.OnItemsUpdated += onInventoryItemsUpdated.Raise;
        public void OnDisable() => ItContainer.OnItemsUpdated -= onInventoryItemsUpdated.Raise;
        
        [ContextMenu("Test Add Item")]
        public void TestAddItem()
        {
            ItContainer.AddItem(testItemSlot);
        }
    }

}
