using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    public TextMeshPro KeypadDisplay;
    public Animator doorAnimator;
    public GameObject EndTrigger;

    public void ShowData(int data)
    {
        if(KeypadDisplay.text.Length > 3)
        {
            KeypadDisplay.text = "----";
        }
        if(KeypadDisplay.text == "----")
        {
            KeypadDisplay.text = "";
        }

        KeypadDisplay.text += data.ToString();

        if (KeypadDisplay.text == "1989")
        {
            doorAnimator.Play("DoorOpen");
            EndTrigger.SetActive(true);
        } 
    }
}
