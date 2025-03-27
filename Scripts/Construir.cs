using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Construir : MonoBehaviour
{
    public TMP_Text textoCosteMaderaMuro;
    public int costeMaderaMuro;


    public TMP_Text textoCosteMaderaCasa;
    public int costeMaderaCasa;
    public int cantidadCasa;
    public GameObject casa;
    public int puntoCasa;

    public TMP_Text textoCosteMaderaArqueria;
    public TMP_Text textoCostePiedraArqueria;
    public int costeMaderaArqueria;
    public int costePiedraArqueria;
    public int cantidadArqueria;
    public GameObject arqueria;
    public int puntoArqueria;

    public TMP_Text textoCosteMaderaSerreria;
    public TMP_Text textoCostePiedraSerreria;
    public int costeMaderaSerreria;
    public int costePiedraSerreria;
    public int cantidadSerreria;
    public GameObject serreria;
    public int puntoSerreria;

    private Camera cam;
    private Vector3 mousePos;


    public GameObject indicacionCasa;
    public GameObject indicacionArqueria;
    public GameObject indicacionSerreria;

    public int puntoConstruir;

    public GameObject infoConstruir;
 
    void Start()
    {
      
        puntoCasa = 0;
      

        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

    }
    public void ConstruirCasa()
    {
     
            puntoCasa = 1;
       
      //  infoConstruir.SetActive(true);
     
    }
    public void ConstruirArqueria()
    {

        puntoArqueria = 1;

        //  infoConstruir.SetActive(true);

    }
    public void ConstruirSerreria()
    {

        puntoSerreria = 1;

        //  infoConstruir.SetActive(true);

    }



    void Update()
    {
        textoCosteMaderaCasa.text = costeMaderaCasa.ToString("F0");
        textoCosteMaderaArqueria.text = costeMaderaArqueria.ToString("F0");
        textoCostePiedraArqueria.text = costePiedraArqueria.ToString("F0");
        textoCosteMaderaSerreria.text = costeMaderaSerreria.ToString("F0");
        textoCostePiedraSerreria.text = costePiedraSerreria.ToString("F0");


        if (puntoCasa >= 1 && Input.GetKeyDown(KeyCode.Mouse1))
        {
          
            puntoCasa = 0;
            indicacionCasa.SetActive(false);
          // infoConstruir.SetActive(false);

        }
        if (puntoArqueria >= 1 && Input.GetKeyDown(KeyCode.Mouse1))
        {

            puntoArqueria = 0;
            indicacionArqueria.SetActive(false);
            // infoConstruir.SetActive(false);

        }
        if (puntoSerreria >= 1 && Input.GetKeyDown(KeyCode.Mouse1))
        {

            puntoSerreria = 0;
            indicacionSerreria.SetActive(false);
            // infoConstruir.SetActive(false);

        }


        if (puntoCasa >= 1)
        {
            puntoConstruir = 1;
     
         
        }
        else
        {
            puntoConstruir = 0;
        }

        if (puntoCasa >= 1)
        {
         
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 rotation = mousePos - transform.position;
            float rotz = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotz);
            indicacionCasa.SetActive(true);
            indicacionCasa.transform.position = mousePos + new Vector3(0, 0, 5);

        }
        if (puntoArqueria >= 1)
        {

            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 rotation = mousePos - transform.position;
            float rotz = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotz);
            indicacionArqueria.SetActive(true);
            indicacionArqueria.transform.position = mousePos + new Vector3(0, 0, 5);

        }
        if (puntoSerreria >= 1)
        {

            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 rotation = mousePos - transform.position;
            float rotz = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotz);
            indicacionSerreria.SetActive(true);
            indicacionSerreria.transform.position = mousePos + new Vector3(0, 0, 5);

        }
        if (puntoCasa >= 1 && Input.GetKeyDown(KeyCode.Mouse0) && indicacionCasa.GetComponent<VerifConstruir>().obstruccionOtraConstruccion != 1 && GetComponent<Recursos>().cantidadMadera >= costeMaderaCasa)
        {
            if (indicacionCasa.GetComponent<VerifConstruir>().puntoConstruirIz >= 1)
            {
                GetComponent<Recursos>().cantidadMadera -= costeMaderaCasa;
                cantidadCasa += 1;
                costeMaderaCasa += 5;
              //  infoConstruir.SetActive(false);

                puntoCasa = 0;
                GameObject obj = Instantiate(casa, indicacionCasa.transform.position, Quaternion.identity);
                obj.GetComponent<Casa>().posIz = 1;
                indicacionCasa.SetActive(false);
            }
            if (indicacionCasa.GetComponent<VerifConstruir>().puntoConstruirDer >= 1)
            {
                GetComponent<Recursos>().cantidadMadera -= costeMaderaCasa;
                cantidadCasa += 1;
                costeMaderaCasa += 5;
              //  infoConstruir.SetActive(false);
            
                puntoCasa = 0;
                GameObject obj = Instantiate(casa, indicacionCasa.transform.position, Quaternion.identity);
                obj.GetComponent<Casa>().posDer = 1;
                indicacionCasa.SetActive(false);
            }



        }
        if (puntoArqueria >= 1 && Input.GetKeyDown(KeyCode.Mouse0) && indicacionArqueria.GetComponent<VerifConstruir>().obstruccionOtraConstruccion != 1 && GetComponent<Recursos>().cantidadMadera >= costeMaderaArqueria && GetComponent<Recursos>().cantidadPiedra >= costePiedraArqueria)
        {
            if (indicacionArqueria.GetComponent<VerifConstruir>().puntoConstruirIz >= 1)
            {
                GetComponent<Recursos>().cantidadMadera -= costeMaderaArqueria;
                GetComponent<Recursos>().cantidadPiedra -= costePiedraArqueria;
                cantidadArqueria += 1;
                costeMaderaArqueria += 5;
                costePiedraArqueria += 3;
              //  infoConstruir.SetActive(false);

                puntoArqueria = 0;
                GameObject obj = Instantiate(arqueria, indicacionArqueria.transform.position, Quaternion.identity);
                obj.GetComponent<Arqueria>().posIz = 1;
                indicacionArqueria.SetActive(false);
            }
            if (indicacionArqueria.GetComponent<VerifConstruir>().puntoConstruirDer >= 1)
            {
                GetComponent<Recursos>().cantidadMadera -= costeMaderaArqueria;
                GetComponent<Recursos>().cantidadPiedra -= costePiedraArqueria;
                cantidadArqueria += 1;
                costeMaderaCasa += 5;
                costePiedraArqueria += 3;
              //  infoConstruir.SetActive(false);

                puntoArqueria = 0;
                GameObject obj = Instantiate(arqueria, indicacionArqueria.transform.position, Quaternion.identity);
                obj.GetComponent<Arqueria>().posDer = 1;
                indicacionArqueria.SetActive(false);
            }

        }
        if (puntoSerreria >= 1 && Input.GetKeyDown(KeyCode.Mouse0) && indicacionSerreria.GetComponent<VerifConstruir>().obstruccionOtraConstruccion != 1 && GetComponent<Recursos>().cantidadMadera >= costeMaderaSerreria && GetComponent<Recursos>().cantidadPiedra >= costePiedraSerreria)
        {
           
                GetComponent<Recursos>().cantidadMadera -= costeMaderaSerreria;
                GetComponent<Recursos>().cantidadPiedra -= costePiedraSerreria;
            cantidadSerreria += 1;
                costeMaderaSerreria += 5;
                costePiedraSerreria += 3;
            //  infoConstruir.SetActive(false);

            puntoSerreria = 0;
              Instantiate(serreria, indicacionSerreria.transform.position, Quaternion.identity);

            indicacionSerreria.SetActive(false);
            
           
        }

    }




}
