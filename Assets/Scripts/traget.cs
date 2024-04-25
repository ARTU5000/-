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
    private float spawn = .2f;
    public int totalTargets;
    public TextMeshProUGUI targetNumber;
    public int totalplayers;
    public TextMeshProUGUI playersNumber;
    public GameObject[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTarget", spawn, spawn);
        InvokeRepeating("players",.1f,.1f);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject target in targets)
        {
            if (target == null) continue;

            foreach (GameObject play in player)
            {
                float dist = Vector3.Distance(target.transform.position, play.transform.position);

                if (dist <= (2 + target.transform.position.y))
                {
                    target.SetActive(false);
                    float x = Random.Range(-149, 150);
                    float z = Random.Range(-149, 150);

                    target.transform.position = new Vector3(x, target.transform.position.y, z);

                    Invoke("ActivateTarget", 5f);
                }
            }
        }

        totalTargets = Activetargets();
        targetNumber.text = "Targets Activos: " + totalTargets;
        totalplayers = Activeplayers();
        playersNumber.text = "Clones Activos: " + totalplayers;

        if (targets.Count >= 300) 
        {
            CancelInvoke("SpawnTarget");
        }
        if (player.Count >= 300)
        {
            CancelInvoke("players");
        }
    }

    int Activetargets()
    {
        int TotalTargets = 0;
        foreach (GameObject target in targets)
        {
            if (target.activeSelf)
            {
                TotalTargets++;
            }
        }
        return TotalTargets;
    }
    int Activeplayers()
    {
        int TotalTargets = 0;
        foreach (GameObject target in player)
        {
            if (target.activeSelf)
            {
                TotalTargets++;
            }
        }
        return TotalTargets;
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
        if (targets.Count < 300)
        {
            GameObject newTarget = Instantiate(targetPrefabs, transform.position, Quaternion.identity);

            float x = Random.Range(-149, 150);
            float z = Random.Range(-149, 150);

            newTarget.transform.position = new Vector3(x, 2, z);
            targets.Add(newTarget); 
        }
    }
    private void players()
    {
        GameObject randomSpawnPoint = GetRandomSpawnPoint();
        if (player.Count < 300)
        {
            GameObject newplayer = Instantiate(playerPrefabs, randomSpawnPoint.transform.localPosition, Quaternion.identity);
        
            float x = Random.Range(-149, 150);
            float z = Random.Range(-149, 150);

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
