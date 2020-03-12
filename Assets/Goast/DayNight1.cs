using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight1 : MonoBehaviour
{
   
    public GameObject sun;
    public GameObject picture;
    public GameObject pos;
    public GameObject camera;
    public float a = 0;

    void Start()
    {
        
    }

    void Update()
    {
        a = sun.transform.rotation.x;
        sun.transform.Rotate(Vector3.right * 5*Time.deltaTime );


        if (a >= 0.99f && a<=1)
        {
            Application.LoadLevel(1);
          


        }

    }
}
