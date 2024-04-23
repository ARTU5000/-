using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using TMPro;

public class traget : MonoBehaviour
{
    public Transform npc;
    public GameObject targetPrefabs;
    private GameObject[] targets = new GameObject[10];
    private int currentIndex = 0;
    private float spawn = 3f;
    public int totalTargets;
    public TextMeshProUGUI targetNumber;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTarget", spawn, spawn);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentIndex >= 10)
        {
            CancelInvoke("SpawnTarget");
        }
    }

    private void SpawnTarget()
    {
        if (currentIndex < 10)
        {
            GameObject newTarget = Instantiate(targetPrefabs, transform.position, Quaternion.identity);
            float x = Random.Range(-19, 19);
            float z = Random.Range(-19, 19);
            newTarget.transform.position = new Vector3(x, 2, z);
            targets[currentIndex] = newTarget;
            currentIndex++;
            totalTargets++;
        }
    }
}
