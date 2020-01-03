using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headinteract : MonoBehaviour
{
    public GameObject GemEye;
    private Animator anim;
    private GameObject Gem;
    private GameObject Inv;
    private bool HaveGem = false;
    public GameObject Key;
    // Start is called before the first frame update
    void Start()
    {
        Gem = GameObject.Find("GemEye");
        Inv = GameObject.Find("Inventory");
        anim = GemEye.GetComponent<Animator>();
        


    }

    // Update is called once per frame
    void Update()
    {

    }
    void ReactToRaycast()
    {
        HaveGem = Inv.GetComponent<Inventory>().GemGot;
        if (HaveGem == true)
        {
            GemEye.SetActive(true);
            anim.Play("GemInsert");
            Key.SetActive(true);
        }

        else
        {
            Debug.Log("Hmnn something could go in here");
        }
    }
}
