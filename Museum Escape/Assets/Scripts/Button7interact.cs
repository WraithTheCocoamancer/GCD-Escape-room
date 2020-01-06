using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button7interact : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject ButtTrack;
    private bool Button1 = false;
    private bool Button2 = false;
    private bool Button3 = false;
    private bool Button4 = false;
    private bool Button5 = false;
    private bool Button6 = false;
    private bool Button7 = false;
    private GameObject Inv;
    private GameObject FirstButton;
    void Start()
    {
        ButtTrack = GameObject.Find("Buttons");
        FirstButton = GameObject.Find("Button1");
        Inv = GameObject.Find("Inventory");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ReactToRaycast()
    {
        Button1 = ButtTrack.GetComponent<ButtonTracking>().Button1;
        Button2 = ButtTrack.GetComponent<ButtonTracking>().Button2;
        Button3 = ButtTrack.GetComponent<ButtonTracking>().Button3;
        Button4 = ButtTrack.GetComponent<ButtonTracking>().Button4;
        Button5 = ButtTrack.GetComponent<ButtonTracking>().Button5;
        Button6 = ButtTrack.GetComponent<ButtonTracking>().Button6;
        Button7 = ButtTrack.GetComponent<ButtonTracking>().Button7;
        if (Button1 == true && Button2 == true && Button3 == true && Button4 == true && Button5 == true && Button6 == true && Button7 == false)
        {
            ButtTrack.GetComponent<ButtonTracking>().Button7 = true;
            Inv.GetComponent<Inventory>().ButtonsPressed = true;
        }
        else
        {
            ButtTrack.GetComponent<ButtonTracking>().Button1 = false;
            ButtTrack.GetComponent<ButtonTracking>().Button2 = false;
            ButtTrack.GetComponent<ButtonTracking>().Button3 = false;
            ButtTrack.GetComponent<ButtonTracking>().Button4 = false;
            ButtTrack.GetComponent<ButtonTracking>().Button5 = false;
            ButtTrack.GetComponent<ButtonTracking>().Button6 = false;
            ButtTrack.GetComponent<ButtonTracking>().Button7 = false;
        }
    }
}
