using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace RaveTown.Items
{

public class InventorySlot : ItemSlotUI, IDropHandler
{
    //Idrop handler

    [SerializeField] private Inventory inventory = null;
    [SerializeField]private TextMeshProUGUI itemQuantityText = null;
    public override HotbarItem SlotItem
    {
        get { return ItemSlot.item;}
        set{}
    }
    public ItemSlot ItemSlot => inventory.ItContainer.GetSlotByIndex(SlotIndex);
    public override void OnDrop(PointerEventData eventData)
    {
       
        ItemDragHandler itemDragHandler = eventData.pointerDrag.GetComponent<ItemDragHandler>();
        if(itemDragHandler == null){return;}
        if((itemDragHandler.ItemSlotUI as InventorySlot) != null)
        {
            inventory.ItContainer.Swap(itemDragHandler.ItemSlotUI.SlotIndex, SlotIndex);
        }  
    }
    public override void UpdateSlotUI()
    {
        if(ItemSlot.item == null)
        {
            EnableSlotUI(false);
            return;
        }
        EnableSlotUI(true);
        itemIconImage.sprite = ItemSlot.item.Icon;
        itemQuantityText.text = ItemSlot.quantity > 1 ? ItemSlot.quantity.ToString() : "";
    }
        protected override void EnableSlotUI(bool enable)
        {
            base.EnableSlotUI(enable);
        }
    }
}