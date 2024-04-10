using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPECIALManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SPECIAL NPC1 = new SPECIAL("Paco", 2, 3, 3, 10, 1, 9, 10, 5, 15, 66, 5);
        SPECIAL NPC2 = new SPECIAL("Ivan", 5, 7, 6, 7, 9, 2, 7, 21, 50, 1, 30);
        SPECIAL NPC3 = new SPECIAL("Agustin", 6, 7, 9, 8, 9, 3, 8, 24, 120, 3, 60);
        SPECIAL NPC4 = new SPECIAL("Farlan", 5, 8, 8, 9, 9, 3, 7, 22, 80, 2, 40);
        Debug.Log(NPC1.name);

    }

    // Update is called once per frame
    void Update()
    {
    }
}
