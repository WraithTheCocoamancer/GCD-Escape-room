using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Torch;
    void Start()
    {
        Torch = GameObject.Find("Torch");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && Torch.active == true)
        {
            Torch.SetActive(false);
        }
        else if(Input.GetKeyDown(KeyCode.F) && Torch.active == false)
        {
            Torch.SetActive(true);
        }
    }
}
