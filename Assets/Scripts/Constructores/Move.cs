using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = 5;
    float eje_X;
    private Rigidbody mover;
    private bool canJump;

    void Start()
    {
        mover = GetComponent<Rigidbody>();
    
    }

    private void FixedUpdate()
    {
        if(canJump)
        {
            canJump = false;
            mover.AddForce(0, 5, 0, ForceMode.Impulse);

        }
           
    }

    void Update()
    {
        eje_X += Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, eje_X, 0);

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
           canJump=true;
        }
    }
}
