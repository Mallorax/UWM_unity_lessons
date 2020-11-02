using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ex2 : MonoBehaviour
{
    public float speed = 5.0f;
    private Quaternion targetRotation;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    private void FixedUpdate()
    {
        // vector1 = vector1.normalized * speed * Time.deltaTime;
        //vector2 = vector2.normalized * speed * Time.deltaTime;
        if(transform.position.x <= 10 && transform.position.z <= 0)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
            if(transform.position.x > 8)
            {
                targetRotation = transform.rotation * Quaternion.AngleAxis(-90, transform.up);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
            }
        }

        if(transform.position.x > 10 && transform.position.z <= 10)
        { 
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
            if (transform.position.z > 8)
            {
                targetRotation = transform.rotation * Quaternion.AngleAxis(-90, transform.up);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
            }
        }

        if(transform.position.x >= 0 && transform.position.z > 10)
        {
            transform.Translate(-Vector3.right * speed * Time.deltaTime, Space.World);
            if (transform.position.x < 2)
            {
                targetRotation = transform.rotation * Quaternion.AngleAxis(-90, transform.up);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
            }
        }

        if(transform.position.x < 0 && transform.position.z >= 0)
        {           
            transform.Translate(-Vector3.forward * speed * Time.deltaTime, Space.World);
            if (transform.position.z < 2)
            {
                targetRotation = transform.rotation * Quaternion.AngleAxis(-90, transform.up);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
    }
}
