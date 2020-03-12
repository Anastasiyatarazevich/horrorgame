using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


 void OnTriggerEnter(Collider other)
    {

        Application.LoadLevel(1);


    }


}
