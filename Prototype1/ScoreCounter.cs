using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public GameObject player;
    private Text text;

    private void Start()
    {
        text = gameObject.GetComponent<Text>();
        text.text = Mathf.Floor(player.transform.position.z).ToString();
    }

    private void Update()
    {
        text.text = Mathf.Floor(player.transform.position.z).ToString();
    }
}