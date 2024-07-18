using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    public Keypad keypad;
    public int index;
    public void SendData()
    {
        keypad.ShowData(index);
    }
}
