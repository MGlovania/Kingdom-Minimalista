using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
public class HoverVender : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
  

    public GameObject image;
    public GameObject texto;
    public GameObject manager;

    public bool memoriam;
    public bool babel;
    public bool gabriel;
    public bool hourglass;
    public bool necrotic;
    public bool cincuenta;
    public bool glass;
    public bool goliath;
    public bool bartholomew;

   
    public void OnPointerEnter(PointerEventData eventData)
    {
        
        if (memoriam)
        {
            if (manager.GetComponent<Recursos>().costeTrinketsVioletas >= 30)
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 23 * manager.GetComponent<Trinkets>().nivelMemoriam).ToString("F0");
            }
            else
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 4 * manager.GetComponent<Trinkets>().nivelMemoriam).ToString("F0");
            }
        }
        if (babel)
        {
            if (manager.GetComponent<Recursos>().costeTrinketsVioletas >= 30)
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 23 * manager.GetComponent<Trinkets>().nivelBabel).ToString("F0");
            }
            else
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 4 * manager.GetComponent<Trinkets>().nivelBabel).ToString("F0");
            }
        }
        if (gabriel)
        {
            if (manager.GetComponent<Recursos>().costeTrinketsVioletas >= 30)
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 23 * manager.GetComponent<Trinkets>().nivelGabriel).ToString("F0");
            }
            else
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 4 * manager.GetComponent<Trinkets>().nivelGabriel).ToString("F0");
            }
        }
        if (hourglass)
        {
            if (manager.GetComponent<Recursos>().costeTrinketsVioletas >= 30)
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 23 * manager.GetComponent<Trinkets>().nivelHourglass).ToString("F0");
            }
            else
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 4 * manager.GetComponent<Trinkets>().nivelHourglass).ToString("F0");
            }
        }
        if (necrotic)
        {
            if (manager.GetComponent<Recursos>().costeTrinketsVioletas >= 30)
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 23 * manager.GetComponent<Trinkets>().nivelNecrotic).ToString("F0");
            }
            else
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 4 * manager.GetComponent<Trinkets>().nivelNecrotic).ToString("F0");
            }
        }
        if (cincuenta)
        {
            if (manager.GetComponent<Recursos>().costeTrinketsVioletas >= 30)
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 23 * manager.GetComponent<Trinkets>().nivelCincuenta).ToString("F0");
            }
            else
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 4 * manager.GetComponent<Trinkets>().nivelCincuenta).ToString("F0");
            }
        }
        if (glass)
        {
            if (manager.GetComponent<Recursos>().costeTrinketsVioletas >= 30)
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 23 * manager.GetComponent<Trinkets>().nivelGlass).ToString("F0");
            }
            else
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 4 * manager.GetComponent<Trinkets>().nivelGlass).ToString("F0");
            }
        }
        if (goliath)
        {
            if (manager.GetComponent<Recursos>().costeTrinketsVioletas >= 30)
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 23 * manager.GetComponent<Trinkets>().nivelGoliath).ToString("F0");
            }
            else
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 4 * manager.GetComponent<Trinkets>().nivelGoliath).ToString("F0");
            }
        }
        if (bartholomew)
        {
            if (manager.GetComponent<Recursos>().costeTrinketsVioletas >= 30)
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 23 * manager.GetComponent<Trinkets>().nivelBartholomew).ToString("F0");
            }
            else
            {
                texto.GetComponent<TMP_Text>().text = (manager.GetComponent<Recursos>().costeTrinketsVioletas - 4 * manager.GetComponent<Trinkets>().nivelBartholomew).ToString("F0");
            }
        }
        image.SetActive(true);


    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.SetActive(false);
    }
}
