using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hikarimoving : MonoBehaviour
{
    // Start is called before the first frame update
public Animator anim;

    void Start()
    {
      anim.speed = 0.125f;
      print("tenii");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
