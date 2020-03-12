using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nothelped : MonoBehaviour
{
    public GameObject ghost;
    public float timer;
   // public float a = 0;
    public GameObject sun;
   // public ParticleSystem myParticleSystem;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
            if (timer >= 10)
        {

            ghost.SetActive(false);
           sun.GetComponent<DayNight1>().enabled = true;
            sun.GetComponent<DayNight>().enabled = false;
            //  a = sun.transform.rotation.x;
            //  sun.transform.Rotate(Vector3.right *2* Time.deltaTime );
        } 
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            ghost.SetActive(false);
            //myParticleSystem.enableEmission = true;

            timer = -100000000;
        }
    }
}
