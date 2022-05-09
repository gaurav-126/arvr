using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Vector3 startpos;
    Rigidbody rb;
    public bool isGrounded;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        isGrounded = false;
        startpos = rb.transform.localPosition;
    }

    
    void Update()
    {
        if (isGrounded == true && Input.GetMouseButtonUp(0))
        {
            rb.AddForce(new Vector3(0f, 500f, 0f));
            

        }
        if(isGrounded == true)
        {
            rb.GetComponent<Renderer>().material.color = Color.cyan;
        }
        if(isGrounded == false)
        {
            rb.GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (Input.GetKey(KeyCode.R))
        {
            rb.transform.localPosition = startpos;
        }

        }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Ground")
        {
            isGrounded=true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            isGrounded = false;
        }
    }
}
