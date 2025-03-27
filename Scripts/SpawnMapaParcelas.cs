using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMapaParcelas : MonoBehaviour
{
    public GameObject arbol;
    public GameObject piedra;
    public GameObject plata;
    public GameObject oro;

    public int range;

    public GameObject manager;

    public bool ladoIzquierdo;
    public bool ladDerecho;

    public int yaSpawneado;
    void Start()
    {

        range = Random.Range(0, 50);
        if (range <= 15 && manager.GetComponent<Mapa>().cantidadArbolesSpawneadosIz < 5 && ladoIzquierdo)
        {
            yaSpawneado = 1;
            manager.GetComponent<Mapa>().cantidadArbolesSpawneadosIz += 1;
            Instantiate(arbol, transform.position, Quaternion.identity);
        }
        if (range <= 22 && range >= 16 && manager.GetComponent<Mapa>().cantidadPiedrasSpawneadosIz < 3 && ladoIzquierdo)
        {
            yaSpawneado = 1;
            manager.GetComponent<Mapa>().cantidadPiedrasSpawneadosIz += 1;
            Instantiate(piedra, transform.position, Quaternion.identity);
        }
        if (range <= 27 && range >= 23 && manager.GetComponent<Mapa>().cantidadPlataSpawneadosIz < 2 && ladoIzquierdo)
        {
            yaSpawneado = 1;
            manager.GetComponent<Mapa>().cantidadPlataSpawneadosIz += 1;
            Instantiate(plata, transform.position, Quaternion.identity);
        }
        if (range <= 31 && range >= 28 && manager.GetComponent<Mapa>().cantidadOroSpawneadosIz < 1 && ladoIzquierdo)
        {
            yaSpawneado = 1;
            manager.GetComponent<Mapa>().cantidadOroSpawneadosIz += 1;
            Instantiate(oro, transform.position, Quaternion.identity);
        }
        if (range <= 15 && manager.GetComponent<Mapa>().cantidadArbolesSpawneadosDer < 5 && ladDerecho)
        {
            yaSpawneado = 1;
            manager.GetComponent<Mapa>().cantidadArbolesSpawneadosDer += 1;
            Instantiate(arbol, transform.position, Quaternion.identity);
        }
        if (range <= 22 && range >= 16 && manager.GetComponent<Mapa>().cantidadPiedrasSpawneadosDer < 3 && ladDerecho)
        {
            yaSpawneado = 1;
            manager.GetComponent<Mapa>().cantidadPiedrasSpawneadosDer += 1;
            Instantiate(piedra, transform.position, Quaternion.identity);
        }
        if (range <= 27 && range >= 23 && manager.GetComponent<Mapa>().cantidadPiedrasSpawneadosDer < 2 && ladDerecho)
        {
            yaSpawneado = 1;
            manager.GetComponent<Mapa>().cantidadPiedrasSpawneadosDer += 1;
            Instantiate(plata, transform.position, Quaternion.identity);
        }
        if (range <= 31 && range >= 28 && manager.GetComponent<Mapa>().cantidadPiedrasSpawneadosDer < 1 && ladDerecho)
        {
            yaSpawneado = 1;
            manager.GetComponent<Mapa>().cantidadPiedrasSpawneadosDer += 1;
            Instantiate(oro, transform.position, Quaternion.identity);
        }
        Invoke(nameof(VerifMapeado), 1f);
    }
    void VerifMapeado()
    {
        if (yaSpawneado <= 0)
        {
            if (manager.GetComponent<Mapa>().cantidadArbolesSpawneadosIz < 5 && ladoIzquierdo)
            {
                manager.GetComponent<Mapa>().cantidadArbolesSpawneadosIz += 1;
                Instantiate(arbol, transform.position, Quaternion.identity);
            }
            else if (manager.GetComponent<Mapa>().cantidadPiedrasSpawneadosIz < 3 && ladoIzquierdo)
            {
                manager.GetComponent<Mapa>().cantidadPiedrasSpawneadosIz += 1;
                Instantiate(piedra, transform.position, Quaternion.identity);
            }
            else if (manager.GetComponent<Mapa>().cantidadPlataSpawneadosIz < 2 && ladoIzquierdo)
            {
                manager.GetComponent<Mapa>().cantidadPlataSpawneadosIz += 1;
                Instantiate(plata, transform.position, Quaternion.identity);
            }
            else if (manager.GetComponent<Mapa>().cantidadOroSpawneadosIz < 1 && ladoIzquierdo)
            {
                manager.GetComponent<Mapa>().cantidadOroSpawneadosIz += 1;
                Instantiate(oro, transform.position, Quaternion.identity);
            }
            if (manager.GetComponent<Mapa>().cantidadArbolesSpawneadosDer < 5 && ladDerecho)
            {
                manager.GetComponent<Mapa>().cantidadArbolesSpawneadosDer += 1;
                Instantiate(arbol, transform.position, Quaternion.identity);
            }
            else if (manager.GetComponent<Mapa>().cantidadPiedrasSpawneadosDer < 3 && ladDerecho)
            {
                manager.GetComponent<Mapa>().cantidadPiedrasSpawneadosDer += 1;
                Instantiate(piedra, transform.position, Quaternion.identity);
            }
            else if (manager.GetComponent<Mapa>().cantidadPlataSpawneadosDer < 2 && ladDerecho)
            {
                manager.GetComponent<Mapa>().cantidadPlataSpawneadosDer += 1;
                Instantiate(plata, transform.position, Quaternion.identity);
            }
            else if (manager.GetComponent<Mapa>().cantidadOroSpawneadosDer < 1 && ladDerecho)
            {
                manager.GetComponent<Mapa>().cantidadOroSpawneadosDer += 1;
                Instantiate(oro, transform.position, Quaternion.identity);
            }
        }
       
    }

    void Update()
    {
        
    }
}
