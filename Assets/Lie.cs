using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lie : MonoBehaviour
{
    public GameObject ghost;
    public GameObject cube;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        ghost.SetActive(true);
       
    }
    void OnTriggerExit(Collider other)
    {

        ghost.SetActive(false);
        cube.SetActive(false);
    }
}
