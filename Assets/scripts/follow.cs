using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public GameObject player;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 player_position = player.transform.position;
        transform.position = new Vector3(player_position.x, player_position.y + 1, player_position.z -10 );
    }
}
