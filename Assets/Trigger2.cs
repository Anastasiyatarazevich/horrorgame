using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public GameObject ghostbeside;
    public GameObject ghost;
    public GameObject cube;
    public float timer;
    public int a = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ghostbeside.activeInHierarchy )
        {
            a++;
            timer += Time.deltaTime;
            
            if (timer>=1)
            {
             ghostbeside.SetActive(false);
               }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        ghost.SetActive(false);
        ghostbeside.SetActive(true);
        cube.SetActive(false);

    }
}
