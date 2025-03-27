using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Hover2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject image;
    public void OnPointerEnter(PointerEventData eventData)
    {
       
            image.SetActive(true);
        

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.SetActive(false);
    }
}
