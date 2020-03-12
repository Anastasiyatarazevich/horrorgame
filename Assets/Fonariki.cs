using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonariki : MonoBehaviour
{
    public GameObject fonariki1;
    public GameObject fonariki2;
    public GameObject fonariki3;
    public GameObject fonariki4;
    public GameObject fonariki5;
    public GameObject fonariki6;
    public GameObject fonariki7;
    public GameObject fonariki8;

    public GameObject light;

    public GameObject f1;
    public GameObject f2;
    public GameObject f3;
    public GameObject f4;
    public GameObject f5;
    public GameObject f6;
    public GameObject f7;
    public GameObject f8;
    public int a = 0;
    public int b = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision collision)
    {
        if (collision.collider.tag == "fonarik1")
        {
            a++;

         fonariki1.SetActive(false);
        }
        if (collision.collider.tag == "fonarik2")
        {
            a++;

            fonariki2.SetActive(false);
        }
        if (collision.collider.tag == "fonarik3")
        {
            a++;

            fonariki3.SetActive(false);
        }
        if (collision.collider.tag == "fonarik4")
        {
            a++;

            fonariki4.SetActive(false);
        }
        if (collision.collider.tag == "fonarik5")
        {
            a++;

            fonariki5.SetActive(false);
        }
        if (collision.collider.tag == "fonarik6")
        {
            a++;

            fonariki6.SetActive(false);
        }
        if (collision.collider.tag == "fonarik7")
        {
            a++;

            fonariki7.SetActive(false);
        }
        if (collision.collider.tag == "fonarik8")
        {
            a++;

            fonariki8.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "lasttrigger" && a>=1) {
  f1.SetActive(true);
            b++;
            a--;
        }

        if (other.gameObject.tag == "f1" && b==1 && a>=1)
        {
            f2.SetActive(true);
            a--;
        }
        if (other.gameObject.tag == "f2" && b == 1 && a >= 1)
        {
            f3.SetActive(true);
            a--;
        }
        if (other.gameObject.tag == "f3" && b == 1 && a >= 1)
        {
            f4.SetActive(true);
            a--;
        }
        if (other.gameObject.tag == "f4" && b == 1 && a >= 1)
        {
            f5.SetActive(true);
            a--;
        }
        if (other.gameObject.tag == "f5" && b == 1 && a >= 1)
        {
            f6.SetActive(true);
            a--;
        }
        if (other.gameObject.tag == "f6" && b == 1 && a >= 0)
        {
            f7.SetActive(true);
            a--;
        }
        if (other.gameObject.tag == "f7" && b == 1 && a >= 0)
        {
            f8.SetActive(true);
            a--;
            light.SetActive(true);
        }

    }

}
