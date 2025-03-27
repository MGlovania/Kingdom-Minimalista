using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Casa : MonoBehaviour
{

    public GameObject prefabAldeano;
    public float timeSpawn;
    public float timeSpawnCountDown;

    public TMP_Text textoTimeSpawn;

    public GameObject manager;
    public int cantidadAldeanosAumentarTime;

    public int nivelCasa;
    public int posIz;
    public int posDer;
   
    void Start()
    {
        nivelCasa = 1;
        cantidadAldeanosAumentarTime = 10;
        manager = GameObject.FindGameObjectWithTag("Manager");
        timeSpawnCountDown = timeSpawn;
        Invoke(nameof(SpawnAldeano), timeSpawn);
    }

    void SpawnAldeano()
    {
        manager.GetComponent<Recursos>().cantidadAldeanos += 1;
        ObjectPool.SpawnObject(prefabAldeano, transform.position, Quaternion.identity);
        Invoke(nameof(SpawnAldeano), timeSpawn);
    }
    void Update()
    {
        if (manager.GetComponent<Recursos>().cantidadAldeanos >= cantidadAldeanosAumentarTime)
        {
            cantidadAldeanosAumentarTime += 10;
            timeSpawn = timeSpawn * 1.1f;
        }
        timeSpawnCountDown -= Time.deltaTime;
        if (timeSpawnCountDown <= 0)
        {
            timeSpawnCountDown = timeSpawn;
        }
        textoTimeSpawn.text = timeSpawnCountDown.ToString("F0");
    }
}
