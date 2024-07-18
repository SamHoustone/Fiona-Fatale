using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public List<PickableItem_> PickableItems = new List<PickableItem_>();

    public void AddItemToInvetory(PickableItem_.Items itemsPicked)
    {
        PickableItems[((int)itemsPicked)].isPicked = true;
    }
}
