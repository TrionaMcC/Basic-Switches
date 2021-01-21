using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulbController : MonoBehaviour
{
    public Animator bulbAnimator;
    public bool bulbOn = false;

    public void FlipBulb()
    {
        bulbAnimator.SetBool("BulbOn", bulbOn);
    }

    //testing github changes
}
