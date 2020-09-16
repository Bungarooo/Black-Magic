using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5Condition : MonoBehaviour
{
    public GameObject go;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            go.SetActive(true);
        }
    }
}
