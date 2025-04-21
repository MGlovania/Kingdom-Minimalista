using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Casa : MonoBehaviour
{

    public GameObject prefabAldeano;
    public float timeSpawn;
    public float timeSpawn2;
    public float timeSpawnCountDown;

    public TMP_Text textoTimeSpawn;

    public GameObject manager;
    public int cantidadAldeanosAumentarTime;

    public int nivelCasa;
    public int posIz;
    public int posDer;
    public int cantidadDeAldeanosSpawneados;
  
    void Start()
    {
        nivelCasa = 1;
        cantidadAldeanosAumentarTime = 7;
        manager = GameObject.FindGameObjectWithTag("Manager");
        timeSpawnCountDown = manager.GetComponent<Recursos>().timeSpawnCasas;
        Invoke(nameof(SpawnAldeano), manager.GetComponent<Recursos>().timeSpawnCasas);
        timeSpawn2 = 0;
    }

    void SpawnAldeano()
    {
       
        AudioManager.instance.PlaySFX("PopSpawn");
        if (manager.GetComponent<Recursos>().cantidadAldeanos >= 100)
        {
            manager.GetComponent<Recursos>().cantidadAldeanosAlmacenados += 1;
        }
        else
        {
            manager.GetComponent<Recursos>().cantidadAldeanos += 1;
            ObjectPool.SpawnObject(prefabAldeano, transform.position, Quaternion.identity);
        }       
       
        cantidadDeAldeanosSpawneados += 1;
        if (cantidadDeAldeanosSpawneados >= cantidadAldeanosAumentarTime)
        {
            timeSpawn2 += 1;
            cantidadAldeanosAumentarTime += 6;
        }
        Invoke(nameof(SpawnAldeano), manager.GetComponent<Recursos>().timeSpawnCasas + timeSpawn2);
    }
    void Update()
    {
        
        timeSpawnCountDown -= Time.deltaTime;
        if (timeSpawnCountDown <= 0)
        {
            timeSpawnCountDown = manager.GetComponent<Recursos>().timeSpawnCasas + timeSpawn2;
        }
        textoTimeSpawn.text = timeSpawnCountDown.ToString("F0");
    }
}
