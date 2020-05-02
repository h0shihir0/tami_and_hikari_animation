using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tsukkomi_walking : MonoBehaviour
{
  public Vector3 position;
  public Vector3 destination;
  public bool move_jud;

    // Start is called before the first frame update
    void Start()
    {
      move_jud = true;

    }

    // Update is called once per frame
    void Update()
    {
      if(move_jud){
        move_jud = false;
        StartCoroutine("Moving");
      }

    }

    IEnumerator Moving (){
      this.gameObject.transform.Translate(Random.Range(-10.0f, 10.0f),0,Random.Range(-10.0f, 10.0f));
      move_jud = true;
      yield return new WaitForSeconds(0.5f);
    }


    // public void MoveToRandomPosition(){
    //   var randDestination = Random.insideUnitCircle * 8;
    //   destination = new Vector3(randDestination.x, 0, randDestination.y);
    //   transform.position = Vector3.Lerp(position, destination, 10.0f);
    // }
}
