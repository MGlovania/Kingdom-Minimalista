using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MejorarConstrucciones : MonoBehaviour
{
    public Sprite muroLv2;
    public Sprite muroLv3;

    public Sprite casaLv2;
    public Sprite casaLv3;

    public Sprite arqueriaLv2;
    public Sprite arqueriaLv3;

    public Sprite serreriaLv2;
    public Sprite serreriaLv3;

    public Sprite piedreriaLv2;
    public Sprite piedreriaLv3;

    public Sprite torreMagoLv2;
    public Sprite torreMagoLv3;

    public Sprite forjaLv2;
    public Sprite forjaLv3;

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
            AudioManager.instance.PlaySFX("Upgrade");
            puntoMejorar = 1;
            if (collision.GetComponent<Muros>().nivel == 1 && manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaMuro)
            {
                collision.GetComponent<SpriteRenderer>().sprite = muroLv2;
                collision.GetComponent<Muros>().vidaMax += 25;
                collision.GetComponent<Muros>().vidaActual += 25;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaMuro;
                manager.GetComponent<Construir>().costeMaderaMuro += 10;
                collision.GetComponent<Muros>().nivel += 1;
            }
            else if (collision.GetComponent<Muros>().nivel == 2 && manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaMuro)
            {
                collision.GetComponent<SpriteRenderer>().sprite = muroLv3;
                collision.GetComponent<Muros>().vidaMax += 25;
                collision.GetComponent<Muros>().vidaActual += 25;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaMuro;
                manager.GetComponent<Construir>().costeMaderaMuro += 10;
                collision.GetComponent<Muros>().nivel += 1;
            }
            else if(manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaMuro)
            {
                collision.GetComponent<Muros>().vidaMax += 25;
                collision.GetComponent<Muros>().vidaActual += 25;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaMuro;
                manager.GetComponent<Construir>().costeMaderaMuro += 20;
                collision.GetComponent<Muros>().nivel += 1;
            }

            Destroy(gameObject);
        }
       else if (collision.CompareTag("Casa") && puntoMejorar <= 0 && collision.GetComponent<Casa>().nivelCasa < 3)
        {
            AudioManager.instance.PlaySFX("Upgrade");
            puntoMejorar = 1;
            if (collision.GetComponent<Casa>().nivelCasa == 1 && manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaCasa)
            {             
                collision.GetComponent<SpriteRenderer>().sprite = casaLv2;
                collision.GetComponent<Casa>().timeSpawn -= 4;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaCasa;
                collision.GetComponent<Casa>().nivelCasa += 1;
            }
            else if (collision.GetComponent<Casa>().nivelCasa == 2 && manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaCasa)
            {
                collision.GetComponent<SpriteRenderer>().sprite = casaLv3;
                collision.GetComponent<Casa>().timeSpawn -= 4;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaCasa;
                collision.GetComponent<Casa>().nivelCasa += 1;
            }
          
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Arqueria") && puntoMejorar <= 0 && collision.GetComponent<Arqueria>().nivelCasa < 3)
        {
            AudioManager.instance.PlaySFX("Upgrade");
            puntoMejorar = 1;
            if (collision.GetComponent<Arqueria>().nivelCasa == 1 && manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaArqueria && manager.GetComponent<Recursos>().cantidadPiedra >= manager.GetComponent<Construir>().costePiedraArqueria)
            {
                collision.GetComponent<SpriteRenderer>().sprite = arqueriaLv2;
                collision.GetComponent<Arqueria>().cantidadArquerosMax += 7;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaArqueria;
                manager.GetComponent<Recursos>().cantidadPiedra -= manager.GetComponent<Construir>().costePiedraArqueria;
                collision.GetComponent<Arqueria>().nivelCasa += 1;
            }
            else if (collision.GetComponent<Arqueria>().nivelCasa == 2 && manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaArqueria && manager.GetComponent<Recursos>().cantidadPiedra >= manager.GetComponent<Construir>().costePiedraArqueria)
            {
                collision.GetComponent<SpriteRenderer>().sprite = arqueriaLv3;
                collision.GetComponent<Arqueria>().cantidadArquerosMax += 7;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaArqueria;
                manager.GetComponent<Recursos>().cantidadPiedra -= manager.GetComponent<Construir>().costePiedraArqueria;
                collision.GetComponent<Arqueria>().nivelCasa += 1;
            }

            Destroy(gameObject);
        }
        else if (collision.CompareTag("Serreria") && puntoMejorar <= 0 && collision.GetComponent<Serrerja>().nivelCasa < 3)
        {
            AudioManager.instance.PlaySFX("Upgrade");
            puntoMejorar = 1;
            if (collision.GetComponent<Serrerja>().nivelCasa == 1 && manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaSerreria && manager.GetComponent<Recursos>().cantidadPiedra >= manager.GetComponent<Construir>().costePiedraSerreria)
            {
                collision.GetComponent<SpriteRenderer>().sprite = serreriaLv2;
                collision.GetComponent<Serrerja>().time -= 4;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaSerreria;
                manager.GetComponent<Recursos>().cantidadPiedra -= manager.GetComponent<Construir>().costePiedraSerreria;
                collision.GetComponent<Serrerja>().nivelCasa += 1;
            }
            else if (collision.GetComponent<Serrerja>().nivelCasa == 2 && manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaSerreria && manager.GetComponent<Recursos>().cantidadPiedra >= manager.GetComponent<Construir>().costePiedraSerreria)
            {
                collision.GetComponent<SpriteRenderer>().sprite = serreriaLv3;
                collision.GetComponent<Serrerja>().time -= 4;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaSerreria;
                manager.GetComponent<Recursos>().cantidadPiedra -= manager.GetComponent<Construir>().costePiedraSerreria;
                collision.GetComponent<Serrerja>().nivelCasa += 1;
            }

            Destroy(gameObject);
        }
        else if (collision.CompareTag("Piedreria") && puntoMejorar <= 0 && collision.GetComponent<Serrerja>().nivelCasa < 3)
        {
            AudioManager.instance.PlaySFX("Upgrade");
            puntoMejorar = 1;
            if (collision.GetComponent<Serrerja>().nivelCasa == 1 && manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaPiedreria && manager.GetComponent<Recursos>().cantidadPiedra >= manager.GetComponent<Construir>().costePiedraPiedreria)
            {
                collision.GetComponent<SpriteRenderer>().sprite = piedreriaLv2;
                collision.GetComponent<Serrerja>().time -= 4;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaPiedreria;
                manager.GetComponent<Recursos>().cantidadPiedra -= manager.GetComponent<Construir>().costePiedraPiedreria;
                collision.GetComponent<Serrerja>().nivelCasa += 1;
            }
            else if (collision.GetComponent<Serrerja>().nivelCasa == 2 && manager.GetComponent<Recursos>().cantidadMadera >= manager.GetComponent<Construir>().costeMaderaPiedreria && manager.GetComponent<Recursos>().cantidadPiedra >= manager.GetComponent<Construir>().costePiedraPiedreria)
            {
                collision.GetComponent<SpriteRenderer>().sprite = piedreriaLv3;
                collision.GetComponent<Serrerja>().time -= 4;
                manager.GetComponent<Recursos>().cantidadMadera -= manager.GetComponent<Construir>().costeMaderaPiedreria;
                manager.GetComponent<Recursos>().cantidadPiedra -= manager.GetComponent<Construir>().costePiedraPiedreria;
                collision.GetComponent<Serrerja>().nivelCasa += 1;
            }
           
            Destroy(gameObject);
        }
        else if (collision.CompareTag("TorreMagos") && puntoMejorar <= 0 && collision.GetComponent<Arqueria>().nivelCasa < 3)
        {
            AudioManager.instance.PlaySFX("Upgrade");
            puntoMejorar = 1;
            if (collision.GetComponent<Arqueria>().nivelCasa == 1 && manager.GetComponent<Recursos>().cantidadPiedra >= manager.GetComponent<Construir>().costePiedraTorreMagos && manager.GetComponent<Recursos>().cantidadPlata >= manager.GetComponent<Construir>().costePlataTorreMagos)
            {
                collision.GetComponent<SpriteRenderer>().sprite = torreMagoLv2;
                collision.GetComponent<Arqueria>().cantidadArquerosMax += 4;
                manager.GetComponent<Recursos>().cantidadPiedra -= manager.GetComponent<Construir>().costePiedraTorreMagos;
                manager.GetComponent<Recursos>().cantidadPlata -= manager.GetComponent<Construir>().costePlataTorreMagos;
                collision.GetComponent<Arqueria>().nivelCasa += 1;
            }
            else if (collision.GetComponent<Arqueria>().nivelCasa == 2 && manager.GetComponent<Recursos>().cantidadPiedra >= manager.GetComponent<Construir>().costePiedraTorreMagos && manager.GetComponent<Recursos>().cantidadPlata >= manager.GetComponent<Construir>().costePlataTorreMagos)
            {
                collision.GetComponent<SpriteRenderer>().sprite = torreMagoLv3;
                collision.GetComponent<Arqueria>().cantidadArquerosMax += 4;
                manager.GetComponent<Recursos>().cantidadPiedra -= manager.GetComponent<Construir>().costePiedraTorreMagos;
                manager.GetComponent<Recursos>().cantidadPlata -= manager.GetComponent<Construir>().costePlataTorreMagos;
                collision.GetComponent<Arqueria>().nivelCasa += 1;
            }

            Destroy(gameObject);
        }
        else if (collision.CompareTag("Forja") && puntoMejorar <= 0 && collision.GetComponent<Forja>().nivelCasa < 3)
        {
            AudioManager.instance.PlaySFX("Upgrade");
            puntoMejorar = 1;
            if (collision.GetComponent<Forja>().nivelCasa == 1 && manager.GetComponent<Recursos>().cantidadPiedra >= manager.GetComponent<Construir>().costePiedraForja && manager.GetComponent<Recursos>().cantidadPlata >= manager.GetComponent<Construir>().costePlataForja)
            {
                collision.GetComponent<SpriteRenderer>().sprite = forjaLv2;
                collision.GetComponent<Forja>().bonus += 1;
                manager.GetComponent<Recursos>().cantidadPiedra -= manager.GetComponent<Construir>().costePiedraForja;
                manager.GetComponent<Recursos>().cantidadPlata -= manager.GetComponent<Construir>().costePlataForja;
                manager.GetComponent<Recursos>().dañoFisicoTotal += 1;
                collision.GetComponent<Forja>().nivelCasa += 1;
            }
            else if (collision.GetComponent<Forja>().nivelCasa == 2 && manager.GetComponent<Recursos>().cantidadPiedra >= manager.GetComponent<Construir>().costePiedraForja && manager.GetComponent<Recursos>().cantidadPlata >= manager.GetComponent<Construir>().costePlataForja)
            {
                collision.GetComponent<SpriteRenderer>().sprite = forjaLv3;
                collision.GetComponent<Forja>().bonus += 1;
                manager.GetComponent<Recursos>().cantidadPiedra -= manager.GetComponent<Construir>().costePiedraForja;
                manager.GetComponent<Recursos>().cantidadPlata -= manager.GetComponent<Construir>().costePlataForja;
                manager.GetComponent<Recursos>().dañoFisicoTotal += 1;
                collision.GetComponent<Forja>().nivelCasa += 1;
            }

            Destroy(gameObject);
        }

    }
}
