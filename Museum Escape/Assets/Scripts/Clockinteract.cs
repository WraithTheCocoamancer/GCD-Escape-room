using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clockinteract : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Inv;
    private bool HaveKey = false;
    private GameObject Door;
    private Animator anim;
    void Start()
    {
        Inv = GameObject.Find("Inventory");
        Door = GameObject.Find("ClockHinge");
        anim = Door.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ReactToRaycast()
    {
        if (Inv.GetComponent<Inventory>().ButtonsPressed == true)
        {
            anim.Play("ClockDoorTurn");
        }
        else
        {
            Debug.Log("Locked..and no keyhole?");
        }
    }
}
