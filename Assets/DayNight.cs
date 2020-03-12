using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{


    public GameObject sun;
    

public GameObject camera;

    public float a = 0;

    void Start()
    {

    }

    void Update()
    {
        a = sun.transform.rotation.x;
        sun.transform.Rotate(Vector3.right *   Time.deltaTime/20);

        
    }
}
