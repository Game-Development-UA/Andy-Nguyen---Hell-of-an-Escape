using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_respawn : MonoBehaviour
{
    public Transform spawnPoint;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Spike"))
        {
            collision.transform.position = spawnPoint.transform.position;
        }

    }
}
