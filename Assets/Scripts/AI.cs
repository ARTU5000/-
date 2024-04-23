using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    
    public NavMeshAgent agent;
    public List<GameObject> targets = new List<GameObject>(); 
    public Animator clone;
    public GameObject closestTarget;
    public GameObject courrentTarget;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        clone.SetBool("alto", true);
        Invoke("Stop", 7);
        closestTarget = null;
    }

    void Update()
    {
        if (!clone.GetBool("alto") && closestTarget == null)
        {
            FindTargets();
            closestTarget = GetClosestTarget();
        }

        if (closestTarget != null)
        {
            agent.SetDestination(closestTarget.transform.position);

            if (!closestTarget.activeSelf)
            {
                closestTarget = this.gameObject;
                agent.isStopped = true;
                clone.SetBool("alto", true);
                Invoke("Stop", 5);
            }
            else
            {
                agent.isStopped = false;
            }
        }
    }

    void Stop()
    {
        clone.SetBool("alto", false);
        closestTarget = null;
    }

    GameObject GetClosestTarget()
    {
        GameObject ClosestTarget = null;
        float closestDistance = Mathf.Infinity;

        foreach (GameObject target in targets)
        {
            if (target == null) continue;

            float dist = Vector3.Distance(agent.transform.position, target.transform.position);

            if (dist < closestDistance)
            {
                closestDistance = dist;
                ClosestTarget = target;
            }
        }

        return ClosestTarget;
    }

    void FindTargets()
    {
        GameObject[] targetArray = GameObject.FindGameObjectsWithTag("Target");
        targets = new List<GameObject>(targetArray); 
    }

}

