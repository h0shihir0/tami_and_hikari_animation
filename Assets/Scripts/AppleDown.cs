using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleDown : MonoBehaviour
{
    public AudioClip audioClip1;
    public AudioSource audioSource;
    int k;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        if (k == 0)
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = audioClip1;
            audioSource.Play();
            k++;

            // Destroy(audioSource);
        }

    }

}

