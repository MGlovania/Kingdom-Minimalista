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
    public float speedNormal;
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

    public GameObject explosion;

   
    public int cooldownVolverACongelar;
    public GameObject sp;

    public GameObject dayNight;

    public int puntoMorir;
    void OnEnable()
    {
        puntoMorir = 0;
        target = null;
        popUpMasVioleta = GameObject.FindGameObjectWithTag("PopUpMasRecursos");
        posicionMadera = GameObject.FindGameObjectWithTag("PosicionMadera");
        player = GameObject.FindGameObjectWithTag("Player");
        manager = GameObject.FindGameObjectWithTag("Manager");
        dayNight = GameObject.FindGameObjectWithTag("DayNightCycle");
        if (esEnemigoComun)
        {         
            vida = 2 + dayNight.GetComponent<DayNightCycle>().aumentarVidaEnemigoComun;
            speed = 1.85f + Random.Range(0.4f, 0.65f);
            speedNormal = speed;
            daño = 1 + dayNight.GetComponent<DayNightCycle>().aumentarDañoEnemigoComun;
            cantidadVioleta = 1;
        }
        if (esEnemigoEscupidor)
        {
            vida = 2 + dayNight.GetComponent<DayNightCycle>().aumentarVidaEnemigoEscupidor;
            speed = 1.65f + Random.Range(0.35f, 0.6f);
            speedNormal = speed;
            daño = 2 + dayNight.GetComponent<DayNightCycle>().aumentarDañoEnemigoEscupidor;
            colliderAtacar.GetComponent<CircleCollider2D>().radius = Random.Range(2.7f, 3.1f);
            timeDisparo = Random.Range(2.75f - +dayNight.GetComponent<DayNightCycle>().aumentarVelocidadAtaqueEnemigoEscupidor, 3.25f - dayNight.GetComponent<DayNightCycle>().aumentarVelocidadAtaqueEnemigoEscupidor);
         
            cantidadVioleta = 1;
            Invoke(nameof(Disparar), timeDisparo);
        }
        manager.GetComponent<Recursos>().cantidadEnemigos += 1;
    }
    void Disparar()
    {
        puntoSaltar = 0;
        if (puntoMorir <= 0)
        {
            Invoke(nameof(Disparar), timeDisparo);
        }
     
        if (target != null && this.gameObject.activeSelf != false)
        {
            Vector2 direction = (target.transform.position + Vector3.up * Random.Range(4.25f, 6f)) - transform.position;
           
            transform.right = direction;
           

            range = Random.Range(0, 3);
            if (range == 0)
            {
                puntoSaltar = 1;
                transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.up * 2, 95 * Time.deltaTime);
            }
            GameObject obj = ObjectPool.SpawnObject(prefabEscupitajo, transform.position + Vector3.up / 2f, Quaternion.identity);      
            obj.GetComponent<Rigidbody2D>().velocity = transform.right * Random.Range(5f, 10f);
            obj.GetComponent<ProyectillMenosLag>().target = target.gameObject;
            obj.GetComponent<Escupitajo>().daño = daño;

            transform.rotation = Quaternion.Euler(Vector3.zero);


         //   obj.GetComponent<Proyectil>().target = target.transform;
          //  obj.GetComponent<Proyectil>().InitializeAnimationCurve(animCurve, axisCorrectionAnimCurve);
          //  obj.GetComponent<Proyectil>().esEscupitajo = true;
          //  obj.GetComponent<Escupitajo>().daño = daño;

        }
        if (target != null && target.gameObject.activeSelf == false)
        {
            target = null;
        }




    }
    private void OnDisable()
    {
        puntoMorir = 1;
        AudioManager.instance.PlaySFX("MorirEnemigo");
        if (manager.GetComponent<Trinkets>().necroticSelect >= 1)
        {
            range = Random.Range(0, 100);
            if (range <= 0 + (manager.GetComponent<Recursos>().rangeExplosionNecrotic - 1))
            {
                ObjectPool.SpawnObject(explosion, transform.position, Quaternion.identity);
            }
            
        }
            manager.GetComponent<Recursos>().cantidadEnemigosMatados += 1;
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
        if (speed <= 0)
        {
            speed = 0;
        }
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
    void QuitarCongelacion()
    {
        speed = speedNormal;
        sp.GetComponent<SpriteRenderer>().color = Color.white;
       
        Invoke(nameof(QuitarCD), 1f);
    }
    void QuitarCD()
    {
       
        cooldownVolverACongelar = 0;
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
       
        if (collision.CompareTag("Flecha") && collision.GetComponent<ProyectillMenosLag>().puntoProyectilYaImpactado <= 0)
        {
            collision.GetComponent<ProyectillMenosLag>().puntoProyectilYaImpactado = 1;
            Vector2 difference = transform.position - collision.transform.position;
            transform.position = new Vector2(transform.position.x + difference.x * 2, transform.position.y);
            popUpMenosVida.SetActive(false);
            popUpMenosVida.SetActive(true);
            textoPopUpMenosVida.text = "-" + collision.GetComponent<ProyectillMenosLag>().daño.ToString("F0");
            vida -=  collision.GetComponent<ProyectillMenosLag>().daño;
        }
        if (collision.CompareTag("Quemar"))
        {                    
            popUpMenosVida.SetActive(false);
            popUpMenosVida.SetActive(true);
            textoPopUpMenosVida.text = "-" + (manager.GetComponent<Recursos>().dañoElementalTotal + manager.GetComponent<Recursos>().dañoUniversal + manager.GetComponent<Recursos>().dañoFuego).ToString("F0");
            vida -= manager.GetComponent<Recursos>().dañoElementalTotal + manager.GetComponent<Recursos>().dañoUniversal + manager.GetComponent<Recursos>().dañoFuego;
        }
        if (collision.CompareTag("Escarcha") && cooldownVolverACongelar <= 0)
        {
            cooldownVolverACongelar = 1;
            speed -= 5;
            Invoke(nameof(QuitarCongelacion), manager.GetComponent<Recursos>().tiempoCongelacion);
            sp.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        if (collision.CompareTag("ExplosionNecrotic"))
        {
            Vector2 difference = transform.position - collision.transform.position;
            transform.position = new Vector2(transform.position.x + difference.x * 1.3f, transform.position.y);
            popUpMenosVida.SetActive(false);
            popUpMenosVida.SetActive(true);
            textoPopUpMenosVida.text = "-" + (manager.GetComponent<Recursos>().dañoFisicoTotal * 2).ToString("F0");
            vida -= manager.GetComponent<Recursos>().dañoFisicoTotal * 2;
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
