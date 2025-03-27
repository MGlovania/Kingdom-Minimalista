using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
 
    public Sprite sueloSprite1;
    public Sprite sueloSprite2;
    public Sprite sueloSprite3;

    public int range;
    void Start()
    {
        range = Random.Range(0, 4);
        if (range == 1)
        {
            GetComponent<SpriteRenderer>().sprite = sueloSprite1;
        }
        if (range == 2)
        {
            GetComponent<SpriteRenderer>().sprite = sueloSprite2;
        }
        if (range == 3)
        {
            GetComponent<SpriteRenderer>().sprite = sueloSprite3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
