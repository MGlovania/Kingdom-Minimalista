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
    public bool esAldeanoMago;
    public GameObject prefabBolaFuego;
    public GameObject prefabEscarcha;

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


  //  public AnimationCurve animCurve;
 //   public AnimationCurve axisCorrectionAnimCurve;

    public int dañoArquero;

    public int vida;

    public GameObject particulasMorir;

    public GameObject player;

    void OnEnable()
    {
        vida = 2;
        target = null;
        puntoPosIz = 0;
        puntoPosDer = 0;
        esAldeanoSinEmpleo = true;
        esAldeanoArquero = false;
        esAldeanoMago = false;
        player = GameObject.FindGameObjectWithTag("Player");
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
      
        Invoke(nameof(Verif), 1);
        Invoke(nameof(MoverAleatorio), Random.Range(1f, 5f));
        range = Random.Range(0, 3);
        if (range == 0)
        {
            Invoke(nameof(Arqueros), 0.5f);
        }
        if (range == 1)
        {
            Invoke(nameof(Magos), 0.5f);
        }
        if (range == 2)
        {
            Invoke(nameof(Nada), 0.5f);
        }
      
    }
    void Verif()
    {
        if (player.GetComponent<Player>().puntoMorir >= 1)
        {
            ObjectPool.ReturnObjectToPool(gameObject);
        }
      //verif nuevos targets
        if (gameObject.GetComponent<CircleCollider2D>().enabled)
        {
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<CircleCollider2D>().enabled = true;
        }

        Invoke(nameof(Verif), 1);
        if (esAldeanoArquero)
        {
            dañoArquero = manager.GetComponent<Recursos>().dañoFisicoTotal + manager.GetComponent<Recursos>().dañoUniversal;
        }
        if (esAldeanoMago)
        {
            dañoArquero = manager.GetComponent<Recursos>().dañoElementalTotal + manager.GetComponent<Recursos>().dañoUniversal;
        }
       
        if (dayNight.GetComponent<DayNightCycle>().deNoche == 1)
        {
            if (!esAldeanoSinEmpleo && puntoDeNoche <= 0)
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
            vida = 2;
        }
        if (dayNight.GetComponent<DayNightCycle>().puntoDiaFinalAldeanos >= 1)
        {
         
                transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.up * 2, 95 * Time.deltaTime);
        
        }
    }
   
    void Arqueros()
    {
        if (manager.GetComponent<Recursos>().cantidadArquerosActual < manager.GetComponent<Recursos>().cantidadArquerosMax)
        {
            Invoke(nameof(Disparar), manager.GetComponent<Recursos>().timeDisparoArqueros);
            esAldeanoArquero = true;
            esAldeanoSinEmpleo = false;
            manager.GetComponent<Recursos>().cantidadArquerosActual += 1;
            manager.GetComponent<Recursos>().arqueriaAumentarNumero += 1;
        }
        range = Random.Range(0, 3);
        if (range == 0 && !esAldeanoArquero && !esAldeanoMago)
        {
            Invoke(nameof(Arqueros), 0.5f);
        }
       else if (range == 1 && !esAldeanoArquero && !esAldeanoMago)
        {
            Invoke(nameof(Magos), 0.5f);
        }
        else if (range == 2)
        {
            Invoke(nameof(Nada), 0.5f);
        }
    }
    void Magos()
    {
        if (manager.GetComponent<Recursos>().cantidadMagosActual < manager.GetComponent<Recursos>().cantidadMagosMax)
        {
            Invoke(nameof(Disparar), manager.GetComponent<Recursos>().timeDisparoMagos);
            esAldeanoMago = true;
            esAldeanoSinEmpleo = false;
            manager.GetComponent<Recursos>().cantidadMagosActual += 1;
            manager.GetComponent<Recursos>().magosAumentarNumero += 1;
        }
        range = Random.Range(0, 3);
        if (range == 0 && !esAldeanoArquero && !esAldeanoMago)
        {
            Invoke(nameof(Arqueros), 0.5f);
        }
        else if (range == 1 && !esAldeanoMago && !esAldeanoMago)
        {
            Invoke(nameof(Magos), 0.5f);
        }
        else if (range == 2)
        {
            Invoke(nameof(Nada), 0.5f);
        }
    }
    void Nada()
    {
        range = Random.Range(0, 3);
        if (range == 0 && !esAldeanoArquero && !esAldeanoMago)
        {
            Invoke(nameof(Arqueros), 0.5f);
        }
        else if (range == 1 && !esAldeanoMago && !esAldeanoMago)
        {
            Invoke(nameof(Magos), 0.5f);
        }
        else if (range == 2)
        {
            Invoke(nameof(Nada), 0.5f);
        }
    }

  
    void Disparar()
    {
      
        puntoSaltar = 0;
        if (esAldeanoArquero)
        {
            Invoke(nameof(Disparar), manager.GetComponent<Recursos>().timeDisparoArqueros);
        }
        if (esAldeanoMago)
        {
            Invoke(nameof(Disparar), manager.GetComponent<Recursos>().timeDisparoMagos);
        }
      
        if (target != null && manager.GetComponent<Trinkets>().cincuentaSelect >= 1)
        {
            range = Random.Range(0, 100);
            if (range <= 0 + (manager.GetComponent<Recursos>().rangeDobleAtaqueCincuenta - 1))
            {
                Invoke(nameof(DisparoDoble), 0.25f);
            }
        }
        else if (target != null && manager.GetComponent<Trinkets>().glassSelect >= 1)
        {
            range = Random.Range(0, 100);
            if (range <= 0 + (manager.GetComponent<Recursos>().rangeDobleAtaqueGlass - 1))
            {
                Invoke(nameof(DisparoDoble), 0.25f);
            }
        }
        // cañones = vectorup random 15-25
        if (target != null)
        {
           
            range = Random.Range(0, 3);
            if (range == 0)
            {
                puntoSaltar = 1;
                transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.up * 2, 95 * Time.deltaTime);
            }
            if (esAldeanoArquero)
            {
                AudioManager.instance.PlaySFX("Arrow1");
                Vector2 direction = (target.transform.position + Vector3.up * Random.Range(4.25f, 6f)) - transform.position;
                
                transform.right = direction;
                
              
                if (manager.GetComponent<Trinkets>().goliathSelect >= 1)
                {
                    range = Random.Range(0, 100);
                    if (range <= 0 + manager.GetComponent<Recursos>().rangeFlechaGoliath - 1)
                    {
                        GameObject obj = ObjectPool.SpawnObject(proyPrefab, spawnPoint.transform.position + Vector3.up / 1.5f, Quaternion.identity);
                        obj.GetComponent<Rigidbody2D>().velocity = transform.right * Random.Range(5f, 10f);
                        obj.GetComponent<ProyectillMenosLag>().target = target.gameObject;
                        obj.GetComponent<ProyectillMenosLag>().daño = dañoArquero;
                        obj.GetComponent<ProyectillMenosLag>().puntoGoliath = 1;
                    }
                    else
                    {
                        GameObject obj2 = ObjectPool.SpawnObject(proyPrefab, spawnPoint.transform.position + Vector3.up / 2f, Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().velocity = transform.right * Random.Range(5f, 10f);
                        obj2.GetComponent<ProyectillMenosLag>().target = target.gameObject;
                        obj2.GetComponent<ProyectillMenosLag>().daño = dañoArquero;
                    }
                }
                else
                {
                    GameObject obj = ObjectPool.SpawnObject(proyPrefab, spawnPoint.transform.position + Vector3.up / 2f, Quaternion.identity);
                    obj.GetComponent<Rigidbody2D>().velocity = transform.right * Random.Range(5f, 10f);
                    obj.GetComponent<ProyectillMenosLag>().target = target.gameObject;
                    obj.GetComponent<ProyectillMenosLag>().daño = dañoArquero;
                }
                transform.rotation = Quaternion.Euler(Vector3.zero);

                //cosa de proyectil del que genera ligeramente mas lag
                //  obj.GetComponent<Proyectil>().target = target.transform;
                //  obj.GetComponent<Proyectil>().InitializeAnimationCurve(animCurve, axisCorrectionAnimCurve);
                //  obj.GetComponent<Proyectil>().daño = dañoArquero;



            }
            else if (esAldeanoMago)
            {
                AudioManager.instance.PlaySFX("Spell1");
                range = Random.Range(0, 2);
                if (range == 0)
                {
                  
                        GameObject obj = ObjectPool.SpawnObject(prefabBolaFuego, spawnPoint.transform.position + Vector3.up / 2f, Quaternion.identity);
                        //obj.GetComponent<Proyectil>().target = target.transform;
                        //obj.GetComponent<Proyectil>().InitializeAnimationCurve(animCurve, axisCorrectionAnimCurve);
                        //obj.GetComponent<Proyectil>().daño = dañoArquero;
                    
                   
                }
                else if (range == 1)
                {
                     GameObject obj = ObjectPool.SpawnObject(prefabEscarcha, spawnPoint.transform.position + Vector3.up / 2f, Quaternion.identity);
                        //obj.GetComponent<Proyectil>().target = target.transform;
                        //obj.GetComponent<Proyectil>().InitializeAnimationCurve(animCurve, axisCorrectionAnimCurve);
                        //obj.GetComponent<Proyectil>().daño = dañoArquero;
                 
                }
            
               
            }
           

        
        }
        if (target != null && target.gameObject.activeSelf == false)
        {
            target = null;
        }
          
      


    }
    void DisparoDoble()
    {
        if (esAldeanoArquero)
        {
            GameObject obj = ObjectPool.SpawnObject(proyPrefab, spawnPoint.transform.position + Vector3.up / 2f, Quaternion.identity);

            //obj.GetComponent<Proyectil>().target = target.transform;
            //obj.GetComponent<Proyectil>().InitializeAnimationCurve(animCurve, axisCorrectionAnimCurve);
            //obj.GetComponent<Proyectil>().daño = dañoArquero;
        }
        if (esAldeanoMago)
        {
            range = Random.Range(0, 2);
            if (range == 0)
            {

                GameObject obj = ObjectPool.SpawnObject(prefabBolaFuego, spawnPoint.transform.position + Vector3.up / 2f, Quaternion.identity);
                //obj.GetComponent<Proyectil>().target = target.transform;
                //obj.GetComponent<Proyectil>().InitializeAnimationCurve(animCurve, axisCorrectionAnimCurve);
                //obj.GetComponent<Proyectil>().daño = dañoArquero;


            }
            else if (range == 1)
            {
                GameObject obj = ObjectPool.SpawnObject(prefabEscarcha, spawnPoint.transform.position + Vector3.up / 2f, Quaternion.identity);
                //obj.GetComponent<Proyectil>().target = target.transform;
                //obj.GetComponent<Proyectil>().InitializeAnimationCurve(animCurve, axisCorrectionAnimCurve);
                //obj.GetComponent<Proyectil>().daño = dañoArquero;

            }
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

        if (vida <= 0)
        {
            AudioManager.instance.PlaySFX("DañoAliado");
            ObjectPool.ReturnObjectToPool(gameObject);
        }
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
        ObjectPool.SpawnObject(particulasMorir, transform.position, Quaternion.identity);
        manager.GetComponent<Recursos>().cantidadAldeanos -= 1;
        if (puntoPosIz >= 1)
        {
            manager.GetComponent<Recursos>().cantidadAldeanosIz -= 1;

        }
        if (puntoPosIz >= 1)
        {
            manager.GetComponent<Recursos>().cantidadAldeanosDer -= 1;
        }
        if (esAldeanoArquero)
        {
            manager.GetComponent<Recursos>().cantidadArquerosActual -= 1;
            manager.GetComponent<Recursos>().arqueriaDisminuirNumero += 1;
        }
        if (esAldeanoMago)
        {
            manager.GetComponent<Recursos>().cantidadMagosActual -= 1;
            manager.GetComponent<Recursos>().magosDisminuirNumero += 1;
        }
     
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
        if (collision.CompareTag("Escupitajo") && collision.GetComponent<ProyectillMenosLag>().puntoProyectilYaImpactado <= 0)
        {
            AudioManager.instance.PlaySFX("DañoAliado");
            collision.GetComponent<ProyectillMenosLag>().puntoProyectilYaImpactado = 1;
            vida -= 1;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
       
    }
}
