using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamInfo : MonoBehaviour
{
    public int camIndex;
    public string camInfo, camInfoAfterRequesite;
    public CamInfo PreviousCamInfo;
    public bool isOn;
    public BoxCollider ItemCollider;
    public Animator animator;
    public PickableItem_.Items itemNeeded;

    public CinemachineVirtualCamera ItemvirtualCamera;
    public GameManager manager;

    private void Start()
    {
        manager = FindAnyObjectByType<GameManager>();
        ItemvirtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    private void Update()
    {
        if (isOn)
        {
            PlayInfo();
            isOn = false;
        }
    }
    void PlayInfo()
    {
            FindAnyObjectByType<DialougeManager>().ShowDialouge(camInfo);
    }
    
    public void PlayAction()
    {
                        animator.SetTrigger("Engage");
    }    
}
