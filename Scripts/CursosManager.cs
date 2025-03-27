using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursosManager : MonoBehaviour
{
    public Texture2D cursorNormal;
    public Texture2D cursorHacha;
    public Texture2D cursorPico;
    public Texture2D cursorArco;
    void Start()
    {
        Cursor.SetCursor(cursorNormal, new Vector2(3, 1), CursorMode.Auto);
      
    }

    void Cambiar()
    {
        Cursor.SetCursor(cursorHacha, new Vector2(3, 1), CursorMode.Auto);

    }
    void Cambiar2()
    {
        Cursor.SetCursor(cursorPico, new Vector2(3, 1), CursorMode.Auto);

    }
    void Cambiar3()
    {
        Cursor.SetCursor(cursorArco, new Vector2(3, 1), CursorMode.Auto);

    }
    void Update()
    {
        
    }
}
