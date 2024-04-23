using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using TMPro;

public class traget : MonoBehaviour
{public Transform npc;
    public GameObject targetPrefabs;
    public GameObject playerPrefabs;
    private List<GameObject> targets = new List<GameObject>();
    private List<GameObject> player = new List<GameObject>();
    private float spawn = 2f;
    public int totalTargets;
    public TextMeshProUGUI targetNumber;
    public GameObject[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTarget", spawn, spawn);
        InvokeRepeating("players",1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject target in targets)
        {
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
            
        if (targets.Count >= 20) 
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
        if (targets.Count < 20)
        {
            GameObject newTarget = Instantiate(targetPrefabs, transform.position, Quaternion.identity);

            float x = Random.Range(-19, 19);
            float z = Random.Range(-19, 19);

            newTarget.transform.position = new Vector3(x, 2, z);
            targets.Add(newTarget); 
        }
    }
    private void players()
    {
        GameObject randomSpawnPoint = GetRandomSpawnPoint();
        if (player.Count < 10)
        {
            GameObject newplayer = Instantiate(playerPrefabs, randomSpawnPoint.transform.localPosition, Quaternion.identity);
        
            float x = Random.Range(-19, 19);
            float z = Random.Range(-19, 19);

            newplayer.transform.position = new Vector3(x, 2, z);
            player.Add(newplayer); 
        }
    }
    
    GameObject GetRandomSpawnPoint()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        
        return spawnPoints[randomIndex];
    }
}
