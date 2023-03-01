using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    // For task (g), toggle's the sun's light intensity
    Light sun;

    public void ToggleSun()
    {
        sun = GameObject.Find("Directional Light").GetComponent<Light>();
        if (sun.intensity == 1)
        {
            sun.intensity = 0;
            Debug.Log("Changed the sun intensity to 0!");
        }
        else
        {
            sun.intensity = 1;
            Debug.Log("Changed the sun intensity to 1!");
        }
    }

    // For task (f), to make the model jump
    Animator animator;

    public void Jump()
    {
        animator = GameObject.Find("Banana Man").GetComponent<Animator>();
        animator.SetBool("isJumping", true);
    }
}
