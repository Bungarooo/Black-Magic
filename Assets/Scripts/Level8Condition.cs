using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level8Condition : MonoBehaviour
{
    public GameObject go;

    void OnTriggerEnter2D(Collider2D collision)
    {
        go.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
