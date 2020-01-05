using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Inventory;
    private bool HaveMap = false;
    private bool MapOpen = false;
    public GameObject MapImage;
    void Start()
    {
        Inventory = GameObject.Find("Inventory");
    }

    // Update is called once per frame
    void Update()
    {
        HaveMap = Inventory.GetComponent<Inventory>().MapHave;
        if (Input.GetKeyDown(KeyCode.M) && HaveMap == true && MapOpen == false)
        {
            MapImage.SetActive(true);
            MapOpen = true;
        }
        else if(Input.GetKeyDown(KeyCode.M) && HaveMap == true && MapOpen == true)
        {
            MapImage.SetActive(false);
            MapOpen = false;
        }
    }
}
