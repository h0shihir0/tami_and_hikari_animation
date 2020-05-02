using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tsukkomi_walking_stop : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
        //if(){

      //  }


    }

    public void StopWalking()
    {
        this.GetComponent<Animator>().enabled = false;
    }



}
