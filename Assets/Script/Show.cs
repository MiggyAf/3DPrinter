using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show : MonoBehaviour
{

    public GameObject Object;
    // Start is called before the first frame update
    void Start()
    {
        Object.SetActive(false);
    }


    void OnTriggerEnter()
    {
        Object.SetActive(true);

    }

    void OnTriggerExit()
    {
        Object.SetActive(false);
    }

}