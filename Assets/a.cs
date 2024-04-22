using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {

        float x = Random.Range(-49, 50);
        float z = Random.Range(-49, 50);

        transform.position = new Vector3(x, 1, z);
    }

    public void OnTriggerStay(Collider other)
    {

        float x = Random.Range(-49, 50);
        float z = Random.Range(-49, 50);

        transform.position = new Vector3(x, 1, z);
    }
}
