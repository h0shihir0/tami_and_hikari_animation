using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProducingHikariRandom : MonoBehaviour
{
    public GameObject hikari_obj;

    // Start is called before the first frame update
    void Start()
    {
        for (int r = 1; r <= 15; r++){
       
            Instantiate(hikari_obj, new Vector3(Random.Range(25.0f, 44.0f), hikari_obj.transform.position.y, Random.Range(-10.0f, 13.0f)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
