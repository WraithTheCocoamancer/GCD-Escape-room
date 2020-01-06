using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1Interact : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject ButtTrack;
    private bool Button1 = false;
    private bool Button2 = false;
    private bool Button3 = false;
    private bool Button4 = false;
    private bool Button5 = false;
    private bool Button6 = false;
    private GameObject FirstButton;
    void Start()
    {
        ButtTrack = GameObject.Find("Buttons");
        FirstButton = GameObject.Find("Button1");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ReactToRaycast()
    {
    Button1 = ButtTrack.GetComponent<ButtonTracking>().
    Button2 =
    Button3 = 
    Button4 = 
    button5 = 
    Button6 = 
}
}
