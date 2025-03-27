using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
 

    public Transform Target;
    public float Sspeed;
    public Vector3 Pcamera;

    private void FixedUpdate()
    {

        Vector3 Dposition = Target.position + Pcamera;
        Vector3 Sposition = Vector3.Lerp(transform.position, Dposition, Sspeed * Time.deltaTime);

        transform.position = Sposition;

    }
}
