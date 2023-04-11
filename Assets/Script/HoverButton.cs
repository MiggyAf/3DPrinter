using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverButton : MonoBehaviour
{
    public RectTransform Button;
    // Start is called before the first frame update
    void Start()
    {
        Button.GetComponent<Animator>().Play("Hover Off");
    }

   
    public void OnPointEnter(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().Play("Hover On");
    }

    public void OnPointExit(PointerEventData eventData)
    {
         Button.GetComponent<Animator>().Play("Hover Off");
    }
}
