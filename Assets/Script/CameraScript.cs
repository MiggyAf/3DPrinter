using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject cameraOne;
    public GameObject cameraTwo;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("next"))
        {
            cameraOne.SetActive(true);
            cameraTwo.SetActive(false);
            
        }

         if(Input.GetButtonDown("next2"))
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(true);
            
        }
        
         
    }
}
