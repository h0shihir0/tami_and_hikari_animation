using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayAll : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip[] sounds;
    public AudioClip sound01;
    public AudioClip sound02;
    public AudioClip sound03;
    public AudioClip sound04;
    public AudioClip sound05;
    public AudioClip sound06;
    public AudioClip sound07;
    public AudioClip sound08;
    public AudioSource main_cam;
    //public Animation animo;
    //public AnimationClip[] anims;
    //public AnimationClip anim01;
    //public AnimationClip anim02;
    //public AnimationClip anim03;
    //public AnimationClip anim04;
    //public AnimationClip anim05;
    //public AnimationClip anim06;
    //public AnimationClip anim07;
    //public AnimationClip anim08;
    //public Animation new_chara;
    //public Animation tsukkomi;
    private List<AnimationClip> animations;
    // Start is called before the first frame update
    void Start()
    {
        //animations = new List<AnimationClip>();
        // Start is called before the first frame update
        sounds = new AudioClip[] { sound01, sound02, sound03, sound04, sound05, sound06, sound07, sound08 };
        //anims = new AnimationClip[] { anim01, anim02, anim03, anim04, anim05, anim06, anim07, anim08 };
        StartCoroutine("Wait");
        //foreach (AnimationState anim in tsukkomi.GetComponent<Animation>())
        //{ 
        //    this.animations.Add(anim.clip);
        //    print(anim.clip + "FAFA!");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //IEnumerator Wait()
    //{
    //    yield return new WaitForSeconds(4);
    //    AnimeAoudioPlay(0);
    //    print("jiji");
    //}

    public void AnimeAoudioPlay(int anim_num){
        audio.PlayOneShot(sounds[anim_num]);
        print(sounds[anim_num]);
        //int k_num = anim_num + 1;
        //print(animations[anim_num].name);
        //print(tsukkomi.GetComponent<Animation>().Play(animations[anim_num].name));
        //tsukkomi.GetComponent<Animation>().Play(animations[anim_num].name);
        //animo.clip = anims[anim_num];
        //animo.Play("anim0" + anim_num + 1);
    }

    public void StopMainMusic(){
        print("STOP!!!!");
        main_cam.enabled = false;

    }


}
