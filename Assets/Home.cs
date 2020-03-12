using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    public GameObject won;
    public GameObject graph;
    public float durationInSeconds = 3.0f;
    public GameObject camera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
       
      //  yield return new WaitForSeconds(durationInSeconds);
        won.SetActive(false);
        graph.SetActive(true);
        
    }
}
