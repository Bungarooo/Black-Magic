using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject go;

    void OnTriggerEnter2D(Collider2D collision)
    {
        go.SetActive(true);
    }

}