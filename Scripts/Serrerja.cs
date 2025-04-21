using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Serrerja : MonoBehaviour
{
     public TMP_Text textoTime;
    public float time;
    public float timeCountDown;

   
    public GameObject textoPopUpMas;
    public GameObject textoPopUpMas2;

    public GameObject manager;

    public GameObject posicionMadera;

    public int nivelCasa;

    public bool esSerreria;
    public bool esPiedreria;
    void Start()
    {
        nivelCasa = 1;
        posicionMadera = GameObject.FindGameObjectWithTag("PosicionMadera");
        textoPopUpMas2 = GameObject.FindGameObjectWithTag("PopUpMasRecursos");
        manager = GameObject.FindGameObjectWithTag("Manager");
        timeCountDown = time;
        Invoke(nameof(Spawn), time);
    }

    void Spawn()
    {
     
     
        textoPopUpMas.SetActive(false);
        textoPopUpMas.SetActive(true);
        textoPopUpMas2.SetActive(false);
        textoPopUpMas2.SetActive(true);
        if (esSerreria)
        {
            textoPopUpMas2.transform.position = posicionMadera.transform.position + Vector3.right * 90.25f;
            manager.GetComponent<Recursos>().cantidadMadera += 1;
        }
        if (esPiedreria)
        {
            textoPopUpMas2.transform.position = posicionMadera.transform.position + Vector3.right * 90.25f + Vector3.down * 45.5f;
            manager.GetComponent<Recursos>().cantidadPiedra += 1;
        }
       
        textoPopUpMas.GetComponent<TMP_Text>().text = "+" + manager.GetComponent<Recursos>().cantidadRecursosObtenidosDeConstrucciones.ToString("F0");
        textoPopUpMas2.GetComponent<TMP_Text>().text = "+" + manager.GetComponent<Recursos>().cantidadRecursosObtenidosDeConstrucciones.ToString("F0");
        Invoke(nameof(Spawn), time);
    }
    void Update()
    {
        timeCountDown -= Time.deltaTime;
        if (timeCountDown <= 0)
        {
            timeCountDown = time;
        }
        textoTime.text = timeCountDown.ToString("F0");
    }
}
