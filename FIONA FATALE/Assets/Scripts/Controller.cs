using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public LevelManager levelManager;
    public int currentCamIndex = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                switch (hit.collider.tag)
                {
                    case "Interactable" :
                        CamInfo caminfo = hit.collider.gameObject.GetComponent<ItemCamReferencer>().camInfo;
                        caminfo.isOn = true;
                        int index = caminfo.camIndex;
                        currentCamIndex = index;
                        levelManager.MoveCamera(index); 
                        break;
                    case "Key":
                        hit.collider.GetComponent<Keys>().SendData();
                        break;
                    case "Locker":
                        Locker locker = hit.collider.GetComponentInParent<Locker>();
                        locker.PlayOpen(hit.collider.gameObject.name);
                        break;
                    case "Pickable":
                        hit.collider.GetComponent<PickableItem>().Interact();
                        break;
                    case "EndTrigger":
                        hit.collider.GetComponent <InteractableItem>().Interact();
                        break;
                    case "RedButton":
                        hit.collider.GetComponent<InteractableItem>().Interact();
                        break;
                    case "LazerDoor":
                        SceneManager.LoadScene(3);
                        break;
                }

            }
        }
        else if(Input.GetMouseButtonDown(1))
        {
            if(currentCamIndex != 0)
            {
                FindAnyObjectByType<DialougeManager>().HideDialougue();
                levelManager.MoveCameraBack();
            }
        }
    }

    public void SetInventoryItemInteract(PickableItem_.Items ItemName)
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Physics.Raycast(ray, out hit);
        print(hit.collider.gameObject.name);
        CamInfo camInfo = hit.collider.gameObject.GetComponent<ItemCamReferencer>().camInfo;
        if (ItemName == camInfo.itemNeeded)
        {
            print("UES");
            camInfo.PlayAction();
        }
    }
}
