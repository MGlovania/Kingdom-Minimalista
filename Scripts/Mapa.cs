using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapa : MonoBehaviour
{

    public GameObject arbol;
    public GameObject roca;
    public GameObject plata;
    public GameObject oro;
    public Vector3 correrseArboles;
    public Vector3 correrseRocas;
    public Vector3 corrersePlata;
    public Vector3 correrseOro;

    public int cantidadArboles;
    public int cantidadArbolesSpawneadosIz;
    public int cantidadArbolesSpawneadosDer;
    public int cantidadPiedras;
    public int cantidadPiedrasSpawneadosIz;
    public int cantidadPiedrasSpawneadosDer;
    public int cantidadPlata;
    public int cantidadPlataSpawneadosIz;
    public int cantidadPlataSpawneadosDer;
    public int cantidadOro;
    public int cantidadOroSpawneadosIz;
    public int cantidadOroSpawneadosDer;

    public int verifSpawnDeMapa;
    void Start()
    {
       
     //   Invoke(nameof(Arboleda), 0.2f);
     //   Invoke(nameof(Arboleda2), 0.4f);
       // Invoke(nameof(Arboleda3), 0.6f);
       // Invoke(nameof(Arboleda4), 0.8f);
      //  Invoke(nameof(VerifMapeado), 1f);
    }
    void VerifMapeado()
    {
        //Invoke(nameof(VerifMapeado), 0.1f);
        //verifSpawnDeMapa = 1;
        //if (verifSpawnDeMapa >= 1)
        //{
        //    if (cantidadArbolesSpawneados < cantidadArboles)
        //    {
        //        for (int i = 0; i < cantidadArboles; i++)
        //        {

        //            GameObject arb = Instantiate(arbol, new Vector3(Random.Range(-55.8f, 55), -1.092f, 0), Quaternion.identity);
        //            cantidadArbolesSpawneados += 1;
        //            correrseArboles += new Vector3(Random.Range(7f, 12.5f), 0, 0);

        //        }
        //    }
        //    if (cantidadPiedrasSpawneados < cantidadPiedras)
        //    {
        //        for (int i = 0; i < cantidadPiedras; i++)
        //        {


        //            GameObject roc = Instantiate(roca, new Vector3(Random.Range(-55.8f, 55), -1.092f, 0), Quaternion.identity);
        //            cantidadPiedrasSpawneados += 1;
        //            correrseRocas += new Vector3(Random.Range(15f, 21.5f), 0, 0);


        //        }
        //    }
            //if (cantidadPlataSpawneados < cantidadPlata)
            //{
            //    for (int i = 0; i < cantidadPlata; i++)
            //    {

            //        GameObject plat = Instantiate(plata, new Vector3(Random.Range(-55.8f, 55), -1.092f, 0), Quaternion.identity);
            //        cantidadPlataSpawneados += 1;
            //        corrersePlata += new Vector3(Random.Range(23f, 28.5f), 0, 0);

            //    }
            //}
            //if (cantidadOroSpawneados < cantidadOro)
            //{

            //    for (int i = 0; i < cantidadOro; i++)
            //    {


            //        GameObject or = Instantiate(oro, new Vector3(Random.Range(-55.8f, 55), -1.092f, 0), Quaternion.identity);
            //        cantidadOroSpawneados += 1;
            //        correrseOro += new Vector3(Random.Range(30f, 38.5f), 0, 0);


            //    }
            //}


        //}
    }


    void Update()
    {
      
    }
    //void Arboleda()
    //{

    //    for (int i = 0; i < cantidadArboles; i++)
    //    {

    //        GameObject arb = Instantiate(arbol, new Vector3(Random.Range(-55.8f, 55), -1.092f, 0), Quaternion.identity);
    //        cantidadArbolesSpawneados += 1;
    //        correrseArboles += new Vector3(Random.Range(7f, 12.5f), 0, 0);
          
    //    }
    //}
    //void Arboleda2()
    //{

    //    for (int i = 0; i < cantidadPiedras; i++)
    //    {

      
    //        GameObject roc = Instantiate(roca, new Vector3(Random.Range(-55.8f, 55), -1.092f, 0), Quaternion.identity);
    //        cantidadPiedrasSpawneados += 1;
    //        correrseRocas += new Vector3(Random.Range(15f, 21.5f), 0, 0);
         

    //    }
    //}
    //void Arboleda3()
    //{

    //    for (int i = 0; i < cantidadPlata; i++)
    //    {
      
    //        GameObject plat = Instantiate(plata, new Vector3(Random.Range(-55.8f, 55), -1.092f, 0), Quaternion.identity);
    //        cantidadPlataSpawneados += 1;
    //        corrersePlata += new Vector3(Random.Range(23f, 28.5f), 0, 0);
       
    //    }
    //}
    //void Arboleda4()
    //{

    //    for (int i = 0; i < cantidadOro; i++)
    //    {

        
    //        GameObject or = Instantiate(oro, new Vector3(Random.Range(-55.8f, 55), -1.092f, 0), Quaternion.identity);
    //        cantidadOroSpawneados += 1;
    //        correrseOro += new Vector3(Random.Range(30f, 38.5f), 0, 0);


    //    }
    //}
}
