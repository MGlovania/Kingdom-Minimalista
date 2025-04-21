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

    public int spawnDeEscupidores;
    public int aumentarCantidadEnemigos;

    public int puntoDisminuirDiasDeConsumo;

    public int aumentarVidaEnemigoComun;
    public int aumentarDañoEnemigoComun;
    public int aumentarVidaEnemigoEscupidor;
    public int aumentarDañoEnemigoEscupidor;
    public float aumentarVelocidadAtaqueEnemigoEscupidor;

    public int diasRequeridosParaAumentarVidaYDaño;
    public int diasRequeridosParaAumentarOtros;

    public int puntoDiaFinal;
    public int puntoDiaFinalAldeanos;

    /// public GameObject prefabParticulasFinal;
    //  public Vector3 aumentarPosicion;
    // public GameObject player;

    public GameObject fuegoArtificial1;
   
    void Start()
    {
        dias = 1;
       ppv = gameObject.GetComponent<Volume>();
    
        seconds = 0;
        Invoke(nameof(AumentarTiempo), 1);

        diasRequeridosParaAumentarVidaYDaño = 3;
        diasRequeridosParaAumentarOtros = 5;
       

    }
    void AumentarTiempo()
    {
        if (dias >= diasRequeridosParaAumentarVidaYDaño)
        {
            if (diasRequeridosParaAumentarVidaYDaño >= 10)
            {
                diasRequeridosParaAumentarVidaYDaño += 2;
                aumentarVidaEnemigoComun += 2;
                aumentarDañoEnemigoComun += 2;
                aumentarVidaEnemigoEscupidor += 2;
                aumentarDañoEnemigoEscupidor += 2;
            }
            else
            {
                diasRequeridosParaAumentarVidaYDaño += 2;
                aumentarVidaEnemigoComun += 1;
                aumentarDañoEnemigoComun += 1;
                aumentarVidaEnemigoEscupidor += 1;
                aumentarDañoEnemigoEscupidor += 1;
            }
        
        }
        if (dias >= diasRequeridosParaAumentarOtros)
        {
            diasRequeridosParaAumentarOtros += 3;
            aumentarVelocidadAtaqueEnemigoEscupidor += 0.25f;
        }

        if (dias >= 4)
        {
            spawnDeEscupidores = 1;
        }
        if (dias >= 5 && dias <= 10)
        {
            aumentarCantidadEnemigos = 4;
        }
        if (dias >= 11)
        {
            aumentarCantidadEnemigos = 10;
        }
        if (puntoDiaFinalAldeanos <= 0)
        {
            Invoke(nameof(AumentarTiempo), 1);
        }
      

        seconds += 1;
        if (seconds >= 120 && manager.GetComponent<Recursos>().cantidadEnemigos <= 0)
        {
            if (puntoDisminuirDiasDeConsumo >= 1)
            {
                manager.GetComponent<Recursos>().diasHastaDormir -= 1;
                if (manager.GetComponent<Recursos>().diasHastaDormir == 0)
                {
                    if (manager.GetComponent<Recursos>().cantidadLaps >= 3)
                    {
                        manager.GetComponent<Recursos>().sleeping.SetActive(false);
                        manager.GetComponent<Recursos>().consuming.SetActive(false);
                        manager.GetComponent<Recursos>().awaken.SetActive(true);
                        puntoDiaFinal = 1;
                        aumentarCantidadEnemigos = 15;
                    }
                    else
                    {
                        puntoDisminuirDiasDeConsumo = 0;
                        manager.GetComponent<Recursos>().violetasDonados = 0;
                        manager.GetComponent<Recursos>().violetasTotalesADonar += 50;
                        manager.GetComponent<Recursos>().sleeping.SetActive(true);
                        manager.GetComponent<Recursos>().consuming.SetActive(false);
                    }
                   
                }
            }
            sol.SetActive(false);
            sol.SetActive(true);
            seconds = 0;
            dias += 1;
            muro1.GetComponent<Muros>().puntoConstruirMuros = 1;
            muro2.GetComponent<Muros>().puntoConstruirMuros = 1;
        }
        if (seconds <= 95 && manager.GetComponent<Recursos>().diasHastaDormir >= 1)
        {
            puntoDisminuirDiasDeConsumo = 1;        
        }
        if (seconds > 70 && seconds < 90 && deNoche <= 0)
        {
            Invoke(nameof(ControlNoche), 0.1f);
            deNoche = 1;
            deDia = 0;
            if (dias >= 8)
            {
                Invoke(nameof(Enemigos), 15f);
            }
            if (dias >= 16)
            {
                Invoke(nameof(Enemigos), 20f);
            }
            if (puntoDiaFinal >= 1)
            {
                Invoke(nameof(Enemigos), 8f);
                Invoke(nameof(Enemigos), 13);
                Invoke(nameof(Enemigos), 24);
                Invoke(nameof(Enemigos), 30);
            }
            Invoke(nameof(Enemigos), 10f);
        }
        if (manager.GetComponent<Recursos>().cantidadEnemigos <= 0 && ppv.weight > 0 && seconds >= 120 || manager.GetComponent<Recursos>().cantidadEnemigos <= 0 && ppv.weight > 0 && seconds <= 10)
        {
            Invoke(nameof(ControlDia), 0.1f);
            deDia = 1;
            Invoke(nameof(QuitarPosAldeanos), 10f);
        }

        if (seconds > 86 && seconds < 119 && manager.GetComponent<Recursos>().cantidadEnemigos >= 1)
        {
               antorcha.SetActive(true);
        }
        else if(seconds >= 119 && manager.GetComponent<Recursos>().cantidadEnemigos <= 0)
        {
            if (puntoDiaFinal >= 1)
            {
                Invoke(nameof(Final), Random.Range(1.5f, 2.3f));
                Invoke(nameof(Final), Random.Range(1.2f, 1.8f));
            }
              antorcha.SetActive(false);

        }
      



    }
    void Final()
    {

        puntoDiaFinalAldeanos = 1;
        Invoke(nameof(Final), Random.Range(0.4f,1.2f));
        ObjectPool.SpawnObject(fuegoArtificial1, new Vector3(Random.Range(-9,9), -3f,0), Quaternion.identity);
        //    player.GetComponent<Player>().speed = 0;
        //    player.GetComponent<Player>().Jumpforce = 0;
        //    for (int i = 0; i < 52; i++)
        //    {
        //        ObjectPool.SpawnObject(prefabParticulasFinal, new Vector3(-32, -3.1f, 0) + aumentarPosicion, Quaternion.identity);
        //        aumentarPosicion += new Vector3(1.2f,0,0);

        //    }


    }
    void Enemigos()
    {
      
            for (int spawnEnemigos = 0; spawnEnemigos < Random.Range(3 + (dias * 2) + Random.Range(1 + aumentarCantidadEnemigos, 3 + aumentarCantidadEnemigos), 5 + (dias * 2) + Random.Range(1 + aumentarCantidadEnemigos, 3 + aumentarCantidadEnemigos)); spawnEnemigos++)
            {
                range = Random.Range(0, 2);
                if (range == 0)
                {
                    if (spawnDeEscupidores >= 1)
                    {
                        range = Random.Range(0, 10);
                        if (range <= 2)
                        {
                            GameObject obj = ObjectPool.SpawnObject(prefabEnemigoEscupidor, ladoiz.transform.position, Quaternion.identity);
                            obj.GetComponent<Enemigo>().spawnIz = true;
                        }
                        else
                        {
                            GameObject obj = ObjectPool.SpawnObject(prefabEnemigoComun, ladoiz.transform.position, Quaternion.identity);
                            obj.GetComponent<Enemigo>().spawnIz = true;
                        }
                    }
                    else
                    {
                        GameObject obj = ObjectPool.SpawnObject(prefabEnemigoComun, ladoiz.transform.position, Quaternion.identity);
                        obj.GetComponent<Enemigo>().spawnIz = true;
                    }
                   
                }
                if (range == 1)
                {
                    if (spawnDeEscupidores >= 1)
                    {
                        range = Random.Range(0, 10);
                        if (range <= 2)
                        {
                            GameObject obj2 = ObjectPool.SpawnObject(prefabEnemigoEscupidor, ladoDer.transform.position, Quaternion.identity);
                            obj2.GetComponent<Enemigo>().spawnDer = true;
                        }
                        else
                        {
                            GameObject obj2 = ObjectPool.SpawnObject(prefabEnemigoComun, ladoDer.transform.position, Quaternion.identity);
                            obj2.GetComponent<Enemigo>().spawnDer = true;
                        }
                    }
                    else
                    {
                        GameObject obj2 = ObjectPool.SpawnObject(prefabEnemigoComun, ladoDer.transform.position, Quaternion.identity);
                        obj2.GetComponent<Enemigo>().spawnDer = true;
                    }

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
