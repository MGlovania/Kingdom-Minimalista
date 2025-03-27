using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roca : MonoBehaviour
{
  
    public Texture2D cursorPico;
    public Texture2D cursorNormal;
    public bool estaJugadorEnColision;
    public bool mouseEnter;

    public GameObject piedrita;
    void Start()
    {

    }
 

    void Update()
    {
        if (mouseEnter && estaJugadorEnColision)
        {
            Cursor.SetCursor(cursorPico, new Vector2(10, 10), CursorMode.Auto);
        }

    }
    private void OnMouseEnter()
    {
        mouseEnter = true;


    }
    private void OnMouseExit()
    {
        mouseEnter = false;
        Cursor.SetCursor(cursorNormal, new Vector2(10, 10), CursorMode.Auto);
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
        if (collision.CompareTag("Arbol"))
        {
            transform.position = new Vector3(transform.position.x + 3, transform.position.y, transform.position.z);
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
