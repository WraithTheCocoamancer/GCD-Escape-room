using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarAnimation : MonoBehaviour
{

    Animator animator;
    public float InputX;
    public float InputY;
    // Start is called before the first frame update
    void Start()
    {
        //Get the animator
        animator = this.gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
