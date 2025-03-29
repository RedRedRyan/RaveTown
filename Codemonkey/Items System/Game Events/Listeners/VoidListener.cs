using UnityEngine;
using UnityEngine.Events;
using RaveTown.Events.Customevents;
using RaveTown.Events.Listeners;

namespace RaveTown.Events

{
    public class VoidListener : BaseGameEventListener<Void, VoidEvent, UnityVoidEvent>{}
}