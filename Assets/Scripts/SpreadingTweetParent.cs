using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreadingTweetParent : MonoBehaviour
{

    public GameObject bird_prefab;
    // Start is called before the first frame update
    void Start()
    {
      //  bird_prefab.SetActive(true);
      //  bird_prefab.GetComponent<Animator>().enabled = true;
        // for (int i = 0; i < 15; i++)
        //  {
        print("JIJIJI");
            StartCoroutine("ProduceTweet");
       // }
    }


    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ProduceTweet(){
        for (int i = 0; i < 100; i++)
        {
            print("JIJIJI");
            yield return new WaitForSeconds(0.03f);
            Instantiate(bird_prefab, new Vector3(-2f + Random.Range(-20, 20), 18.2f + Random.Range(-5, 10), -6.1f), Quaternion.identity);
         //   obj.GetComponent<Animator>().enabled = true;

        }

    }
}
