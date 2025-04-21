using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altar : MonoBehaviour
{
    public GameObject botonAltar;
    public GameObject botonAltar2;
    public GameObject botonGanar;

    public GameObject hoverQuitar;
    public GameObject hoverQuitar2;

    public GameObject dayNight;
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            botonAltar.SetActive(true);
            botonAltar2.SetActive(true);
            if (dayNight.GetComponent<DayNightCycle>().puntoDiaFinalAldeanos >= 1)
            {
                botonGanar.SetActive(true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            botonAltar.SetActive(false);
            botonAltar2.SetActive(false);
            hoverQuitar.SetActive(false);
            hoverQuitar2.SetActive(false);
            botonGanar.SetActive(false);
        }
    }
}
