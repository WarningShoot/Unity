using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = player.transform.position;
    }
}