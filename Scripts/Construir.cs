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

    public TMP_Text textoCosteMaderaPiedreria;
    public TMP_Text textoCostePiedraPiedreria;
    public int costeMaderaPiedreria;
    public int costePiedraPiedreria;
    public int cantidadPiedreria;
    public GameObject piedreria;
    public int puntoPiedreria;

    public TMP_Text textoCostePiedraTorreMagos;
    public TMP_Text textoCostePlataTorreMagos;
    public int costePiedraTorreMagos;
    public int costePlataTorreMagos;
    public int cantidadTorreMagos;
    public GameObject torreMagos;
    public int puntoTorreMagos;

    public TMP_Text textoCostePiedraForja;
    public TMP_Text textoCostePlataForja;
    public int costePiedraForja;
    public int costePlataForja;
    public int cantidadForja;
    public GameObject forja;
    public int puntoForja;

    private Camera cam;
    private Vector3 mousePos;


    public GameObject indicacionCasa;
    public GameObject indicacionArqueria;
    public GameObject indicacionSerreria;
    public GameObject indicacionPiedreria;
    public GameObject indicacionTorreMagos;
    public GameObject indicacionForja;

    public int puntoConstruir;

    public GameObject infoConstruir;
 
    void Start()
    {
      
        puntoCasa = 0;
      

        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

    }
    public void ConstruirCasa()
    {
        AudioManager.instance.PlaySFX("Click");

        puntoCasa = 1;
       
      //  infoConstruir.SetActive(true);
     
    }
    public void ConstruirArqueria()
    {
        AudioManager.instance.PlaySFX("Click");
        puntoArqueria = 1;

        //  infoConstruir.SetActive(true);

    }
    public void ConstruirSerreria()
    {
        AudioManager.instance.PlaySFX("Click");
        puntoSerreria = 1;

        //  infoConstruir.SetActive(true);

    }
    public void ConstruirPiedreria()
    {
        AudioManager.instance.PlaySFX("Click");
        puntoPiedreria = 1;

        //  infoConstruir.SetActive(true);

    }
    public void ConstruirTorreMagos()
    {
        AudioManager.instance.PlaySFX("Click");

        puntoTorreMagos = 1;

        //  infoConstruir.SetActive(true);

    }
    public void ConstruirForja()
    {
        AudioManager.instance.PlaySFX("Click");

        puntoForja = 1;

        //  infoConstruir.SetActive(true);

    }



    void Update()
    {
        textoCosteMaderaMuro.text = costeMaderaMuro.ToString("F0");
        textoCosteMaderaCasa.text = costeMaderaCasa.ToString("F0");
        textoCosteMaderaArqueria.text = costeMaderaArqueria.ToString("F0");
        textoCostePiedraArqueria.text = costePiedraArqueria.ToString("F0");
        textoCosteMaderaSerreria.text = costeMaderaSerreria.ToString("F0");
        textoCostePiedraSerreria.text = costePiedraSerreria.ToString("F0");
        textoCosteMaderaPiedreria.text = costeMaderaPiedreria.ToString("F0");
        textoCostePiedraPiedreria.text = costePiedraPiedreria.ToString("F0");
        textoCostePiedraTorreMagos.text = costePiedraTorreMagos.ToString("F0");
        textoCostePlataTorreMagos.text = costePlataTorreMagos.ToString("F0");
        textoCostePiedraForja.text = costePiedraForja.ToString("F0");
        textoCostePlataForja.text = costePlataForja.ToString("F0");


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
        if (puntoPiedreria >= 1 && Input.GetKeyDown(KeyCode.Mouse1))
        {

            puntoPiedreria = 0;
            indicacionPiedreria.SetActive(false);
            // infoConstruir.SetActive(false);

        }
        if (puntoTorreMagos >= 1 && Input.GetKeyDown(KeyCode.Mouse1))
        {

            puntoTorreMagos = 0;
            indicacionTorreMagos.SetActive(false);
            // infoConstruir.SetActive(false);

        }
        if (puntoForja >= 1 && Input.GetKeyDown(KeyCode.Mouse1))
        {

            puntoForja = 0;
            indicacionForja.SetActive(false);
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
        if (puntoPiedreria >= 1)
        {

            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 rotation = mousePos - transform.position;
            float rotz = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotz);
            indicacionPiedreria.SetActive(true);
            indicacionPiedreria.transform.position = mousePos + new Vector3(0, 0, 5);

        }
        if (puntoTorreMagos >= 1)
        {

            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 rotation = mousePos - transform.position;
            float rotz = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotz);
            indicacionTorreMagos.SetActive(true);
            indicacionTorreMagos.transform.position = mousePos + new Vector3(0, 0, 5);

        }
        if (puntoForja >= 1)
        {

            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 rotation = mousePos - transform.position;
            float rotz = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotz);
            indicacionForja.SetActive(true);
            indicacionForja.transform.position = mousePos + new Vector3(0, 0, 5);

        }
        if (puntoCasa >= 1 && Input.GetKeyDown(KeyCode.Mouse0) && indicacionCasa.GetComponent<VerifConstruir>().obstruccionOtraConstruccion != 1 && GetComponent<Recursos>().cantidadMadera >= costeMaderaCasa)
        {
            if (indicacionCasa.GetComponent<VerifConstruir>().puntoConstruirIz >= 1)
            {
                AudioManager.instance.PlaySFX("Construir");
                GetComponent<Recursos>().cantidadMadera -= costeMaderaCasa;
                cantidadCasa += 1;
                costeMaderaCasa += 10;
              //  infoConstruir.SetActive(false);

                puntoCasa = 0;
                GameObject obj = Instantiate(casa, indicacionCasa.transform.position, Quaternion.identity);
                obj.GetComponent<Casa>().posIz = 1;
                indicacionCasa.SetActive(false);
                GetComponent<Recursos>().cantidadConstruccionesTotales += 1;
            }
            if (indicacionCasa.GetComponent<VerifConstruir>().puntoConstruirDer >= 1)
            {
                AudioManager.instance.PlaySFX("Construir");
                GetComponent<Recursos>().cantidadMadera -= costeMaderaCasa;
                cantidadCasa += 1;
                costeMaderaCasa += 10;
              //  infoConstruir.SetActive(false);
            
                puntoCasa = 0;
                GameObject obj = Instantiate(casa, indicacionCasa.transform.position, Quaternion.identity);
                obj.GetComponent<Casa>().posDer = 1;
                indicacionCasa.SetActive(false);
                GetComponent<Recursos>().cantidadConstruccionesTotales += 1;
            }



        }
        else if (puntoArqueria >= 1 && Input.GetKeyDown(KeyCode.Mouse0) && indicacionArqueria.GetComponent<VerifConstruir>().obstruccionOtraConstruccion != 1 && GetComponent<Recursos>().cantidadMadera >= costeMaderaArqueria && GetComponent<Recursos>().cantidadPiedra >= costePiedraArqueria)
        {
            if (indicacionArqueria.GetComponent<VerifConstruir>().puntoConstruirIz >= 1)
            {
                AudioManager.instance.PlaySFX("Construir");
                GetComponent<Recursos>().cantidadMadera -= costeMaderaArqueria;
                GetComponent<Recursos>().cantidadPiedra -= costePiedraArqueria;
                cantidadArqueria += 1;
                costeMaderaArqueria += 10;
                costePiedraArqueria += 6;
              //  infoConstruir.SetActive(false);

                puntoArqueria = 0;
                GameObject obj = Instantiate(arqueria, indicacionArqueria.transform.position, Quaternion.identity);
                obj.GetComponent<Arqueria>().posIz = 1;
                indicacionArqueria.SetActive(false);
                GetComponent<Recursos>().cantidadConstruccionesTotales += 1;
            }
            if (indicacionArqueria.GetComponent<VerifConstruir>().puntoConstruirDer >= 1)
            {
                AudioManager.instance.PlaySFX("Construir");
                GetComponent<Recursos>().cantidadMadera -= costeMaderaArqueria;
                GetComponent<Recursos>().cantidadPiedra -= costePiedraArqueria;
                cantidadArqueria += 1;
                costeMaderaCasa += 10;
                costePiedraArqueria += 6;
              //  infoConstruir.SetActive(false);

                puntoArqueria = 0;
                GameObject obj = Instantiate(arqueria, indicacionArqueria.transform.position, Quaternion.identity);
                obj.GetComponent<Arqueria>().posDer = 1;
                indicacionArqueria.SetActive(false);
                GetComponent<Recursos>().cantidadConstruccionesTotales += 1;
            }

        }
        else if(puntoSerreria >= 1 && Input.GetKeyDown(KeyCode.Mouse0) && indicacionSerreria.GetComponent<VerifConstruir>().obstruccionOtraConstruccion != 1 && GetComponent<Recursos>().cantidadMadera >= costeMaderaSerreria && GetComponent<Recursos>().cantidadPiedra >= costePiedraSerreria)
        {
            if (indicacionSerreria.GetComponent<VerifConstruir>().puntoConstruirIz >= 1 || indicacionSerreria.GetComponent<VerifConstruir>().puntoConstruirDer >= 1)
            {
                AudioManager.instance.PlaySFX("Construir");
                GetComponent<Recursos>().cantidadConstruccionesTotales += 1;
                GetComponent<Recursos>().cantidadMadera -= costeMaderaSerreria;
                GetComponent<Recursos>().cantidadPiedra -= costePiedraSerreria;
                cantidadSerreria += 1;
                costeMaderaSerreria += 10;
                costePiedraSerreria += 6;
                //  infoConstruir.SetActive(false);

                puntoSerreria = 0;
                Instantiate(serreria, indicacionSerreria.transform.position, Quaternion.identity);

                indicacionSerreria.SetActive(false);
            }
         


        }
        else  if (puntoPiedreria >= 1 && Input.GetKeyDown(KeyCode.Mouse0) && indicacionPiedreria.GetComponent<VerifConstruir>().obstruccionOtraConstruccion != 1 && GetComponent<Recursos>().cantidadMadera >= costeMaderaPiedreria && GetComponent<Recursos>().cantidadPiedra >= costePiedraPiedreria)
        {
            if (indicacionPiedreria.GetComponent<VerifConstruir>().puntoConstruirIz >= 1 || indicacionPiedreria.GetComponent<VerifConstruir>().puntoConstruirDer >= 1)
            {
                AudioManager.instance.PlaySFX("Construir");
                GetComponent<Recursos>().cantidadConstruccionesTotales += 1;
                GetComponent<Recursos>().cantidadMadera -= costeMaderaPiedreria;
                GetComponent<Recursos>().cantidadPiedra -= costePiedraPiedreria;
                cantidadPiedreria += 1;
                costeMaderaPiedreria += 15;
                costePiedraPiedreria += 12;
                //  infoConstruir.SetActive(false);

                puntoPiedreria = 0;
                Instantiate(piedreria, indicacionPiedreria.transform.position, Quaternion.identity);

                indicacionPiedreria.SetActive(false);

            }


        }
        else if (puntoTorreMagos >= 1 && Input.GetKeyDown(KeyCode.Mouse0) && indicacionTorreMagos.GetComponent<VerifConstruir>().obstruccionOtraConstruccion != 1 && GetComponent<Recursos>().cantidadPiedra >= costePiedraTorreMagos && GetComponent<Recursos>().cantidadPlata >= costePlataTorreMagos)
        {
            if (indicacionTorreMagos.GetComponent<VerifConstruir>().puntoConstruirIz >= 1 || indicacionTorreMagos.GetComponent<VerifConstruir>().puntoConstruirDer >= 1)
            {
                AudioManager.instance.PlaySFX("Construir");
                GetComponent<Recursos>().cantidadConstruccionesTotales += 1;
                GetComponent<Recursos>().cantidadPiedra -= costePiedraTorreMagos;
                GetComponent<Recursos>().cantidadPlata -= costePlataTorreMagos;
                cantidadTorreMagos += 1;
                costePiedraTorreMagos += 20;
                costePlataTorreMagos += 10;
                //  infoConstruir.SetActive(false);

                puntoTorreMagos = 0;
                Instantiate(torreMagos, indicacionTorreMagos.transform.position, Quaternion.identity);

                indicacionTorreMagos.SetActive(false);



            }


        }
        else if (puntoForja >= 1 && Input.GetKeyDown(KeyCode.Mouse0) && indicacionForja.GetComponent<VerifConstruir>().obstruccionOtraConstruccion != 1 && GetComponent<Recursos>().cantidadPiedra >= costePiedraForja && GetComponent<Recursos>().cantidadPlata >= costePlataForja)
        {
            if (indicacionForja.GetComponent<VerifConstruir>().puntoConstruirIz >= 1 || indicacionForja.GetComponent<VerifConstruir>().puntoConstruirDer >= 1)
            {
                AudioManager.instance.PlaySFX("Construir");
                GetComponent<Recursos>().cantidadConstruccionesTotales += 1;
                GetComponent<Recursos>().cantidadPiedra -= costePiedraForja;
                GetComponent<Recursos>().cantidadPlata -= costePlataForja;
                cantidadForja += 1;
                costePiedraForja += 25;
                costePlataForja += 20;
                //  infoConstruir.SetActive(false);

                puntoForja = 0;
                Instantiate(forja, indicacionForja.transform.position, Quaternion.identity);

                indicacionForja.SetActive(false);



            }


        }

    }




}
