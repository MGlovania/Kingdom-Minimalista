using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Muros : MonoBehaviour
{
    public TMP_Text textoVidaMax;
    public TMP_Text textoPopUpMenosVida;
    public GameObject textoMenosVida;
    public int vidaMax;
    public int vidaActual;
    public int menosVida;
    public int nivel;

    public Sprite muroDestruido1;
    public Sprite muroDestruido2;
    public Sprite muroDestruido3;

    public Sprite muroLvl1;
    public Sprite muroLvl2;
    public Sprite muroLvl3;

    public BoxCollider2D b1;
    public BoxCollider2D b2;
    public int puntoConstruirMuros;

    public int range;
    void Start()
    {
        nivel = 1;
        vidaMax = 50;
        vidaActual = vidaMax;
        Invoke(nameof(Verif), 1f);
    }
    void Verif()
    {
        Invoke(nameof(Verif), 1f);
        if (puntoConstruirMuros >= 1)
        {
            b1.enabled = true;
            b2.enabled = true;
            puntoConstruirMuros = 0;

            if (nivel == 1)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = muroLvl1;
            }
            if (nivel == 2)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = muroLvl2;
            }
            if (nivel >= 3)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = muroLvl3;
            }
            vidaActual = vidaMax;
        }
    
    }
   
    void Update()
    {
        if (vidaActual <= 0)
        {
            b1.enabled = false;
            b2.enabled = false;
          
            if (nivel == 1)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = muroDestruido1;
            }
            if (nivel == 2)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = muroDestruido2;
            }
            if (nivel >= 3)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = muroDestruido3;
            }
          
        }
        textoVidaMax.text = vidaActual.ToString("F0");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
          
            if (collision.GetComponent<Enemigo>().esEnemigoEscupidor != true)
            {
               
                    AudioManager.instance.PlaySFX("Wall1");
            
                menosVida = collision.GetComponent<Enemigo>().daño;
                textoMenosVida.SetActive(false);
                textoMenosVida.SetActive(true);
                textoPopUpMenosVida.text = "-" + menosVida.ToString("F0");
                vidaActual -= menosVida;
            }

        }
        if (collision.CompareTag("Escupitajo"))
        {
          
                AudioManager.instance.PlaySFX("Wall1");
          
            menosVida = collision.GetComponent<Escupitajo>().daño;
                textoMenosVida.SetActive(false);
                textoMenosVida.SetActive(true);
                textoPopUpMenosVida.text = "-" + menosVida.ToString("F0");
            vidaActual -= menosVida;
            ObjectPool.ReturnObjectToPool(collision.gameObject);

        }
    }
}
