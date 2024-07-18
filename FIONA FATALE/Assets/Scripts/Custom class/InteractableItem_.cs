using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class InteractableItem_
{
    public bool hasTheItemToUse;
    public Items items;

    [System.Serializable]
    public enum Items
    {
        Vent = 0,
        RedButton = 1,
        TriggerToLazerHallway = 2,
        TriggerToSecurityRoom = 3,
        TriggerToEndRoom = 4,
    }
}
