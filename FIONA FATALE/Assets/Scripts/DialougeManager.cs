using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialougeManager : MonoBehaviour
{
    public GameObject dialougueObject;
    public TextMeshProUGUI TextObject;

    private void Start()
    {
        dialougueObject.SetActive(false);
    }
    public void ShowDialouge(string data)
    {
        dialougueObject.SetActive(true);
        TextObject.text = data;
    }
    public void HideDialougue()
    {
        dialougueObject.SetActive(false);
    }
}
