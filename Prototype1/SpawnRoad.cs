using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRoad : MonoBehaviour
{
    public GameObject player;
    public GameObject[] roads;

    private GameObject[] cloneRoads;

    private void Start()
    {
        cloneRoads = new GameObject[3];

        for (int i = 0; i < cloneRoads.Length; i++)
        {
            cloneRoads[i] = Instantiate(roads[Random.Range(0, roads.Length)], new Vector3(0, 0, player.transform.position.z + 160 * i), new Quaternion(0, 0, 0, 0));
        }
    }

    private void Update()
    {
        for (int i = 0; i < cloneRoads.Length; i++)
        {
            if (player.transform.position.z > cloneRoads[i].transform.position.z + 160)
            {
                Destroy(cloneRoads[i]);
                cloneRoads[i] = Instantiate(roads[Random.Range(0, roads.Length)], new Vector3(0, 0, player.transform.position.z + 320), new Quaternion(0, 0, 0, 0));
            }
        }
    }
}