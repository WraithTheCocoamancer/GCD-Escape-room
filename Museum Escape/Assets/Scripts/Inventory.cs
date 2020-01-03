using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update
    public bool GemGot = false;
    public bool KeyGot = false;
    public bool LockGone = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GemPickup()
    {
        GemGot = true;
    }
    void KeyPickup()
    {
        KeyGot = true;
    }
}
