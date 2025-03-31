using System;
using RaveTown.Items;
using UnityEngine.Events;


namespace RaveTown.Events.UnityEvents
{
    [Serializable] public class UnityHotbarItemEvent : UnityEvent<HotbarItem> { }
}