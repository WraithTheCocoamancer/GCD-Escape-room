using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarInteract : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject GemEye;
    private Animator anim;
    private GameObject Hinge;
    private GameObject Inv;
    private bool LockGone = false;
    public GameObject Key;
    void Start()
    {
        Hinge = GameObject.Find("Hinge");
        Inv = GameObject.Find("Inventory");
        anim = Hinge.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ReactToRaycast()
    {
        LockGone = Inv.GetComponent<Inventory>().LockGone;
        if (LockGone == true)
        { 
            anim.Play("PillarTurn");
            
        }

        else
        {
            Debug.Log("Hmnn something could go in here");
        }
    }
}
