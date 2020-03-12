using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speedMove;
    public float gravity;
    public Vector3 moveVector;

    private CharacterController ch;

    // Start is called before the first frame update
    void Start()
    {
        ch = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        CharacterMove();
        GameGravity();
    }

    private void CharacterMove()
    {
        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxis("Horizontal") * speedMove;
        moveVector.z = Input.GetAxis("Vertical") * speedMove;

        /*if(Vector3.Angle(Vector3.forward, moveVector)>1f || Vector3.Angle(Vector3.forward, moveVector) == 0)
        {
            Vector3 direct = Vector3.RotateTowards(transform.forward, moveVector, speedMove, 0.0f);
            transform.rotation = Quaternion.LookRotation(direct);
        }*/
        moveVector.y = gravity;
        ch.Move(moveVector * Time.deltaTime);

    }
    private void GameGravity()
    {
        if (!ch.isGrounded)
        {
            gravity -= 20f * Time.deltaTime;

        }
        else gravity = -1f;
    }
}
