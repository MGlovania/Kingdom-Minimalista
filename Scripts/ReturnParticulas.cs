using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnParticulas : MonoBehaviour
{

    public float time;

    public bool esFuego;
    public void OnEnable()
    {
        Invoke(nameof(Quitar), time);
        if (esFuego)
        {
            Invoke(nameof(DesactivarCol), 0.5f);
        }
    }
    void DesactivarCol()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        Invoke(nameof(ActivarCol), 1f);
    }
    void ActivarCol()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
    void Quitar()
    {
        ObjectPool.ReturnObjectToPool(gameObject);
    }
   
}
