using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger3 : MonoBehaviour
{
    public GameObject cube;
    public AudioClip toy;
    public GameObject camera;
    //AudioSource audio;
    AudioSource audio;
    void Start()
    {
      //  m_MyAudioSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }


void OnTriggerEnter(Collider other)
{
        camera.GetComponent<AudioSource>().enabled = false;
        cube.GetComponent<AudioSource>().enabled = true;
        //audio = GetComponent<AudioSource>();
       // audio.PlayOneShot(toy);
        //m_MyAudioSource.Pause();

    }
    void OnTriggerExit(Collider other)
    {
        camera.GetComponent<AudioSource>().enabled = true;
        cube.GetComponent<AudioSource>().enabled = false;
        //audio = GetComponent<AudioSource>();
        // audio.PlayOneShot(toy);
        //m_MyAudioSource.Pause();

    }
}
