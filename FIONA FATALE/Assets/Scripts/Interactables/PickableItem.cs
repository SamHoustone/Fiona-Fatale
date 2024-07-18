using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PickableItem;

public class PickableItem : MonoBehaviour, IInteractable
{
    public GameManager manager;

    public PickableItem_.Items items = new PickableItem_.Items();

    private void Start()
    {
        manager = FindAnyObjectByType<GameManager>();
    }
    public void Interact()
    {
        switch (items)
        {
            case PickableItem_.Items.Screwdriver:
                manager.AddItemToInvetory(PickableItem_.Items.Screwdriver);
                FindObjectOfType<DialougeManager>().ShowDialouge("Maybe i can use this");
                Destroy(gameObject);
                break;
        }
    }

    public interface IInteractable
    {
        void Interact();
    }
}
