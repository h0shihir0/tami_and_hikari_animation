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
    private float changetarget = 50f;
    public float targetdistance;
    Vector3 GetRandomPosition(Vector3 currentpos)
    {
        return new Vector3(Random.Range(-posrange + currentpos.x, posrange + currentpos.x), transform.position.y, Random.Range(-posrange + currentpos.z, posrange + currentpos.z));
    }
    void haikai()
    {
        if (targetdistance < changetarget) targetpos = GetRandomPosition(transform.position);
        Quaternion targetRotation = Quaternion.LookRotation(targetpos - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationspeed);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Debug.Log("haikai");
    }
    void Start()
    {
        targetpos = GetRandomPosition(transform.position);
    }
    void Update()
    {
        targetdistance = Vector3.SqrMagnitude(transform.position - targetpos);
        haikai();
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Hit");
        print(other.gameObject.tag);// ログを表示する
    }
}
