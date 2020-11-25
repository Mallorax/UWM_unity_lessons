using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class zad1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    public int box_number;
    int objectCounter = 0;
    // obiekt do generowania
    public GameObject block;

    void Start()
    {
        int x1 = (int)(transform.position.x - transform.localScale.x) / 2;
        int x2 = (int)(transform.position.x + transform.localScale.x) / 2;
        int z1 = (int)(transform.position.z - transform.localScale.z) / 2;
        int z2 = (int)(transform.position.z + transform.localScale.z) / 2;
        // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        List<int> pozycje_x = new List<int>(Enumerable.Range(x1, x2).OrderBy(x => Guid.NewGuid()).Take(box_number));
        List<int> pozycje_z = new List<int>(Enumerable.Range(z1, z2).OrderBy(x => Guid.NewGuid()).Take(box_number));

        for (int i = 0; i < box_number; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], 5, pozycje_z[i]));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywołano coroutine");
        foreach (Vector3 pos in positions)
        {
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}
