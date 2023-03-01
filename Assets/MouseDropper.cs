using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using UnityEngine;

public class MouseDropper : MonoBehaviour
{
    private Camera cam;
    private GameObject copy;
    public LayerMask mask;

    void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
            Ray ray = cam.ScreenPointToRay(point);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                copy = hit.collider.gameObject;
                Debug.Log($"Copied {copy}");
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (copy == null)
            {
                Debug.Log("You have nothing copied in your clipboard!");
                return;
            }

            // Paste object 
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
            Ray ray = cam.ScreenPointToRay(point);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject paste = GameObject.Instantiate(copy);
                paste.transform.position = hit.point;
                Debug.Log("Pasted object!");
            }
            
        }
    }

}
