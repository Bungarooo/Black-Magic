using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI task = null;
    [SerializeField]
    private string text = null;
    [SerializeField]
    bool levelCounter = false;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        task.text = text;

        Debug.Log(SceneManager.GetActiveScene().buildIndex.ToString());

        if (levelCounter == true)
        {
            task.text = SceneManager.GetActiveScene().buildIndex.ToString();
        }
    }

}
