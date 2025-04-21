using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
  
 

    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    private float Vertical;

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

    public int range;

    public bool Grounded;
    public float Jumpforce;
    public int puntoGrass;

    public int vida;
    public GameObject armadura;

    public TMP_Text textoCantidadArmadura;
    public int cantidadArmadura;
    public int puntoMorir;

    public GameObject manager;
    public GameObject menuMorir;

    public GameObject vidaMostrar;
    public GameObject vidaRomper;
    public GameObject vidaRomper2;
    public GameObject particulasMorir;
    public GameObject musicManager;
    void Start()
    {
        musicManager = GameObject.FindGameObjectWithTag("MusicManager");
        vida = 1;
        cantidadArmadura = 0;
        Rigidbody2D = GetComponent<Rigidbody2D>();
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
    }


    void IrQuitandoMorir()
    {
        if (Time.timeScale < 1)
        {
            musicManager.GetComponent<AudioSource>().pitch += 0.08f;
            Time.timeScale += 0.08f;
            Invoke(nameof(IrQuitandoMorir), 0.15f);
        }
        else
        {
            musicManager.GetComponent<AudioSource>().pitch = 1;
            Time.timeScale = 1;
            Invoke(nameof(MostrarMenuMorir), 1.1f);
        }
    }
    void MostrarMenuMorir()
    {
        Time.timeScale = 0;
        menuMorir.SetActive(true);
    }

    void Update()
    {
        if (cantidadArmadura >= 1)
        {
            armadura.SetActive(true);
        }
        else
        {
            armadura.SetActive(false);
        }
        textoCantidadArmadura.text = cantidadArmadura.ToString("F0");
        if (vida <= 0 && puntoMorir <= 0)
        {
            manager.GetComponent<BotonesRun>().puntoMorirPlayerCancelarEscape = 1;
            puntoMorir = 1;
            Time.timeScale = 0.05f;
            speed = 0;
            Jumpforce = 0;
            Invoke(nameof(IrQuitandoMorir), 0.15f);
            vidaMostrar.SetActive(false);
            vidaRomper.SetActive(true);
            vidaRomper2.SetActive(true);
            ObjectPool.SpawnObject(particulasMorir, transform.position, Quaternion.identity);
            cuerpo1.GetComponent<SpriteRenderer>().sprite = null;
            cuerpo2.GetComponent<SpriteRenderer>().sprite = null;
            musicManager.GetComponent<AudioSource>().pitch = 0.1f;
        }

        Horizontal = Input.GetAxisRaw("Horizontal");

        Vertical = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) && Grounded || Input.GetKeyDown(KeyCode.W) && Grounded)
        {
            AudioManager.instance.PlaySFX("Saltar");
            //  Grounded = false;
            Jump();
            //Invoke(nameof(VolverATenerSlato), 2);
        }

    }
    void VolverATenerSlato()
    {
        Grounded = true;
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * Jumpforce );


    }


    void RuidoGrass()
    {
        range = Random.Range(0, 2);
        if (range == 0)
        {
            AudioManager.instance.PlaySFX("Grass1");
        }
        else
        {
            AudioManager.instance.PlaySFX("Grass2");
        }
        Invoke(nameof(QuitarRuidoGrass), 0.5f);
    }
    void QuitarRuidoGrass()
    {
        puntoGrass = 0;
    }

    private void FixedUpdate()
    {
        if(Horizontal > 0 && Grounded && puntoGrass <= 0 || Horizontal < 0 && Grounded && puntoGrass <= 0)
        {
            puntoGrass = 1;
            Invoke(nameof(RuidoGrass), 0.05f);        
          
        }
        Rigidbody2D.velocity = new Vector2(Horizontal * speed, Rigidbody2D.velocity.y);
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Suelo"))
        {
            Grounded = true;
        }
        if (collision.CompareTag("Enemigo"))
        {         
            AudioManager.instance.PlaySFX("DañoAliado");
            if (puntoMorir <= 0)
            {
                ObjectPool.ReturnObjectToPool(collision.gameObject);
            }
         
            if (cantidadArmadura >= 1)
            {
                cantidadArmadura -= 1;
            }
            else
            {
                vida -= 1;
            }
        }
      
        if (collision.CompareTag("Escupitajo") && collision.GetComponent<ProyectillMenosLag>().puntoProyectilYaImpactado <= 0)
        {
            AudioManager.instance.PlaySFX("DañoAliado");
            if (cantidadArmadura >= 1)
            {
                cantidadArmadura -= 1;
            }
            else
            {
                vida -= 1;
            }

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Suelo"))
        {
            Grounded = false;
        }
    }
}
