using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransformations : MonoBehaviour
{
    private Vector3 scaleChangePos, scaleChangeNeg, startpos;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        startpos = rb.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        scaleChangeNeg = new Vector3(-0.01f, -0.01f, -0.01f);
        scaleChangePos = new Vector3(0.01f, 0.01f, 0.01f);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.localScale += scaleChangePos;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.localScale += scaleChangeNeg;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.up, -1);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up, 1);
        }
        if (Input.GetKey(KeyCode.R))
        {
            rb.transform.localPosition = startpos;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

    }
}
