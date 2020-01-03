using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemInteract : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Gem;
    private GameObject Inventory;
    void Start()
    {
        Gem = GameObject.Find("GemEye");
        Inventory = GameObject.Find("Inventory");

    }

    // Update is called once per frame
    void Update()
    {

    }

    void ReactToRaycast()
    {
        Debug.Log("Raycast Has interacted with gem");
        Gem.SetActive(false);
        Inventory.SendMessage("GemPickup");
    }
}
