using RaveTown.Items.Inventories;
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace RaveTown.Items.Inventories
{
public class ItemDestroyer : MonoBehaviour
{
    [SerializeField] private Inventory inventory = null;
    [SerializeField] private TextMeshProUGUI areyousureText= null;

    private int slotIndex = 0;

    private void OnDisable() => slotIndex = -1;
    public void Activate(ItemSlot itemSlot, int slotIndex)
    {
        this.slotIndex = slotIndex;
        areyousureText.text = $"Are you sure you wish to destroy{itemSlot.quantity}x{itemSlot.item.ColouredName}?";
        gameObject.SetActive(true);
    }
    public  void Destroy()
    {
        inventory.ItContainer.RemoveAt(slotIndex);
        gameObject.SetActive(false);
    }  
}
} 
