using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private int credits;

    public void LoadLevel(string name)
    {
        if(name == "Credits")
        {
            for(int i = 0; i < 20; i++)
                Debug.Log("EURIKA!!");
            credits = 2;
        }

        Debug.Log("Level load requested " + name);
        SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Debug.Log("Goodbye");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    void Update()
    {
        Debug.Log(credits);
    }

}
