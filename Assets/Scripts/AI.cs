using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject target;
    public Animator clone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target.activeSelf == true)
        {
            agent.SetDestination(target.transform.position);
        }
        else
        {
            clone.SetBool("alto", true);
            Invoke("Stop", 5);
        }

        float dist = Vector3.Distance(agent.transform.position, target.transform.position);
        print(dist);
    }

    public void Stop()
    {
        clone.SetBool("alto", false);
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
