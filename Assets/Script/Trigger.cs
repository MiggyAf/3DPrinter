using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    


    void Start()
    {
      
    }



    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("fall"))
        {
            SceneManager.LoadScene(2);
        }
        
        if(other.gameObject.CompareTag("Level 2"))
        {
            SceneManager.LoadScene(1);
        }
    }

}
