using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex2 : MonoBehaviour
{
    public float speed = 2.0f;
    private bool dirRight;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        dirRight = true;
        rb.isKinematic = true;
    }

    private void FixedUpdate()
    {
        // vector1 = vector1.normalized * speed * Time.deltaTime;
        //vector2 = vector2.normalized * speed * Time.deltaTime;
        if (dirRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector3.right * speed * Time.deltaTime);
        }

        if (transform.position.x > 10)
        {
            dirRight = false;
        }

        if (transform.position.x < 0)
        {
            dirRight = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
    }
}
