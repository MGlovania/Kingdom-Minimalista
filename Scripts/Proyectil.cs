using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{

    public Transform target;
  
    public float moveSpeed;

    public AnimationCurve animCurve;
    public AnimationCurve axisCorrectionAnimCurve;

    public Vector3 trajectoryStartPoint;

    public Vector3 moveDir;

    public int daño;

    public Vector3 v3;

    public int puntoUpdatear;

    public GameObject prefabParticulaFlecha;
    public GameObject particularBolaFuego;
    public GameObject particulaBolaFuegoChocar;
    public GameObject fuego;
    public GameObject particulaEscarcha;
    public GameObject particulEscarchaChocar;
    public GameObject escarcha;

    public bool esEscupitajo;

    public int puntoProyectilYaImpactado;

    public bool esFlecha;
    public bool esBolaFuego;
    public bool esEscarcha;

    public int puntoMorir;

    public GameObject manager;
    public int range;
    void OnEnable()
    {

        transform.localScale = new Vector3(1, 1, transform.localScale.z);

        manager = GameObject.FindGameObjectWithTag("Manager");
        puntoMorir = 0;
        puntoProyectilYaImpactado = 0;
        puntoUpdatear = 0;
        trajectoryStartPoint = transform.position;
        moveSpeed = 6;
        if (esEscupitajo)
        {
            moveSpeed = 4;
        }
        Invoke(nameof(Updatear), 0.1f);
        Invoke(nameof(UpdatePosition), 0.15f);
        if (esBolaFuego)
        {
            Invoke(nameof(ParticulaBolaFuego), 0.25f);
        }
        if (esEscarcha)
        {
            Invoke(nameof(ParticulaEscarcha), 0.25f);
        }
        if (manager.GetComponent<Trinkets>().goliathSelect >= 1)
        {
            range = Random.Range(0, 2);
            if (range <= 0 + manager.GetComponent<Recursos>().rangeFlechaGoliath - 1)
            {
                transform.localScale = new Vector3(transform.localScale.x + 2f, transform.localScale.y + 2f, transform.localScale.z);
                daño *= 5;
            }
        }
     
    }
    void ParticulaBolaFuego()
    {
        if (puntoMorir <= 0)
        {
            Invoke(nameof(ParticulaBolaFuego), 0.25f);
            ObjectPool.SpawnObject(particularBolaFuego, transform.position, Quaternion.identity);
        }
      
    }
    void ParticulaEscarcha()
    {
        if (puntoMorir <= 0)
        {
            Invoke(nameof(ParticulaEscarcha), 0.25f);
            ObjectPool.SpawnObject(particulaEscarcha, transform.position, Quaternion.identity);
        }
     
    }
    void Updatear()
    {
       
        puntoUpdatear = 1;
        if (esEscupitajo)
        {
            v3 = target.transform.position + new Vector3(Random.Range(-2.5f, 2.5f), 0, 0);
        }
        else
        {
            v3 = target.transform.position + new Vector3(Random.Range(-0.1f, 0.3f), 0, 0);
        }
    
    }
    private void OnDisable()
    {
        if (esBolaFuego)
        {
            ObjectPool.SpawnObject(particulaBolaFuegoChocar, transform.position, Quaternion.identity);
            ObjectPool.SpawnObject(fuego, transform.position, Quaternion.identity);
        }
        else if (esEscarcha)
        {
            ObjectPool.SpawnObject(particulEscarchaChocar, transform.position, Quaternion.identity);
            ObjectPool.SpawnObject(escarcha, transform.position, Quaternion.identity);
        }
        else
        {
            ObjectPool.SpawnObject(prefabParticulaFlecha, transform.position, Quaternion.identity);
        }
        puntoMorir = 1;
        esEscupitajo = false;
        puntoUpdatear = 0;
    }
    private void Update()
    {
      
        if (puntoUpdatear >= 1)
        {
            UpdatePosition();
        }
        
       // Vector3 moveNormalized = (target.position - transform.position).normalized;
       // transform.position += moveNormalized * moveSpeed * Time.deltaTime;
        if (target != null && Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            ObjectPool.ReturnObjectToPool(gameObject);
        }
       
    }
    public void InitializeAnimationCurve(AnimationCurve animCurve, AnimationCurve axisCorrectionAnimCurve)
    {
        this.animCurve = animCurve;
        this.axisCorrectionAnimCurve = axisCorrectionAnimCurve;
    }
    private void UpdatePosition()
    {
      
        if (v3 != null)
        {
            Vector3 trajectoryRange = v3 - trajectoryStartPoint;
            if (trajectoryRange.x < 0)
            {
               
                moveSpeed = -6;
                if (esEscupitajo)
                {
                    moveSpeed = -4;
                }
            }
            float nextPositionX = transform.position.x + moveSpeed * Time.deltaTime;
            float nextPositionXNormalized = (nextPositionX - trajectoryStartPoint.x) / trajectoryRange.x;
            float nextPositionYNormalized = animCurve.Evaluate(nextPositionXNormalized);
            float nextPositionYCorrectionNormalized = axisCorrectionAnimCurve.Evaluate(nextPositionXNormalized);
            float nextPositionYCorrectionAbsolute = nextPositionYCorrectionNormalized * trajectoryRange.y;
            float nextPositionY = trajectoryStartPoint.y + nextPositionYNormalized * 3.5f + nextPositionYCorrectionAbsolute;

            Vector3 newPosition = new Vector3(nextPositionX, nextPositionY, 0);

            moveDir = newPosition - transform.position;
            

            transform.position = newPosition;
        }
       
    }
    public Vector3 GetProyectilMoveDir()
    {
        return moveDir;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Suelo"))
        {
            ObjectPool.ReturnObjectToPool(gameObject);
        }
       
    }
}
