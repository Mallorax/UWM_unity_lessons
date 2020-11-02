using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad5 : MonoBehaviour
{
    public GameObject prefab;
    private float a = 1f;
    private float interval = 0.05f;
    private float nextTime = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Generate(Vector3 vector)
    {
        Instantiate(prefab, vector, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextTime)
        {
            nextTime += interval;
            Vector3 vector = new Vector3(Random.Range(-48, 48), 1.1f, Random.Range(-50, 50));
            if (Physics.CheckSphere(vector, a))
            {
                
            }
            else
            {
                Generate(vector);
            }
            
        }
        
    }
}
