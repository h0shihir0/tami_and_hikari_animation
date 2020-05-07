using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChangeDynamic : MonoBehaviour
{

    public Animator anim_obj;
   // public GameObject[] hika_objs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimChangeWithTime(AnimationEvent ev){
        //anim_obj.layer[layer_num].
        anim_obj.SetLayerWeight(ev.intParameter, ev.floatParameter);

    }

    //public void TamiDestroyHika(){
    //    HikariWalkingAround hika_obj = new HikariWalkingAround();
    //    hika_obj.HikariDestroy();

    //}



}
