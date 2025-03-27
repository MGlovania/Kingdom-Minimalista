using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aldeano : MonoBehaviour
{
    public float speed;

    public Sprite tez1;
    public Sprite tez2;
    public Sprite tez3;
    public Sprite tez4;
    public Sprite tez5;
    public Sprite pantalon1;
    public Sprite pantalon2;
    public Sprite pantalon3;
    public Sprite pantalon4;
    public Sprite pantalon5;
    public Sprite pantalon6;
    public Sprite pantalon7;
    public Sprite pantalon8;
    public Sprite pantalon9;
    public Sprite pantalon10;
    public Sprite pantalon11;

    public GameObject cuerpo1;
    public GameObject cuerpo2;

    public Rigidbody2D rb;

    public int range;

    public int moverIzquierda;
    public int moverDerecha;
    public int puntoMover;
    public int moverHaciaElCentro;
    public GameObject centro;

    public bool esAldeanoSinEmpleo;
    public bool esAldeanoArquero;

    public GameObject manager;
    public GameObject dayNight;
    public GameObject posIz;
    public int puntoPosIz;
    public GameObject posDer;
    public int puntoPosDer;
    public Vector3 posicionAleatoriaDeNoche;
    public int puntoDeNoche;
    public int puntoSaltar;

    //Necesario para disparos
    public GameObject proyPrefab;
    public Transform spawnPoint;
    public Transform target;


    public AnimationCurve animCurve;
    public AnimationCurve axisCorrectionAnimCurve;

    public int dañoArquero;
    public float timeDisparo;
    void OnEnable()
    {
        target = null;
        puntoPosIz = 0;
        puntoPosDer = 0;
        esAldeanoSinEmpleo = true;
        esAldeanoArquero = false;
        timeDisparo = 2f;
        dañoArquero = 1;
          dayNight = GameObject.FindGameObjectWithTag("DayNightCycle");
        posIz = GameObject.FindGameObjectWithTag("AldeanosPosIz");
        posDer = GameObject.FindGameObjectWithTag("AldeanosPosDer");
        manager = GameObject.FindGameObjectWithTag("Manager");
        centro = GameObject.FindGameObjectWithTag("Centro");
        range = Random.Range(0, 6);
      
        if (range == 1)
        {
            cuerpo1.GetComponent<SpriteRenderer>().sprite = tez1;
        }
        if (range == 2)
        {
            cuerpo1.GetComponent<SpriteRenderer>().sprite = tez2;
        }
        if (range == 3)
        {
            cuerpo1.GetComponent<SpriteRenderer>().sprite = tez3;
        }
        if (range == 4)
        {
            cuerpo1.GetComponent<SpriteRenderer>().sprite = tez4;
        }
        if (range == 5)
        {
            cuerpo1.GetComponent<SpriteRenderer>().sprite = tez5;
        }

        range = Random.Range(0, 12);
        if (range == 1)
        {
            cuerpo2.GetComponent<SpriteRenderer>().sprite = pantalon1;
        }
        if (range == 2)
        {
            cuerpo2.GetComponent<SpriteRenderer>().sprite = pantalon2;
        }
        if (range == 3)
        {
            cuerpo2.GetComponent<SpriteRenderer>().sprite = pantalon3;
        }
        if (range == 4)
        {
            cuerpo2.GetComponent<SpriteRenderer>().sprite = pantalon4;
        }
        if (range == 5)
        {
            cuerpo2.GetComponent<SpriteRenderer>().sprite = pantalon5;
        }
        if (range == 6)
        {
            cuerpo2.GetComponent<SpriteRenderer>().sprite = pantalon6;
        }
        if (range == 7)
        {
            cuerpo2.GetComponent<SpriteRenderer>().sprite = pantalon7;
        }
        if (range == 8)
        {
            cuerpo2.GetComponent<SpriteRenderer>().sprite = pantalon8;
        }
        if (range == 9)
        {
            cuerpo2.GetComponent<SpriteRenderer>().sprite = pantalon9;
        }
        if (range == 10)
        {
            cuerpo2.GetComponent<SpriteRenderer>().sprite = pantalon10;
        }
        if (range == 11)
        {
            cuerpo2.GetComponent<SpriteRenderer>().sprite = pantalon11;
        }
        Invoke(nameof(Disparar), timeDisparo);
        Invoke(nameof(Verif), 1);
        Invoke(nameof(MoverAleatorio), Random.Range(1f, 5f));
        range = Random.Range(0, 2);
        if (range == 0)
        {
            Invoke(nameof(Arqueros), 0.5f);
        }
        if (range == 1)
        {
            Invoke(nameof(Nada), 0.5f);
        }

    }
    void Verif()
    {
        Invoke(nameof(Verif), 1);
        if (dayNight.GetComponent<DayNightCycle>().deNoche == 1)
        {
            if (esAldeanoArquero && puntoDeNoche <= 0)
            {
                puntoMover = 0;
                puntoDeNoche = 1;
                if (manager.GetComponent<Recursos>().cantidadAldeanosIz < manager.GetComponent<Recursos>().cantidadAldeanosDer)
                {
                    posicionAleatoriaDeNoche = posIz.transform.position + new Vector3(Random.Range(-1f, 1f), posIz.transform.position.y, posIz.transform.position.z);
                    manager.GetComponent<Recursos>().cantidadAldeanosIz += 1;
                    puntoPosIz = 1;
                }
                else if (manager.GetComponent<Recursos>().cantidadAldeanosDer < manager.GetComponent<Recursos>().cantidadAldeanosIz)
                {
                    posicionAleatoriaDeNoche = posDer.transform.position + new Vector3( Random.Range(-1f, 1f), posDer.transform.position.y, posDer.transform.position.z);
                    manager.GetComponent<Recursos>().cantidadAldeanosDer += 1;
                    puntoPosDer = 1;
                }
                else
                {
                    posicionAleatoriaDeNoche = posIz.transform.position + new Vector3(Random.Range(-1f, 1f), posIz.transform.position.y, posIz.transform.position.z);
                    manager.GetComponent<Recursos>().cantidadAldeanosIz += 1;
                    puntoPosIz = 1;
                }
            }

        }
        if (dayNight.GetComponent<DayNightCycle>().deDia == 1 && dayNight.GetComponent<DayNightCycle>().deNoche != 1)
        {
            if (puntoPosIz >= 1)
            {
                manager.GetComponent<Recursos>().cantidadAldeanosIz -= 1;

            }
            if (puntoPosIz >= 1)
            {
                manager.GetComponent<Recursos>().cantidadAldeanosDer -= 1;
            }
            puntoDeNoche = 0;
           
        }
    }
    void Arqueros()
    {
        if (manager.GetComponent<Recursos>().cantidadArquerosActual < manager.GetComponent<Recursos>().cantidadArquerosMax)
        {
            esAldeanoArquero = true;
            esAldeanoSinEmpleo = false;
            manager.GetComponent<Recursos>().cantidadArquerosActual += 1;
            manager.GetComponent<Recursos>().arqueriaAumentarNumero += 1;
        }
        range = Random.Range(0, 2);
        if (range == 0 && esAldeanoArquero == false)
        {
            Invoke(nameof(Arqueros), 0.5f);
        }
        if (range == 1)
        {
            Invoke(nameof(Nada), 0.5f);
        }
    }
    void Nada()
    {
        range = Random.Range(0, 2);
        if (range == 0 && esAldeanoArquero == false)
        {
            Invoke(nameof(Arqueros), 0.5f);
        }
        if (range == 1)
        {
            Invoke(nameof(Nada), 0.5f);
        }
    }
    void Disparar()
    {
        puntoSaltar = 0;
        Invoke(nameof(Disparar), timeDisparo);
        if (target != null && esAldeanoArquero)
        {
            range = Random.Range(0, 3);
            if (range == 0)
            {
                puntoSaltar = 1;
                transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.up * 2, 95 * Time.deltaTime);
            }
            GameObject obj = ObjectPool.SpawnObject(proyPrefab, spawnPoint.transform.position + Vector3.up / 2f, Quaternion.identity);

            obj.GetComponent<Proyectil>().target = target.transform;
            obj.GetComponent<Proyectil>().InitializeAnimationCurve(animCurve, axisCorrectionAnimCurve);
            obj.GetComponent<Proyectil>().daño = dañoArquero;
        }
        if (target != null && target.gameObject.activeSelf == false)
        {
            target = null;
        }
          
      


    }
    void MoverAleatorio()
    {
        if (puntoDeNoche <= 0)
        {
            puntoMover = 1;
            if (moverDerecha == 1)
            {
                moverIzquierda = 1;
                moverDerecha = 0;
            }
            else if (moverIzquierda == 1)
            {
                moverDerecha = 1;
                moverIzquierda = 0;
            }
            else
            {
                range = Random.Range(0, 2);
                if (range == 0)
                {
                    moverIzquierda = 1;
                }
                if (range == 1)
                {
                    moverDerecha = 1;
                }
            }
        }
      
        Invoke(nameof(Quieto), Random.Range(0.45f, 1.45f));
    }
    void Quieto()
    {

        puntoMover = 0;
        Invoke(nameof(MoverAleatorio), Random.Range(1f, 5f));
    }
    void Update()
    {


        if (moverDerecha == 1 && puntoMover >= 1 && moverHaciaElCentro <= 0)
        {

            rb.velocity = new Vector2(1 * speed, rb.velocity.y);

        }
        else if (moverIzquierda == 1 && puntoMover >= 1 && moverHaciaElCentro <= 0)
        {

            rb.velocity = new Vector2(-1 * speed, rb.velocity.y);

        }
        else if (moverHaciaElCentro >= 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, centro.transform.position, speed * Time.deltaTime);
            //  rb.velocity = new Vector2(centro.transform.position.x * speed, rb.velocity.y);

        }
        else if (puntoDeNoche >= 1 && puntoSaltar <= 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicionAleatoriaDeNoche, speed * Time.deltaTime);

        }
    











    }
    private void OnDisable()
    {
        manager.GetComponent<Recursos>().cantidadAldeanos -= 1;
        if (puntoPosIz >= 1)
        {
            manager.GetComponent<Recursos>().cantidadAldeanosIz -= 1;

        }
        if (puntoPosIz >= 1)
        {
            manager.GetComponent<Recursos>().cantidadAldeanosDer -= 1;
        }
       
        manager.GetComponent<Recursos>().cantidadArquerosActual -= 1;
        manager.GetComponent<Recursos>().arqueriaDisminuirNumero += 1;
    }
    void QuitarCentro()
    {
        moverHaciaElCentro = 0;
    }
   
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
            target = collision.gameObject.transform;
          
        }
        if (collision.CompareTag("LimiteAldeanos"))
        {
            moverHaciaElCentro = 1;
            Invoke(nameof(QuitarCentro), 1.5f);
        }
        if (collision.CompareTag("Escupitajo"))
        {

         
            ObjectPool.ReturnObjectToPool(gameObject);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
       
    }
}
