using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OpeningLetter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Letter;
    public Button Button;
    public GameObject StartButton;
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
        Letter.SetActive(true);
        StartButton.SetActive(true);
    }
}
