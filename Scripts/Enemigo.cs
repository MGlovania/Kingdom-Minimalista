using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Enemigo : MonoBehaviour
{
    public TMP_Text textoPopUpMenosVida;
    public GameObject popUpMenosVida;

   
    public GameObject popUpMasVioleta;
    public GameObject posicionMadera;

    public int vida;
    public float speed;
    public int daño;
    public float timeDisparo;

    public bool esEnemigoComun;
    public bool esEnemigoEscupidor;

    public GameObject player;

    public int puntoMoverKnockBack;
    public int puntoDisparar;
    

    public bool spawnIz;
    public bool spawnDer;

    public GameObject prefabParticula;

    public int cantidadVioleta;
    public GameObject manager;

 

    public AnimationCurve animCurve;
    public AnimationCurve axisCorrectionAnimCurve;

    public int puntoSaltar;
    public GameObject target;
    public int range;
    public GameObject prefabEscupitajo;
    public GameObject colliderAtacar;
    void OnEnable()
    {
        target = null;
        popUpMasVioleta = GameObject.FindGameObjectWithTag("PopUpMasRecursos");
        posicionMadera = GameObject.FindGameObjectWithTag("PosicionMadera");
        player = GameObject.FindGameObjectWithTag("Player");
        manager = GameObject.FindGameObjectWithTag("Manager");
        if (esEnemigoComun)
        {
            vida = 2;
            speed = 1.85f + Random.Range(0.4f, 0.65f);
            daño = 11;
            cantidadVioleta = 1;
        }
        if (esEnemigoEscupidor)
        {
            vida = 2;
            speed = 1.65f + Random.Range(0.35f, 0.6f);
            daño = 2;
            colliderAtacar.GetComponent<CircleCollider2D>().radius = Random.Range(2.7f, 3.1f);
            timeDisparo = Random.Range(2.75f, 3.25f);
         
            cantidadVioleta = 1;
            Invoke(nameof(Disparar), timeDisparo);
        }
        manager.GetComponent<Recursos>().cantidadEnemigos += 1;
    }
    void Disparar()
    {
        puntoSaltar = 0;
        Invoke(nameof(Disparar), timeDisparo);
        if (target != null && this.gameObject.activeSelf != false)
        {
            range = Random.Range(0, 3);
            if (range == 0)
            {
                puntoSaltar = 1;
                transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.up * 2, 95 * Time.deltaTime);
            }
            GameObject obj = ObjectPool.SpawnObject(prefabEscupitajo, transform.position + Vector3.up / 2f, Quaternion.identity);

            obj.GetComponent<Proyectil>().target = target.transform;
            obj.GetComponent<Proyectil>().InitializeAnimationCurve(animCurve, axisCorrectionAnimCurve);
            obj.GetComponent<Proyectil>().esEscupitajo = true;
            obj.GetComponent<Escupitajo>().daño = daño;

        }
        if (target != null && target.gameObject.activeSelf == false)
        {
            target = null;
        }




    }
    private void OnDisable()
    {
        manager.GetComponent<Recursos>().cantidadEnemigos -= 1;
        popUpMasVioleta.transform.position = posicionMadera.transform.position + Vector3.right * 90.25f + Vector3.down * 175f;
        popUpMasVioleta.SetActive(false);
        popUpMasVioleta.SetActive(true);
        popUpMasVioleta.GetComponent<TMP_Text>().text = "+" + cantidadVioleta.ToString("F0");
        ObjectPool.SpawnObject(prefabParticula, transform.position, Quaternion.identity);
        manager.GetComponent<Recursos>().cantidadVioleta += cantidadVioleta;
        spawnIz = false;
        spawnDer = false;
    }

    void Update()
    {
        if (puntoDisparar >= 1 && target == null)
        {
            puntoDisparar = 0;
        }
        if (vida <= 0)
        {
            ObjectPool.ReturnObjectToPool(gameObject);
        }
        if (puntoMoverKnockBack <= 0 && puntoDisparar <= 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
        else if (puntoMoverKnockBack >= 1 && spawnIz)
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.up * 5.25f + Vector3.left * 5, 9f * Time.deltaTime);
        }
        else if (puntoMoverKnockBack >= 1 && spawnDer)
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.up * 5.25f + Vector3.right * 5, 9f * Time.deltaTime);
        }

    }
    void QuitarPunto()
    {
     
        puntoMoverKnockBack = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Muro"))
        {
            if (esEnemigoComun)
            {
                puntoMoverKnockBack = 1;
            }
            if (esEnemigoEscupidor)
            {
                puntoDisparar = 1;
                target = collision.gameObject;
            }

            Invoke(nameof(QuitarPunto), 0.72f);

        }
        if (collision.CompareTag("Aldeano2"))
        {
            ObjectPool.ReturnObjectToPool(collision.GetComponentInParent<AldeanoDestruir>().padre);
            ObjectPool.ReturnObjectToPool(gameObject);

        }
       
        if (collision.CompareTag("Flecha") && collision.GetComponent<Proyectil>().puntoProyectilYaImpactado <= 0)
        {
            collision.GetComponent<Proyectil>().puntoProyectilYaImpactado = 1;
            Vector2 difference = transform.position - collision.transform.position;
            transform.position = new Vector2(transform.position.x + difference.x * 2, transform.position.y);
            popUpMenosVida.SetActive(false);
            popUpMenosVida.SetActive(true);
            textoPopUpMenosVida.text = "-" + collision.GetComponent<Proyectil>().daño.ToString("F0");
            vida -=  collision.GetComponent<Proyectil>().daño;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Muro") && esEnemigoEscupidor)
        {
           
                puntoDisparar = 0;
                target = null;
          

        }
    }
}
