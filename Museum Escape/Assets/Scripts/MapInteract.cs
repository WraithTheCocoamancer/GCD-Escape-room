using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapInteract : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Map;
    private GameObject Inventory;
    
    void Start()
    {
        Map = GameObject.Find("Map");
        Inventory = GameObject.Find("Inventory");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ReactToRaycast()
    {
        Debug.Log("Raycast Has interacted with Key");
        Map.SetActive(false);
        Inventory.SendMessage("MapPickup");
    }
}
