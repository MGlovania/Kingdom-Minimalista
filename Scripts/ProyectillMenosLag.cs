using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectillMenosLag : MonoBehaviour
{


    public GameObject target;

 

    public int daño;

  
    public GameObject prefabParticulaFlecha;
    public GameObject particularBolaFuego;
    public GameObject particulaBolaFuegoChocar;
    public GameObject fuego;
    public GameObject particulaEscarcha;
    public GameObject particulEscarchaChocar;
    public GameObject escarcha;

    public bool esEscupitajo;

    public int puntoProyectilYaImpactado;

    public bool esFlecha;
    public bool esBolaFuego;
    public bool esEscarcha;

    public int puntoMorir;

    public GameObject manager;
    public int range;

    public int puntoGoliath;
    void OnEnable()
    {

        transform.localScale = new Vector3(1, 1, transform.localScale.z);

        manager = GameObject.FindGameObjectWithTag("Manager");
        puntoMorir = 0;
        puntoProyectilYaImpactado = 0;


        if (esFlecha)
        {
            Invoke(nameof(VerifGoliath), 0.05f);
        }
        if (esBolaFuego)
        {
            Invoke(nameof(ParticulaBolaFuego), 0.25f);
        }
        if (esEscarcha)
        {
            Invoke(nameof(ParticulaEscarcha), 0.25f);
        }
       


    }
    void VerifGoliath()
    {
        if (puntoGoliath >= 1)
        {

            transform.localScale = new Vector3(2f, 2f, transform.localScale.z);
            daño *= 5;

        }

    }
    void ParticulaBolaFuego()
    {
        if (puntoMorir <= 0)
        {
            Invoke(nameof(ParticulaBolaFuego), 0.25f);
            ObjectPool.SpawnObject(particularBolaFuego, transform.position, Quaternion.identity);
        }

    }
    void ParticulaEscarcha()
    {
        if (puntoMorir <= 0)
        {
            Invoke(nameof(ParticulaEscarcha), 0.25f);
            ObjectPool.SpawnObject(particulaEscarcha, transform.position, Quaternion.identity);
        }

    }
 
    private void OnDisable()
    {
        if (esBolaFuego)
        {
            if (range == 0)
            {
                AudioManager.instance.PlaySFX("Burn1");
            }
            else
            {
                AudioManager.instance.PlaySFX("Burn2");
            }
            ObjectPool.SpawnObject(particulaBolaFuegoChocar, transform.position, Quaternion.identity);
            ObjectPool.SpawnObject(fuego, transform.position, Quaternion.identity);
        }
        else if (esEscarcha)
        {
            if (range == 0)
            {
                AudioManager.instance.PlaySFX("Hielo1");
            }
            else
            {
                AudioManager.instance.PlaySFX("Hielo2");
            }
            
            range = Random.Range(0, 2);
            ObjectPool.SpawnObject(particulEscarchaChocar, transform.position, Quaternion.identity);
            ObjectPool.SpawnObject(escarcha, transform.position, Quaternion.identity);
        }
        else
        {
            AudioManager.instance.PlaySFX("ArrowRomper");
            ObjectPool.SpawnObject(prefabParticulaFlecha, transform.position, Quaternion.identity);
        }
        puntoMorir = 1;
        puntoGoliath = 0;
       
    
    }
    private void Update()
    {

      
        if (target != null && Vector3.Distance(transform.position, target.transform.position) < 0.3f)
        {
            ObjectPool.ReturnObjectToPool(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Suelo"))
        {
            ObjectPool.ReturnObjectToPool(gameObject);
        }

    }

}
