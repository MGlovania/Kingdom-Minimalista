using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilVisual : MonoBehaviour
{
    public Transform proyectilVisual;
    public Proyectil proyectil;

    public int puntoUpdatear;
    void OnEnable()
    {
        puntoUpdatear = 1;
       Invoke(nameof(Punto), 0.06f);
       Invoke(nameof(UpdateProyectilRotation), 0.06f);
    }
    void Punto()
    {
        if (puntoUpdatear >= 1)
        {
            Invoke(nameof(Punto), 0.06f);
            Invoke(nameof(UpdateProyectilRotation), 0.06f);
        }
   
    }
    private void OnDisable()
    {
        puntoUpdatear = 0;
    }

    void Update()
    {
       // UpdateProyectilRotation();
    }
    void UpdateProyectilRotation()
    {
        Vector3 proyectilMoveDir = proyectil.GetProyectilMoveDir();

        proyectilVisual.transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(proyectilMoveDir.y, proyectilMoveDir.x) * Mathf.Rad2Deg);
    }
}
