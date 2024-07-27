using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public void PlayGame ()
    {
     int sceneindex=SceneManager.GetActiveScene().buildIndex;
     SceneManager.LoadScene(sceneindex+2); 
    }
    
    public void Options ()
    {
     int sceneindex=SceneManager.GetActiveScene().buildIndex;
     SceneManager.LoadScene(sceneindex+1); 
    }
    public void Controls ()
    {
     SceneManager.LoadScene(5); 
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
