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
    public void OnTriggerStay(Collider other)
    {

        float x = Random.Range(-19, 19);
        float z = Random.Range(-19, 19);

        transform.position = new Vector3(x, transform.position.y, z);
    }
}
