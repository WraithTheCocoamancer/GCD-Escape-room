using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleDoorInteract : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Door;
    private GameObject Door2;
    private Animator anim;
    private Animator anim2;
    private GameObject Inv;
    void Start()
    {
        Inv = GameObject.Find("Inventory");
        Door = GameObject.Find("LargeDoorHinge");
        anim = Door.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ReactToRaycast()
    {
        if (Inv.GetComponent<Inventory>().DeedHave == true)
        {
            anim.Play("DoorOpen");

        }
        else
        {
            Debug.Log("Can't Leave yet.");
        }
    }
}
