using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    void Start()
    {
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

 
   

    void Update()
    {
       

        Horizontal = Input.GetAxisRaw("Horizontal");

        Vertical = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) && Grounded || Input.GetKeyDown(KeyCode.W) && Grounded)
        {
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




    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal * speed, Rigidbody2D.velocity.y);
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Suelo"))
        {
            Grounded = true;
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
