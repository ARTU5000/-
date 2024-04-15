using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class traget : MonoBehaviour
{
    public Transform npc;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(target.gameObject.transform.position, npc.position);

        if (dist <= (1 + target.transform.position.y))
        {
            target.gameObject.SetActive(false);

            float x = Random.Range(-19, 19);
            float z = Random.Range(-19, 19);

            target.transform.position = new Vector3(x, target.transform.position.y, z);

            target.gameObject.SetActive(true);
        }
    }
}
