using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitSeconds : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject new_chara;
    public GameObject tsukkomi;
    public GameObject openning;
    public GameObject op_txt;

    void Start()
    {
        StartCoroutine("Wait");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait(){
        yield return new WaitForSeconds(2);
        new_chara.SetActive(true);
        tsukkomi.SetActive(true);
        openning.SetActive(true);
        op_txt.SetActive(true);
        GetComponent<AudioSource>().enabled = true;


    }

}
