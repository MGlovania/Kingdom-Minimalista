using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Arbol : MonoBehaviour
{
    public Texture2D cursorHacha;
    public Texture2D cursorPico;
    public Texture2D cursorNormal;
    public bool estaJugadorEnColision;
    public bool mouseEnter;

    public GameObject madera;
    public GameObject piedra;
    public GameObject plata;
    public GameObject oro;

    public float timeTalar;
    public int puntoTalar;
    public int puntoMouseDown;
    public GameObject manager;

    public int maderaTotal;
    public TMP_Text textoMadera;
    public int range;

    public bool esArbol;
    public bool esPiedra;
    public bool esPlata;
    public bool esOro;

    public GameObject textoPopUpMenos;
    public GameObject textoPopUpMas;
    public GameObject posicionMadera;
    public GameObject posicionPopUpMenos;

    public GameObject brotePrefab;

    public int puntoMorir;
 
    void OnEnable()
    {
        puntoMorir = 0;
        textoPopUpMas = GameObject.FindGameObjectWithTag("PopUpMasRecursos");
        textoPopUpMenos = GameObject.FindGameObjectWithTag("PopUpMenosRecursos");
        posicionMadera = GameObject.FindGameObjectWithTag("PosicionMadera");
        posicionPopUpMenos = GameObject.FindGameObjectWithTag("PosicionPopUpMenos");
        manager = GameObject.FindGameObjectWithTag("Manager");
        Invoke(nameof(Talar), timeTalar);
        if (esArbol)
        {
            maderaTotal = Random.Range(80, 100);
        }
        if (esPiedra)
        {
            maderaTotal = Random.Range(100, 120);
        }
        if (esPlata)
        {
            maderaTotal = Random.Range(120, 140);
        }
        if (esOro)
        {
            maderaTotal = Random.Range(140, 160);
        }
     
    }

    void Talar()
    {
        if (puntoMorir <= 0)
        {
            Invoke(nameof(Talar), timeTalar);
        }

      
        if (puntoTalar >= 1 && estaJugadorEnColision)
        {
            range = Random.Range(0, 2);
            if (range == 0)
            {
                if (esArbol)
                {
                    AudioManager.instance.PlaySFX("Wood1");
                }
                else
                {
                    AudioManager.instance.PlaySFX("Rock1");
                }

            }
            else
            {
                if (esArbol)
                {
                    AudioManager.instance.PlaySFX("Wood2");
                }
                else
                {
                    AudioManager.instance.PlaySFX("Rock2");
                }

            }

            textoPopUpMenos.transform.position = posicionPopUpMenos.transform.position;
            textoPopUpMenos.SetActive(false);
            textoPopUpMenos.SetActive(true);
            textoPopUpMenos.GetComponent<TMP_Text>().text = "-" + manager.GetComponent<Recursos>().cantidadPicarRecursos.ToString("F0");
            maderaTotal -= 1;
            if (esArbol)
            {
                textoPopUpMas.transform.position = posicionMadera.transform.position + Vector3.right * 90.25f;
                textoPopUpMas.SetActive(false);
                textoPopUpMas.SetActive(true);
                textoPopUpMas.GetComponent<TMP_Text>().text = "+" + manager.GetComponent<Recursos>().cantidadPicarRecursos.ToString("F0");
                manager.GetComponent<Recursos>().cantidadMadera += 1;
                ObjectPool.SpawnObject(madera, new Vector3(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y + Random.Range(-0.2f, 0.3f), transform.position.z), Quaternion.identity);
            }
            if (esPiedra)
            {
                textoPopUpMas.transform.position = posicionMadera.transform.position + Vector3.right * 90.25f + Vector3.down * 45.5f;
                textoPopUpMas.SetActive(false);
                textoPopUpMas.SetActive(true);
                textoPopUpMas.GetComponent<TMP_Text>().text = "+" + manager.GetComponent<Recursos>().cantidadPicarRecursos.ToString("F0");
                manager.GetComponent<Recursos>().cantidadPiedra += 1;
                ObjectPool.SpawnObject(piedra, new Vector3(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y + Random.Range(-0.2f, 0.3f), transform.position.z), Quaternion.identity);
            }
            if (esPlata)
            {
                textoPopUpMas.transform.position = posicionMadera.transform.position + Vector3.right * 90.25f + Vector3.down * 90.2f;
                textoPopUpMas.SetActive(false);
                textoPopUpMas.SetActive(true);
                textoPopUpMas.GetComponent<TMP_Text>().text = "+" + manager.GetComponent<Recursos>().cantidadPicarRecursos.ToString("F0");
                manager.GetComponent<Recursos>().cantidadPlata += 1;
                ObjectPool.SpawnObject(plata, new Vector3(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y + Random.Range(-0.2f, 0.3f), transform.position.z), Quaternion.identity);
            }
            if (esOro)
            {
                textoPopUpMas.transform.position = posicionMadera.transform.position + Vector3.right * 90.25f + Vector3.down * 135.85f;
                textoPopUpMas.SetActive(false);
                textoPopUpMas.SetActive(true);
                textoPopUpMas.GetComponent<TMP_Text>().text = "+" + manager.GetComponent<Recursos>().cantidadPicarRecursos.ToString("F0");
                manager.GetComponent<Recursos>().cantidadOro += 1;
                ObjectPool.SpawnObject(oro, new Vector3(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y + Random.Range(-0.2f, 0.3f), transform.position.z), Quaternion.identity);
            }
          
        }
    }
    private void OnDisable()
    {
        puntoMorir = 1;
        if (esArbol && manager != null && manager.GetComponent<BotonesRun>().puntoRetry <= 0 )
        {
            ObjectPool.SpawnObject(brotePrefab, transform.position, Quaternion.identity);
        }
      
    }
    void Update()
    {
        if (maderaTotal <= 0)
        {
            ObjectPool.ReturnObjectToPool(gameObject);
        }

        textoMadera.text = maderaTotal.ToString("F0");
        if (mouseEnter && estaJugadorEnColision)
        {
            if (esArbol)
            {
                Cursor.SetCursor(cursorHacha, new Vector2(3, 1), CursorMode.Auto);
            }
            if (esPiedra || esPlata || esOro)
            {
                Cursor.SetCursor(cursorPico, new Vector2(3, 1), CursorMode.Auto);
            }
           
         
        }
        if (!mouseEnter && !estaJugadorEnColision)
        {
            puntoTalar = 0;
        }

    }
   
    private void OnMouseExit()
    {
        mouseEnter = false;
        Cursor.SetCursor(cursorNormal, new Vector2(3, 1), CursorMode.Auto);

    }
    private void OnMouseUp()
    {
     
            mouseEnter = false;
            puntoTalar = 0;
      
     

    }

    private void OnMouseEnter()
    {
        mouseEnter = true;
    }
    private void OnMouseDown()
    {
      
        if (estaJugadorEnColision)
        {
            mouseEnter = true;
            puntoTalar = 1;
        }
       
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Limite"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            estaJugadorEnColision = true;
        }
        
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            estaJugadorEnColision = false;
        }
    }
}
