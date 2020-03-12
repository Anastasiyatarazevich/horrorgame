using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostsSounds : MonoBehaviour
{
    public AudioClip cometome;
    AudioSource audio;
    public int n = 0;

    public float timer;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.PlayOneShot(cometome);
    }

    
    void Update()
    {

       
        
         
    }

}
