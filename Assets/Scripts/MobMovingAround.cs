using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMovingAround : MonoBehaviour
{ // Start is called before the first frame update
    public float speed = 1f;
    public float rotationspeed = 1f;
    public float posrange = 10f;
    private Vector3 targetpos;
    private float changetarget = 0.5f;
    public float targetdistance;
    // public GameObject particleObject;
    //  private static Random random;

    public Vector3 GetRandomPosition()
    {
        //return new Vector3(x_pos, transform.position.y, z_pos);
        return new Vector3(Random.Range(-20f,20f), transform.position.y, Random.Range(-20f,20f));

    }
    void haikai()
    {
        if (targetdistance < changetarget)
        {
            targetpos = GetRandomPosition();
            Quaternion targetRotation = Quaternion.LookRotation(targetpos - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationspeed);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Debug.Log("haikai");
        }
        else
        {
            Quaternion targetRotation = Quaternion.LookRotation(targetpos - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationspeed);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            //print("haikai_else");
        }

    }
    void Start()
    {
        targetpos = GetRandomPosition();

    }
    void Update()
    {
        //print("testdes");
        targetdistance = Vector3.SqrMagnitude(transform.position - targetpos);//二乗を返している
        this.transform.name = targetpos.ToString();
        haikai();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hikari")
        {
            print("ヒカリ徘徊");
            haikai();
        }

        //Debug.Log("Hit");
        print(other.gameObject.tag);// ログを表示する
    }

    public void HikariDestroy()
    {
        int k = int.Parse(this.gameObject.name);
        if (0 < k)
        {
            Invoke("Hika_des", 3f);

        }
    }
    void Hika_des()
    {
        Destroy(this.gameObject);
    }

    public void HikariSetPosition()
    {
        this.gameObject.transform.position = new Vector3(21.53f, -31.3f, 2.38f);
        this.gameObject.transform.rotation = Quaternion.Euler(0f, 271.575f, 0f);
        this.gameObject.GetComponent<HikariWalkingAround>().enabled = false;
    }

    public void ProduceParticle(GameObject particleObject)
    {
        Instantiate(particleObject, this.transform.position, Quaternion.identity);
    }
}
