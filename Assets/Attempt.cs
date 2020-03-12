using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attempt : MonoBehaviour
{
    public GameObject ghostbeside;
    public GameObject player;
    public GameObject cube;
    public GameObject tr;
    public float timer;
   // public int a = 0;
    public float x;
    public float y;
    public float z;
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

       // x = camera.position.x;
        //y = camera.position.x;
        //z = camera.position.x;

        ghostbeside.transform.position = player.transform.position - Vector3.forward ;
        ghostbeside.transform.position = new Vector3(ghostbeside.transform.position.x, 12.09f, ghostbeside.transform.position.z);
        ghostbeside.SetActive(true);
        cube.GetComponent<Timerr>().enabled = true;
        tr.SetActive(false);
        //camera.GetComponent<AudioSource>().enabled = false;
        // cube.GetComponent<AudioSource>().enabled = true;
        //audio = GetComponent<AudioSource>();
        // audio.PlayOneShot(toy);
        //m_MyAudioSource.Pause();

    }
    void OnTriggerExit(Collider other)
    {
       /* camera.GetComponent<AudioSource>().enabled = true;
        cube.GetComponent<AudioSource>().enabled = false;
        //audio = GetComponent<AudioSource>();
        // audio.PlayOneShot(toy);
        //m_MyAudioSource.Pause();*/

    }
}
