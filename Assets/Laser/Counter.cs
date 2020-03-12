using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Counter : MonoBehaviour
{
    public GameObject corToy;
    public GameObject incorToy;
    public GameObject hammer;
    public GameObject axe;
    public GameObject sword;

    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (axe.activeSelf == false)
            btn1.interactable = true;

        if (sword.activeSelf == false)
            btn2.interactable = true;

        if (hammer.activeSelf == false)
            btn3.interactable = true;

        if (corToy.activeSelf == false)
            btn4.interactable = true;

        if (incorToy.activeSelf == false)
            btn5.interactable = true;



    }
}
//yield return new WaitForSeconds(durationInSeconds);