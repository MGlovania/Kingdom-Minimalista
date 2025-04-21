using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilVisual : MonoBehaviour
{
    public Transform proyectilVisual;
    public Proyectil proyectil;

    public int puntoUpdatear;

    public Rigidbody2D rb;
    void OnEnable()
    {
    
      
    // Invoke(nameof(Punto), 0.2f);
    }
    void Punto()
    {
        puntoUpdatear = 1;
      
      
    }
    private void OnDisable()
    {
        puntoUpdatear = 0;
    }

    void Update()
    {
      //  if (puntoUpdatear >= 1)
       // {
        
        //    UpdateProyectilRotation();
       // }
        float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        proyectilVisual.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
    void UpdateProyectilRotation()
    {
      //  Vector3 proyectilMoveDir = proyectil.GetProyectilMoveDir();
       
     //   proyectilVisual.transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(proyectilMoveDir.y, proyectilMoveDir.x) * Mathf.Rad2Deg);
    }
}
