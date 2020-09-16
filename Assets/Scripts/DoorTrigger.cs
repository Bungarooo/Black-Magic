using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    LevelManager lm = new LevelManager();

    void OnTriggerEnter2D(Collider2D collision)
    {

        lm.LoadNextLevel();
    }
}
