using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeTrigger : MonoBehaviour
{
    public float timer;
    public GameObject camera;
    public GameObject won;
    void Start()
    {
        won.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.deltaTime;
        if(timer>=5)
            camera.transform.position = new Vector3(641.3f, 193.4f, 652.9f);
    }
}
