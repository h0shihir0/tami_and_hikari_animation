using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProducingHikariRandom : MonoBehaviour
{
    public GameObject hikari_obj;
   // public GameObject tami;
    GameObject hika_obj;
    Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        for (int r = 1; r <= 15; r++){
            //parent = this.transform;
            //  hika_obj = Instantiate(hikari_obj, new Vector3(Random.Range(25.0f, 44.0f), hikari_obj.transform.position.y, Random.Range(-10.0f, 13.0f)), Quaternion.identity, parent);
            hika_obj = Instantiate(hikari_obj, new Vector3(Random.Range(25.0f, 44.0f), hikari_obj.transform.position.y, Random.Range(-10.0f, 13.0f)), Quaternion.identity);
            hika_obj.name = r.ToString();
            //hika_obj.GetComponent<Animator>().SetLayerWeight(3, 0f);
            //Hika_Restart();
            // tami.Getcomponent<
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void Hika_Restart(){
    //    System.Threading.Thread.Sleep(3000);
    //    hika_obj.GetComponent<Animator>().SetLayerWeight(3, 1f);
    //}
}
