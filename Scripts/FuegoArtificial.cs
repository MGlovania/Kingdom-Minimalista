using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuegoArtificial : MonoBehaviour
{
    public GameObject prefabParticulasHumo;
    public GameObject prefabParticulaFuegoArtificial;
    public GameObject prefabParticulaFuegoArtificial2;
    public int puntoMorir;
    public int range;

    public Rigidbody2D rb;

    
    void OnEnable()
    {
        range = Random.Range(0, 2);
        if (range == 0)
        {
            AudioManager.instance.PlaySFX("FuegoArtificialMecha");
        }
        else
        {
            AudioManager.instance.PlaySFX("FuegoArtificialMecha2");
        }
        puntoMorir = 0;
        Invoke(nameof(Explotar), Random.Range(1f,1.5f));
        Invoke(nameof(Humo), 0.25f);
    }
    void Humo()
    {
        if (puntoMorir <= 0)
        {
            Invoke(nameof(Humo), 0.25f);
            ObjectPool.SpawnObject(prefabParticulasHumo, transform.position, Quaternion.identity);
        }
     
    }
    void Explotar()
    {
      
        puntoMorir = 1;
        range = Random.Range(0, 2);
        if (range == 0)
        {
            AudioManager.instance.PlaySFX("FuegoArtificialExplotar");
            ObjectPool.SpawnObject(prefabParticulaFuegoArtificial, transform.position, Quaternion.identity);
        }
        else
        {
            AudioManager.instance.PlaySFX("FuegoArtificialExplotar2");
            ObjectPool.SpawnObject(prefabParticulaFuegoArtificial2, transform.position, Quaternion.identity);
        }
   
      
        ObjectPool.ReturnObjectToPool(gameObject);

    }
   
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.up, 4 * Time.deltaTime);
     
    }
}
