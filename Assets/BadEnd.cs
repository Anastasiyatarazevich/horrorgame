using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadEnd : MonoBehaviour
{

    public GameObject picture;
    public GameObject graph;
    public GameObject camera;
    //  public GameObject ghost;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void end()
    {

        Application.LoadLevel(1);
    }
}
