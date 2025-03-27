using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Brote : MonoBehaviour
{
    public TMP_Text textoTime;
    public float time;

    public GameObject arbol;
    void OnEnable()
    {
        time = Random.Range(140, 160);
        Invoke(nameof(Brotar), time);
    }

    void Brotar()
    {
        ObjectPool.ReturnObjectToPool(gameObject);
        
     
    }
    private void OnDisable()
    {
        ObjectPool.SpawnObject(arbol, transform.position, Quaternion.identity);
     
    }
    void Update()
    {
        time -= Time.deltaTime;
        textoTime.text = time.ToString("F0");
    }
}
