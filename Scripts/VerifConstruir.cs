using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerifConstruir : MonoBehaviour
{
    public int queConstruccionEs;

    public int puntoConstruirIz;
    public int puntoConstruirDer;

    public int obstruccionOtraConstruccion;
    void Start()
    {
        puntoConstruirIz = 0;
        puntoConstruirDer = 0;
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;


    }







    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ConstruirIz"))
        {
            puntoConstruirIz = 1;
            if (obstruccionOtraConstruccion != 1)
            {
                gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            }

        }
        if (collision.CompareTag("ConstruirDer"))
        {
            puntoConstruirDer = 1;
            if (obstruccionOtraConstruccion != 1)
            {
                gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            }

        }

        if (collision.CompareTag("Casa"))
        {
            obstruccionOtraConstruccion = 1;
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
       if (collision.CompareTag("Serreria"))
        {
            obstruccionOtraConstruccion = 1;
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (collision.CompareTag("Arqueria"))
        {
            obstruccionOtraConstruccion = 1;
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (collision.CompareTag("Piedreria"))
        {
            obstruccionOtraConstruccion = 1;
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (collision.CompareTag("TorreMagos"))
        {
            obstruccionOtraConstruccion = 1;
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (collision.CompareTag("Forja"))
        {
            obstruccionOtraConstruccion = 1;
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ConstruirIz"))
        {
            puntoConstruirIz = 0;
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (collision.CompareTag("ConstruirDer"))
        {
            puntoConstruirDer = 0;
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (collision.CompareTag("Casa"))
        {
            obstruccionOtraConstruccion = 0;
        }
        if (collision.CompareTag("Serreria"))
        {
            obstruccionOtraConstruccion = 0;
        }
        if (collision.CompareTag("Arqueria"))
        {
            obstruccionOtraConstruccion = 0;
        }
        if (collision.CompareTag("Piedreria"))
        {
            obstruccionOtraConstruccion = 0;
        }
        if (collision.CompareTag("TorreMagos"))
        {
            obstruccionOtraConstruccion = 0;
        }
        if (collision.CompareTag("Forja"))
        {
            obstruccionOtraConstruccion = 0;
        }
        if (puntoConstruirIz >= 1 && obstruccionOtraConstruccion == 0 || puntoConstruirDer >= 1 && obstruccionOtraConstruccion == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }

    }
}
