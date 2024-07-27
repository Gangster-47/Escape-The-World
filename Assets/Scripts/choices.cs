using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choices : MonoBehaviour
{
    // Start is called before the first frame update
    public void Choice1 ()
    {
     SceneManager.LoadScene(2); 
    }
    public void Choice2 ()
    {
     SceneManager.LoadScene(3); 
    }
    public void Choice3 ()
    {
     SceneManager.LoadScene(4); 
    }
}
