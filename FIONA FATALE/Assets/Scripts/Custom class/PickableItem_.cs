using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PickableItem_ 
{
    public bool isPicked;
    public Items items;

    [System.Serializable]
    public enum Items
    {
        none = 0,
        Screwdriver = 1,
        Key = 2,
    }
}
