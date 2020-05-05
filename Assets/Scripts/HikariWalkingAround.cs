using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HikariWalkingAround : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;
    public float rotationspeed = 1f;
    public float posrange = 10f;
    private Vector3 targetpos;
    private float changetarget = 0.05f;
    public float targetdistance;
  //  private static Random random;

     public  Vector3 GetRandomPosition()
    {
        //random = new Random();
        float x_pos = Random.Range(20f, 50f);
        float z_tst = Mathf.Sqrt(175 - Mathf.Pow((x_pos - 35), 2));
        float z_pos = Random.Range(-z_tst+2f, z_tst+2f);
        string x_z_name = "Xは" + x_pos + "Zは" + z_pos;
        print("Xは" + x_pos + "Zは" + z_pos);
        this.gameObject.name = "Xは" + x_pos + "Zは" + z_pos;
        string z_str = z_pos.ToString();
        if(z_str == "NaN")
        {
            print("z_strは" + z_str + "だよ");
            z_pos = Random.Range(-7f, 11f);
            //z_tst = Mathf.Sqrt(175 - Mathf.Pow((x_pos - 35), 2));
            //z_pos = Random.Range(-z_tst + 2f, z_tst + 2f);

        }
        //int x_pos = Random.Range(20, 50);
        //int z_tst = (int)Mathf.Sqrt(175 - Mathf.Pow((x_pos - 35), 2));
        //int z_pos = Random.Range(-z_tst + 2, z_tst + 2);
        //print("Xは" + x_pos + "Zは" + z_pos);
        //string z_str = z_pos.ToString();
        //if (z_str == "NaN")
        //{
        //    print("z_strは" + z_str + "だよ");
        //    z_pos = Random.Range(-7, 11);
        //    //z_tst = Mathf.Sqrt(175 - Mathf.Pow((x_pos - 35), 2));
        //    //z_pos = Random.Range(-z_tst + 2f, z_tst + 2f);

        //}
        
        return new Vector3(x_pos, transform.position.y, z_pos);
        // return new Vector3(Random.Range(-posrange + currentpos.x, posrange + currentpos.x), 0, Random.Range(-posrange + currentpos.z, posrange + currentpos.z));

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
        }else{
            Quaternion targetRotation = Quaternion.LookRotation(targetpos - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationspeed);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

    }
    void Start()
    {
        targetpos = GetRandomPosition();

    }
    void Update()
    {
        targetdistance = Vector3.SqrMagnitude(transform.position - targetpos);//二乗を返している
        haikai();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hikari"){
            print("ヒカリ徘徊");
            haikai();
        }

        //Debug.Log("Hit");
        print(other.gameObject.tag);// ログを表示する
    }
}
