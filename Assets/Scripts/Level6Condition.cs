using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level6Condition : MonoBehaviour
{
    public GameObject player;
    public GameObject locationTo;

    void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = new Vector3(locationTo.transform.position.x, locationTo.transform.position.y - 1, locationTo.transform.position.z);
    }
}
