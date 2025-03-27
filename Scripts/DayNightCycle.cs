using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;
public class DayNightCycle : MonoBehaviour
{
    public TMP_Text textoCantidadDias;

    public int dias;

    public Volume ppv;

    public float seconds;

    public int deNoche;
    public int deDia;

    public GameObject antorcha;

    public GameObject prefabEnemigoComun;
    public GameObject prefabEnemigoEscupidor;



    public GameObject ladoiz;
    public GameObject ladoDer;

    public int range;

    public GameObject manager;

    public GameObject sol;

    public GameObject muro1;
    public GameObject muro2;
    void Start()
    {
        dias = 1;
       ppv = gameObject.GetComponent<Volume>();
    
        seconds = 0;
        Invoke(nameof(AumentarTiempo), 1);
    }
    void AumentarTiempo()
    {
        Invoke(nameof(AumentarTiempo), 1);

        seconds += 1;
        if (seconds >= 140 && manager.GetComponent<Recursos>().cantidadEnemigos <= 0)
        {
            sol.SetActive(false);
            sol.SetActive(true);
            seconds = 0;
            dias += 1;
            muro1.GetComponent<Muros>().puntoConstruirMuros = 1;
            muro2.GetComponent<Muros>().puntoConstruirMuros = 1;
        }
        if (seconds > 80 && seconds < 100 && deNoche <= 0)
        {
            Invoke(nameof(ControlNoche), 0.1f);
            deNoche = 1;
            deDia = 0;
            Invoke(nameof(Enemigos), 10f);
        }
        if (manager.GetComponent<Recursos>().cantidadEnemigos <= 0 && ppv.weight > 0 && seconds >= 95 || manager.GetComponent<Recursos>().cantidadEnemigos <= 0 && ppv.weight > 0 && seconds <= 10)
        {
            Invoke(nameof(ControlDia), 0.1f);
            deDia = 1;
            Invoke(nameof(QuitarPosAldeanos), 10f);
        }

        if (seconds > 94 && manager.GetComponent<Recursos>().cantidadEnemigos >= 1)
        {
               antorcha.SetActive(true);
        }
        else
        {
              antorcha.SetActive(false);

        }




    }
    void Enemigos()
    {
        for (int spawnEnemigos = 0; spawnEnemigos < Random.Range(4 + dias + Random.Range(1,3), 7 + Random.Range(1, 3)) * dias; spawnEnemigos++)
        {
            range = Random.Range(0, 2);
            if (range == 0)
            {
               GameObject obj =  ObjectPool.SpawnObject(prefabEnemigoComun, ladoiz.transform.position, Quaternion.identity);
                obj.GetComponent<Enemigo>().spawnIz = true;
            }
            if (range == 1)
            {
                GameObject obj = ObjectPool.SpawnObject(prefabEnemigoComun, ladoDer.transform.position, Quaternion.identity);
                obj.GetComponent<Enemigo>().spawnDer = true;
            }

         
        }
    }
    void QuitarPosAldeanos()
    {
     
        deNoche = 0;
    }
    public void ControlNoche() 
    {
        if (ppv.weight <= 1)
        {
            Invoke(nameof(ControlNoche), 0.08f);
        }
      
        ppv.weight += 0.006f;

     




    }
    public void ControlDia() // used to adjust the post processing slider.
    {

        if (ppv.weight >= 0)
        {
            Invoke(nameof(ControlDia), 0.08f);
        }
       

        ppv.weight -= 0.01f;
     

    }


    void Update()
    {
        textoCantidadDias
            .text = dias.ToString("F0");
    }
}
