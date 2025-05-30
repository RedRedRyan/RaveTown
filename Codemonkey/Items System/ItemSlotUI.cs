using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;


namespace RaveTown.Items
{

public abstract class ItemSlotUI : MonoBehaviour, IDropHandler
{
    [SerializeField] protected Image itemIconImage = null;
    public int SlotIndex{ get; private set; }
    public abstract HotbarItem SlotItem { get;  set; }

    private void OnEnable() => UpdateSlotUI();
    protected virtual void Start()
    {
        SlotIndex = transform.GetSiblingIndex();
        UpdateSlotUI();
    }
    public abstract void OnDrop(PointerEventData eventData);
    public abstract void UpdateSlotUI();
    protected virtual void EnableSlotUI(bool enable)
    {
        itemIconImage.enabled= enable;
    }
    
}
}
