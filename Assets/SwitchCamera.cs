using UnityEngine;
using System.Collections;
using UnityEngine.UIElements;


public class SwitchCamera : MonoBehaviour {
    public Camera thirdPersonCamera;
    public Camera firstPersonCamera;
    public Camera TopDownPOV;

    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void ShowOverheadView() {
        firstPersonCamera.enabled = false;
        thirdPersonCamera.enabled = false;
        TopDownPOV.enabled = true;
    }
    
    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowFirstPersonView() {
        firstPersonCamera.enabled = true;
        thirdPersonCamera.enabled = false;
        TopDownPOV.enabled = false;
    }
    
    // Call this function to enable 3rd person camera,
    // and disable overhead/FP camera.
    public void ShowThirdPersonView() {
        firstPersonCamera.enabled = false;
        thirdPersonCamera.enabled = true;
        TopDownPOV.enabled = false;
    }
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            ShowThirdPersonView();
        }
        if (Input.GetKeyDown("q"))
        {
            ShowOverheadView();
        }
        if (Input.GetKeyDown("r"))
        {
            ShowFirstPersonView();
        }
    }
}