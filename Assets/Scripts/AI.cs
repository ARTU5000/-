using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        //float dist = Dist(agent.gameObject.transform.position, target.position);

        float dist = Vector3.Distance(agent.transform.position, target.position);
        print(dist);
    }

    float Dist(Vector3 pos1, Vector3 pos2)
    {
        float x = pos2.x - pos1.x;
        float y = pos2.y - pos1.y;
        float z = pos2.z - pos1.z;

        float dist = Mathf.Sqrt(x * x + y * y + z * z);
        return dist;
    }
}
