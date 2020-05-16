using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweetOperatingByTanaka : MonoBehaviour
{
    public Animator tweet_obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReTweetAnimationStart()
    {
        tweet_obj.enabled = true;
    }
}
