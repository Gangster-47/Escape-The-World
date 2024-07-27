using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class collision1 : MonoBehaviour
{
   int coin=0;
    AudioSource audo;

     [SerializeField]AudioClip CCoin;
     [SerializeField]AudioClip Win;
     [SerializeField]AudioClip Oops;
   public TextMeshProUGUI coinText;
   [SerializeField] float delaytime1=5f;
   [SerializeField] float delaytime2=5f;

public void Start()
{
    audo=GetComponent<AudioSource>(); 
}
        
        void OnCollisionEnter(Collision other) {
         if(other.gameObject.tag=="Enemy")
         {
             audo.PlayOneShot(Oops);
            Invoke("ReloadLevel", delaytime1);
         }
         if(other.gameObject.tag=="Finish")
         {
            audo.PlayOneShot(Win);
            Invoke("LoadNextLevel", delaytime2);
         }
         if(other.gameObject.tag=="GameFinish")
         {
            Invoke("Mainmenu", 0.6f);
         }
         if(other.gameObject.tag=="coin")
         {
            coin++;
            coinText.text="Coins:"+coin.ToString();
             audo.PlayOneShot(CCoin);
            Destroy(other.gameObject);
         }
        }
    // Start is called before the first frame update
    void ReloadLevel()
    {
      int sceneindex=SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(sceneindex);
    }
    void LoadNextLevel()
    {
      int sceneindex=SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(sceneindex+1);  
    }

    void Mainmenu()
    {
      SceneManager.LoadScene(0);
    }

}
