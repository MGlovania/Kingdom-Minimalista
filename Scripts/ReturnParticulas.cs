using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnParticulas : MonoBehaviour
{

    public float time;
    public void OnEnable()
    {
        Invoke(nameof(Quitar), time);
    }
    void Quitar()
    {
        ObjectPool.ReturnObjectToPool(gameObject);
    }
   
}
