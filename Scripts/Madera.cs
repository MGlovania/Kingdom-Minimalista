using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Madera : MonoBehaviour
{
    public Texture2D cursorHacha;
    public Texture2D cursorPico;
    public GameObject pj;

    public bool esMadera;
    void OnEnable()
    {
    
      
        pj = GameObject.FindGameObjectWithTag("Player");
    
        Invoke(nameof(Quitar), 0.75f);
       
    }
   
    private void OnMouseEnter()
    {
        if (esMadera)
        {
            Cursor.SetCursor(cursorHacha, new Vector2(3, 1), CursorMode.Auto);
        }
        else
        {
            Cursor.SetCursor(cursorPico, new Vector2(3, 1), CursorMode.Auto);
        }
      
    }
   
    void Quitar()
    {
        ObjectPool.ReturnObjectToPool(gameObject);
    }
    void Update()
    {
       
    
    }
  
}
