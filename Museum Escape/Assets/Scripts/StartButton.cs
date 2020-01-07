using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Crosshair;
    public Button Button;
    public GameObject MenuCamera;
    public GameObject Player;
    void Start()
    {
        Button btn = Button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }




    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        Crosshair.SetActive(true);
        MenuCamera.SetActive(false);
        Player.SetActive(true);
    }

    }