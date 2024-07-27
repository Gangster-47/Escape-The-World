using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimatorController : MonoBehaviour
{
    Animator animator;
    [SerializeField]float runningspeed=2f;
    [SerializeField]float leftright=1f; 
    
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0,0,1*runningspeed*Time.deltaTime);
            transform.Translate(0,0,1*runningspeed*Time.deltaTime);
        if(Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("isjumping",true);
        }
        if(!(Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow)))
        {
            animator.SetBool("isjumping",false);
        }
        if(Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("isrolling",true);
        }
        
        if(!(Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.DownArrow)))
        {
            animator.SetBool("isrolling",false);
        }
        if(Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-1*leftright*Time.deltaTime,0,0);
        }
        
        if(Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1*leftright*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
        if(Input.GetKey("n"))
        {
            int sceneindex=SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(sceneindex+1);
        }
    }
}
