using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class traget : MonoBehaviour
{
    public Transform npc;
    public GameObject targetPrefabs;
    private GameObject[] targets = new GameObject[10];
    private int currentIndex = 0;
    private float spawn = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTarget", spawn, spawn);
    }

    // Update is called once per frame
    void Update()
    {
       for (int i = 0; i < targets.Length; i++)
        {
            GameObject target = targets[i];
            if (target == null) continue;

            float dist = Vector3.Distance(target.transform.position, npc.position);

            if (dist <= (2 + target.transform.position.y))
            {
                target.SetActive(false);
                float x = Random.Range(-19, 19);
                float z = Random.Range(-19, 19);

                target.transform.position = new Vector3(x, target.transform.position.y, z);

                Invoke("ActivateTarget", 5f);
            }
        }

        if (currentIndex >= 10)
        {
            CancelInvoke("SpawnTarget");
        }
    }

    private void ActivateTarget()
    {
        foreach (GameObject target in targets)
        {
            if (target == null) continue;
            target.SetActive(true);
        }
    }

    private void SpawnTarget()
    {
        if (currentIndex < 10)
        {
            GameObject newTarget = Instantiate(targetPrefabs, transform.position, Quaternion.identity);
            float x = Random.Range(-19, 19);
            float z = Random.Range(-19, 19);
            newTarget.transform.position = new Vector3(x, newTarget.transform.position.y, z);
            targets[currentIndex] = newTarget;
            currentIndex++;
        }
    }
}
