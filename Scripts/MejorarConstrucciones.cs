using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MejorarConstrucciones : MonoBehaviour
{
    public Sprite muroLv2;
    public Sprite muroLv3;

    public Sprite casaLv2;
    public Sprite casaLv3;

    public GameObject manager;
    public int puntoMejorar;
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
        Destroy(gameObject, 0.1f);
    }

 
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Muro") && puntoMejorar <= 0)
        {
            Debug.Log("dssd");
            puntoMejorar = 1;
            if (collision.GetComponent<Muros>().nivel == 1 && manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaMuro)
            {
                collision.GetComponent<SpriteRenderer>().sprite = muroLv2;
                collision.GetComponent<Muros>().vidaMax += 25;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaMuro;
                manager.GetComponent<Construir>().costeMaderaMuro += 5;
                collision.GetComponent<Muros>().nivel += 1;
            }
            else if (collision.GetComponent<Muros>().nivel == 2 && manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaMuro)
            {
                collision.GetComponent<SpriteRenderer>().sprite = muroLv3;
                collision.GetComponent<Muros>().vidaMax += 25;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaMuro;
                manager.GetComponent<Construir>().costeMaderaMuro += 5;
                collision.GetComponent<Muros>().nivel += 1;
            }
            else if(manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaMuro)
            {
                collision.GetComponent<Muros>().vidaMax += 25;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaMuro;
                manager.GetComponent<Construir>().costeMaderaMuro += 10;
                collision.GetComponent<Muros>().nivel += 1;
            }

            Destroy(gameObject);
        }
        if (collision.CompareTag("Casa") && puntoMejorar <= 0 && collision.GetComponent<Casa>().nivelCasa < 3)
        {
            puntoMejorar = 1;
            if (collision.GetComponent<Casa>().nivelCasa == 1 && manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaCasa)
            {             
                collision.GetComponent<SpriteRenderer>().sprite = casaLv2;
                collision.GetComponent<Casa>().timeSpawn -= 2;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaCasa;
                collision.GetComponent<Casa>().nivelCasa += 1;
            }
            else if (collision.GetComponent<Casa>().nivelCasa == 2 && manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaCasa)
            {
                collision.GetComponent<SpriteRenderer>().sprite = casaLv3;
                collision.GetComponent<Casa>().timeSpawn -= 2;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaCasa;
                collision.GetComponent<Casa>().nivelCasa += 1;
            }
          
            Destroy(gameObject);
        }
    }
}
