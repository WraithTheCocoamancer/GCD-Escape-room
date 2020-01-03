using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInteract : MonoBehaviour
{
    private GameObject Key;
    private GameObject Inventory;
    // Start is called before the first frame update
    void Start()
    {
        Key = GameObject.Find("Key");
        Inventory = GameObject.Find("Inventory");

    }

    // Update is called once per frame
    void Update()
    {

    }
    void ReactToRaycast()
    {
        Debug.Log("Raycast Has interacted with Key");
        Key.SetActive(false);
        Inventory.SendMessage("KeyPickup");
    }
}
