using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTransformation : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10;
    Vector3 startpos;
    private float xInput, yInput;


    // Start is called before the first frame update  
    void Start()
    {
        startpos = rb.transform.localPosition;
    }
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.R))
        {
            rb.transform.localPosition = startpos;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(xInput, 0f, yInput) * speed);
    }
}

        
   