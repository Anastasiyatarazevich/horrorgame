using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1.0f;
    Rigidbody rig;
    float hor;
    float ver;
    void Start()
    {
        rig = GetComponent <Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
    //     hor = Input.GetAxis("Horizontal");
    //    ver = Input.GetAxis("Vertical");
    //     rig.AddForce(((transform.right * hor) + (transform.forward * ver)) * speed / Time.deltaTime);

        if (Input.GetKey(KeyCode.W)) {
            rig.AddForce(new Vector3(0, 0, 1) * -speed);
        }
        if (Input.GetKey(KeyCode.A)) {
            rig.AddForce(new Vector3(1, 0, 0) * speed);
        }
        if (Input.GetKey(KeyCode.S)) {
            rig.AddForce(new Vector3(0, 0, 1) * speed);
        }
        if (Input.GetKey(KeyCode.D)) {
            rig.AddForce(new Vector3(1, 0, 0) * -speed);
        }

        if (OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad).y > 0.7f)
        {
            rig.AddForce(new Vector3(0, 0, 1) * -speed * OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad).y);
        }
        if (OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad).x > 0.7f)
        {
            rig.AddForce(new Vector3(1, 0, 0) * -speed * OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad).x);
        }

    }
}
