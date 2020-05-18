using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobMovingAround : MonoBehaviour
{ // Start is called before the first frame update
    public float speed = 1f;
    public float rotationspeed = 1f;
    public float posrange = 10f;
    private Vector3 targetpos;
    private float changetarget = 0.5f;
    public float targetdistance;
    public Text name_txt;
    public Text username;
    public Text f_number;
    public Text ex_name_txt;
    public Text ex_username;
    public Text ex_f_number;
    public GameObject mob_obj;
    public GameObject flame;
    public GameObject bird_obj_1;
    public GameObject bird_obj_2;
    public GameObject bird_obj_3;
    public Material red_mt;

    // public GameObject particleObject;
    //  private static Random random;

    public Vector3 GetRandomPosition()
    {
        //return new Vector3(x_pos, transform.position.y, z_pos);
        // return new Vector3(Random.Range(-20f,20f), transform.position.y, Random.Range(-20f,20f));
        return new Vector3(-1.02f, transform.position.y, -3.51f);

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
        string name = System.Guid.NewGuid().ToString("N").Substring(0, 5).ToUpper().ToString();
        string uname = System.Guid.NewGuid().ToString("N").Substring(0, 7);
        string fnum = Random.Range(0, 500).ToString();
        ex_name_txt.text = name;
        ex_username.text = uname;
        ex_f_number.text = fnum;
        name_txt.text = name;
        username.text = uname;
        f_number.text = fnum;
        this.GetComponent<Animator>().enabled = false;
        StartCoroutine("AnimBegin");

    }

    IEnumerator AnimBegin(){
        yield return new WaitForSeconds(12.5f);
        this.GetComponent<Animator>().enabled = true;
        //yield return new WaitForSeconds(3.5f);
    }

    void Update()
    {
        //print("testdes");
        targetdistance = Vector3.SqrMagnitude(transform.position - targetpos);//二乗を返している
      //  this.transform.name = targetpos.ToString();
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

    public void StopMobWalking(){
        mob_obj.GetComponent<Animator>().enabled = false;

    }

    public void ReStartMobWalking(){
        mob_obj.GetComponent<Animator>().enabled = true;
    }

    public void FlameOn(){
        flame.SetActive(true);
    }

    public void RedChangeBird(){
        bird_obj_1.GetComponent<MeshRenderer>().material = red_mt;
        bird_obj_2.GetComponent<MeshRenderer>().material = red_mt;
        bird_obj_3.GetComponent<MeshRenderer>().material = red_mt;
        print("KYKOKOKKKOKO");

    }
}
