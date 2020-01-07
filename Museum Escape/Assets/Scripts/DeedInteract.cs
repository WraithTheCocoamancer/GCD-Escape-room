using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeedInteract : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Inv;
    private GameObject Deed;

    void Start()
    {
        Inv = GameObject.Find("Inventory");
        Deed = GameObject.Find("MuseumDeed");
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void ReactToRaycast()
    {
        Deed.SetActive(false);
        Inv.GetComponent<Inventory>().DeedHave = true;
        Debug.Log("Got it! Time to get out of here!");
    }
}
