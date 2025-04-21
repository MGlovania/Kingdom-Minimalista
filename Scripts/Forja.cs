using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Forja : MonoBehaviour
{
    public TMP_Text textoBonusDa�o;
    public int bonus;
    public int nivelCasa;

    public GameObject manager;
    void Start()
    {
        nivelCasa = 1;
        bonus = 1;
        manager = GameObject.FindGameObjectWithTag("Manager");
        manager.GetComponent<Recursos>().da�oFisicoTotal += 1;
    }

    void Update()
    {
        textoBonusDa�o.text = "+" + bonus.ToString("F0");
    }
}
