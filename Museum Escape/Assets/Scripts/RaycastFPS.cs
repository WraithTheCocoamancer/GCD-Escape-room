using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//instructions for interaction from https://www.youtube.com/watch?v=WEFb84TQ-lc
public class RaycastFPS : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject raycastedObject;

    [SerializeField] private int rayLength = 10;
    [SerializeField] private LayerMask LayerMaskInteract; 
    [SerializeField] private Image uiCrosshair;

    private void Update()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward);

        if(Physics.Raycast(transform.position, forward, out hit, rayLength, LayerMaskInteract.value))
        {
            if (hit.collider.CompareTag("Object"))
            {
                raycastedObject = hit.collider.gameObject;
                CrosshairActive();
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("I have interacted with an object");
                    hit.transform.gameObject.SendMessage("ReactToRaycast");

                }
            }
        }
        else
        {
            CrosshairNormal();
        }
    }
    void CrosshairActive()
    {
        uiCrosshair.color = Color.red;
    } 
    void CrosshairNormal()
    {
        uiCrosshair.color = Color.black;
    }
}
