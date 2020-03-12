using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timerr : MonoBehaviour
{
    public float timer;
    public GameObject ghostbeside;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>=3)
             ghostbeside.SetActive(false);
}

}
