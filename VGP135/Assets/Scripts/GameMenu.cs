using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    public string StartScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAgainButton()
    {
        Debug.Log("PlayAgainButton() called");
        UnityEngine.SceneManagement.Scene current = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        UnityEngine.SceneManagement.SceneManager.LoadScene(current.name);
    }

    public void MainMenuButton()
    {
        Debug.Log("MainMenuButton() called");
        UnityEngine.SceneManagement.SceneManager.LoadScene(StartScene);
    }
}
