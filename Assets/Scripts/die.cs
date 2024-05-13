using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class die : MonoBehaviour
{
    public List<GameObject> players = new List<GameObject>();
    public Animator clone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        FindPlayers();
    }

    void Activate()
    {
        foreach (GameObject a in players)
        {
            if (!a.activeSelf)
            {

            }
        }
    }

    void FindPlayers()
    {
        GameObject[] targetArray = GameObject.FindGameObjectsWithTag("Player");
        players = new List<GameObject>(targetArray);
    }
}
