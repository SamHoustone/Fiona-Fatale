using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static PickableItem;

public class InteractableItem : MonoBehaviour , IInteractable
{
    public InteractableItem_.Items interactableItems = new InteractableItem_.Items();
    public GameObject lazer1, lazer2;
    public void Interact()
    {
        if (interactableItems == InteractableItem_.Items.TriggerToLazerHallway)
        {
            SceneManager.LoadScene("2");
        }
        if(interactableItems == InteractableItem_.Items.TriggerToSecurityRoom)
        {
            SceneManager.LoadScene("3");
        }
        if(interactableItems == InteractableItem_.Items.TriggerToEndRoom)
        {
            SceneManager.LoadScene("End");
        }
        if (interactableItems == InteractableItem_.Items.RedButton)
        {
            FindAnyObjectByType<DialougeManager>().ShowDialouge("Looks like it turned off the lazers ");
            lazer1.SetActive(false);
            lazer2.SetActive(false);
            PlayerPrefs.SetInt("isLazerOff", 1);
        }
    }

    public interface IInteractable
    {
        void Interact();
    }

}
