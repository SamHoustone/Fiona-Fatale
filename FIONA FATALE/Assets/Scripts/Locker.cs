using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour
{
    Animator Animator;

    private void Start()
    {
        Animator = GetComponent<Animator>();

    }
    public void PlayOpen(string Animname)
    {
        Animator.Play(Animname);
    }
}
