using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   public List<CamInfo> camInfos = new List<CamInfo>();
   public GameObject LazerGate1, LazerGate2, LazerGate3, LazerGate4,ScreDriver, Vent;
   public int currentCameraIndex = 0;


    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            Debug.Log(PlayerPrefs.GetInt("isLazerOff"));
            if(PlayerPrefs.GetInt("isLazerOff") == 1)
            {
                LazerGate1.SetActive(false);
                LazerGate2.SetActive(false);
                LazerGate3.SetActive(false);
                ScreDriver.SetActive(false);
                Vent.SetActive(false);
                LazerGate4.SetActive(true);
            }
        }
    }

    public void MoveCamera(int index)
    {
        currentCameraIndex = index;

        camInfos[index].ItemvirtualCamera.enabled = true;

        if (index != 0)
        {
            camInfos[index].ItemCollider.enabled = false;

        }

        for (int i = 0; i < camInfos.Count; i++) 
        {
            if(i != index)
            {
                camInfos[i].ItemvirtualCamera.enabled = false;
                if(i != 0)
                {
                    camInfos[i].ItemCollider.enabled = true;
                }

            }
        }
    }
    public void MoveCameraBack()
    {
        if (camInfos[currentCameraIndex].PreviousCamInfo != null)
        {
            camInfos[currentCameraIndex].ItemvirtualCamera.enabled = false;
            camInfos[currentCameraIndex].ItemCollider.enabled = true;


            camInfos[currentCameraIndex].PreviousCamInfo.ItemvirtualCamera.enabled = true;
            camInfos[currentCameraIndex].PreviousCamInfo.ItemCollider.enabled = false;


            currentCameraIndex = camInfos[currentCameraIndex].PreviousCamInfo.camIndex;
        }
    }
}
