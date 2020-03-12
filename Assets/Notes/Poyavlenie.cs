using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poyavlenie : MonoBehaviour
{
    public GameObject note1;

    public float timer=0;

    
    void Update()
    {
        timer += Time.deltaTime;
if (timer>=15)
        {
            note1.SetActive(false);
            timer = 0;
        }
    }

    public void Note1Play()
    {
        note1.SetActive(true);

        
    }
}
