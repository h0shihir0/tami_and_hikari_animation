using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProducingHikariRandom : MonoBehaviour
{
    public GameObject hikari_obj;
    public GameObject mob_obj;
    GameObject mobbox;
   // public GameObject tami;
    GameObject hika_obj;
    public GameObject parent_plane;

    // Start is called before the first frame update
    void Start()
    {
        ProduceMob();
    }

    public void ProduceMob(){
        for (int r = 1; r <= 120; r++)
        {
            mobbox = Instantiate(mob_obj, new Vector3(0, 0, 0), Quaternion.identity);
            // mobbox.transform.localScale = new Vector3(0.075f, 0.075f, 0.075f);
           // mobbox.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            mobbox.transform.position = new Vector3(Random.Range(-20f, 20f), mob_obj.transform.position.y, Random.Range(-20f, 20f));
            mobbox.transform.rotation = Quaternion.Euler(0, Random.Range(0,360), 0);
            StartCoroutine(MobAnimon(mobbox));
        }
    }

    public IEnumerator MobAnimon(GameObject obj){
        yield return new WaitForSeconds(0.1f);
        obj.GetComponent<Animator>().enabled = true;
        print(mobbox.name);

    }

    public void ProduceHikari(){
        for (int r = 1; r <= 15; r++)
        {
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
