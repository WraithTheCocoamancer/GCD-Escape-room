using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockInteract : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Inv;
    private bool HaveKey = false;
    private GameObject Key;
    private GameObject Lock;
    void Start()
    {
        Key = GameObject.Find("Key");
        Inv = GameObject.Find("Inventory");
        Lock = GameObject.Find("lock");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ReactToRaycast()
    {
        HaveKey = Inv.GetComponent<Inventory>().KeyGot;
        if (HaveKey == true)
        {
            Lock.SetActive(false);
            Inv.GetComponent<Inventory>().LockGone = true;
        }

        else
        {
            Debug.Log("Every lock needs a key...unless it's combination but this one definately needs a key..orrrr lockpicks..nah key.");
        }
    }
}
