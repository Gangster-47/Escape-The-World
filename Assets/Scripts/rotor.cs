using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotor : MonoBehaviour
{
    [SerializeField] float rotatingspeed=2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    transform.Rotate(1,1,1); 
    }
}
