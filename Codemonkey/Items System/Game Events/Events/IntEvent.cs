using RaveTown.Events.Customevents;
using UnityEngine;
namespace RaveTown.Events

{
    [CreateAssetMenu(fileName = "New Int Event", menuName = "Game Events/Int Event")]
    public class IntEvent :  BaseGameEvent<int> {}
}