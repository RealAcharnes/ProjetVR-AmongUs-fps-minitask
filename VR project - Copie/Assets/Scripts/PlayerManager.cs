using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private float respawnTime = 3f;
    private float respawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        respawnTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.activeSelf){
            respawnTimer += Time.deltaTime;
        }

        if (respawnTimer >= respawnTime)
        {
            player.SetActive(true);
            respawnTimer -= respawnTime;
        }
    }
}
