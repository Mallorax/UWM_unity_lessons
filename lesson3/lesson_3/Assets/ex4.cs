using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ex4 : MonoBehaviour
{
    public float speed = 10;
    private CharacterController controler;
    private float h = 0;
    private float v = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name != "Plane")
        {
            print(collision.gameObject.name);
        }   
        

    }

    // Start is called before the first frame update
    void Start()
    {
        controler = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(h, 0, v);
        transform.Translate(direction.normalized * Time.deltaTime * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
