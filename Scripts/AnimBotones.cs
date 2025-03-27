using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimBotones : MonoBehaviour
{
   

    public Animator anim;

    public GameObject prefabSonido;
    public bool esConSonido;

    public float time;

    public bool esBotonHover;
    void Start()
    {

    }

    private void OnMouseEnter()
    {
        if (esConSonido)
        {
            ObjectPool.SpawnObject(prefabSonido, transform.position, Quaternion.identity);
        }
        if (esBotonHover)
        {
            anim.SetBool("Animacion", true);
            Invoke(nameof(QuitarAnim), time);
        }
      
    }
    public void Animacion()
    {
        anim.SetBool("Animacion", true);
        Invoke(nameof(QuitarAnim), time);
    }

    void QuitarAnim()
    {
        anim.SetBool("Animacion", false);
    }
    void Update()
    {

    }
}
