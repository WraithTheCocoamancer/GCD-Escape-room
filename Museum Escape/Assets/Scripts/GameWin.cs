using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider WinBox;
    public GameObject WinScreen;
    public GameObject Camera;
    public GameObject Player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Win()
    {

    }
    private void OnTriggerEnter(Collider WinBox)
    {
        Player.SetActive(false);
        WinScreen.SetActive(true);
    }
}
