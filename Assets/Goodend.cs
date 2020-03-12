using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goodend : MonoBehaviour
{
    public GameObject ghost;
    public GameObject canvas;
    public GameObject wall;
    public GameObject camera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void end()
    {
        wall.SetActive(false);
        ghost.SetActive(false);
        canvas.SetActive(false);
        camera.GetComponent<AudioSource>().enabled = false;


    }
}
