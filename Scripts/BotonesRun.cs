using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BotonesRun : MonoBehaviour
{
    public TMP_Text textoPopUpMas;
    public TMP_Text textoPopUpMenos;

    private Camera cam;

    public GameObject despliegueConstruicciones;
    public int botonDespliegueConstrucciones;

    public GameObject iconMejora;
    public GameObject mejoraPrefab;
    public int botonMejoraPunto;

    public GameObject popUpMas;
    public GameObject popUpMenos;
    public GameObject posicionMadera;


    public GameObject recuadroTrinkets;
    public GameObject botonTrinkets;
    public GameObject botonDonar;
   
    public GameObject memoriamSelect;
    public int puntoMemoriam;
    public GameObject babelSelect;
    public int puntoBabel;
    public GameObject gabrielSelect;
    public int puntoGabriel;
    public GameObject hourGlassSelect;
    public int puntoHourGlass;
    public GameObject necroticSelect;
    public int puntoNecrotic;
    public GameObject cincuentaSelect;
    public int puntoCincuenta;
    public GameObject glassSelect;
    public int puntoGlass;
    public GameObject goliathSelect;
    public int puntoGoliath;
    public GameObject bartholomewSelect;
    public int puntoBartholomew;

    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;

    public int range;
    void Start()
    {
        posicionMadera = GameObject.FindGameObjectWithTag("PosicionMadera");
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
    public void Trinkets1()
    {
        recuadroTrinkets.SetActive(true);
        botonTrinkets.SetActive(false);
        botonDonar.SetActive(false);
        range = Random.Range(0, 9);
        if (range == 0)
        {
           
                memoriamSelect.SetActive(true);
                memoriamSelect.transform.position = slot1.transform.position;
                puntoMemoriam = 1;
            
        }
        if (range == 1)
        {
            babelSelect.SetActive(true);
                babelSelect.transform.position = slot1.transform.position;
                puntoBabel = 1;

        }
        if (range == 2)
        {
            gabrielSelect.SetActive(true);
            gabrielSelect.transform.position = slot1.transform.position;
            puntoGabriel = 1;

        }
        if (range == 3)
        {
            hourGlassSelect.SetActive(true);
            hourGlassSelect.transform.position = slot1.transform.position;
            puntoHourGlass = 1;

        }
        if (range == 4)
        {
            necroticSelect.SetActive(true);
            necroticSelect.transform.position = slot1.transform.position;
            puntoNecrotic = 1;

        }
        if (range == 5)
        {
            cincuentaSelect.SetActive(true);
            cincuentaSelect.transform.position = slot1.transform.position;
            puntoCincuenta = 1;

        }
        if (range == 6)
        {
            glassSelect.SetActive(true);
            glassSelect.transform.position = slot1.transform.position;
            puntoGlass = 1;

        }
        if (range == 7)
        {
            goliathSelect.SetActive(true);
            goliathSelect.transform.position = slot1.transform.position;
            puntoGoliath = 1;

        }
        if (range == 8)
        {
            bartholomewSelect.SetActive(true);
            bartholomewSelect.transform.position = slot1.transform.position;
            puntoBartholomew = 1;

        }
        Invoke(nameof(Trinkets2), 0.03f);
    
    }
    public void Trinkets2()
    {
        recuadroTrinkets.SetActive(true);
        range = Random.Range(0, 8);
        if (range == 0)
        {
            if (puntoMemoriam <= 0)
            {
                memoriamSelect.SetActive(true);
                memoriamSelect.transform.position = slot2.transform.position;
                puntoMemoriam = 1;
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
        }
        if (range == 1)
        {
            if (puntoBabel <= 0)
            {
                babelSelect.SetActive(true);
                babelSelect.transform.position = slot2.transform.position;
                puntoBabel = 1;
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
        }
        if (range == 2)
        {
            if (puntoGabriel <= 0)
            {
                gabrielSelect.SetActive(true);
                gabrielSelect.transform.position = slot2.transform.position;
                puntoGabriel = 1;
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
          
        }
        if (range == 3)
        {
            if (puntoHourGlass <= 0)
            {
                hourGlassSelect.SetActive(true);
                hourGlassSelect.transform.position = slot2.transform.position;
                puntoHourGlass = 1;
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
           
        }
        if (range == 4)
        {
            if (puntoNecrotic <= 0)
            {
                necroticSelect.SetActive(true);
                necroticSelect.transform.position = slot2.transform.position;
                puntoNecrotic = 1;
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
           
        }
        if (range == 5)
        {
            if (puntoCincuenta <= 0)
            {
                cincuentaSelect.SetActive(true);
                cincuentaSelect.transform.position = slot2.transform.position;
                puntoCincuenta = 1;
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
          
        }
        if (range == 6)
        {
            if (puntoGlass <= 0)
            {
                glassSelect.SetActive(true);
                glassSelect.transform.position = slot2.transform.position;
                puntoGlass = 1;
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }

           

        }
        if (range == 7)
        {
            if (puntoGoliath <= 0)
            {
                goliathSelect.SetActive(true);
                goliathSelect.transform.position = slot2.transform.position;
                puntoGoliath = 1;
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
           

        }
        if (range == 8)
        {
            if (puntoGoliath <= 0)
            {
                bartholomewSelect.SetActive(true);
                bartholomewSelect.transform.position = slot2.transform.position;
                puntoBartholomew = 1;
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
           
        }
        Invoke(nameof(Trinkets3), 0.1f);
    }
    public void Trinkets3()
    {
        recuadroTrinkets.SetActive(true);
        range = Random.Range(0, 8);
        if (range == 0)
        {
            if (puntoMemoriam <= 0)
            {
                memoriamSelect.SetActive(true);
                memoriamSelect.transform.position = slot3.transform.position;
                puntoMemoriam = 1;
                Time.timeScale = 0;
            }
            else
            {
                Invoke(nameof(Trinkets3), 0.01f);
            }
        }
        if (range == 1)
        {
            if (puntoBabel <= 0)
            {
                babelSelect.SetActive(true);
                babelSelect.transform.position = slot3.transform.position;
                puntoBabel = 1;
                Time.timeScale = 0;
            }
            else
            {
                Invoke(nameof(Trinkets3), 0.01f);
            }
        }
        if (range == 2)
        {
            if (puntoGabriel <= 0)
            {
                gabrielSelect.SetActive(true);
                gabrielSelect.transform.position = slot3.transform.position;
                puntoGabriel = 1;
                Time.timeScale = 0;
            }
            else
            {
                Invoke(nameof(Trinkets3), 0.01f);
            }

        }
        if (range == 3)
        {
            if (puntoHourGlass <= 0)
            {
                hourGlassSelect.SetActive(true);
                hourGlassSelect.transform.position = slot3.transform.position;
                puntoHourGlass = 1;
                Time.timeScale = 0;
            }
            else
            {
                Invoke(nameof(Trinkets3), 0.01f);
            }

        }
        if (range == 4)
        {
            if (puntoNecrotic <= 0)
            {
                necroticSelect.SetActive(true);
                necroticSelect.transform.position = slot3.transform.position;
                puntoNecrotic = 1;
                Time.timeScale = 0;
            }
            else
            {
                Invoke(nameof(Trinkets3), 0.01f);
            }

        }
        if (range == 5)
        {
            if (puntoCincuenta <= 0)
            {
                cincuentaSelect.SetActive(true);
                cincuentaSelect.transform.position = slot3.transform.position;
                puntoCincuenta = 1;
                Time.timeScale = 0;
            }
            else
            {
                Invoke(nameof(Trinkets3), 0.01f);
            }

        }
        if (range == 6)
        {
            if (puntoGlass <= 0)
            {
                glassSelect.SetActive(true);
                glassSelect.transform.position = slot3.transform.position;
                puntoGlass = 1;
                Time.timeScale = 0;
            }
            else
            {
                Invoke(nameof(Trinkets3), 0.01f);
            }



        }
        if (range == 7)
        {
            if (puntoGoliath <= 0)
            {
                goliathSelect.SetActive(true);
                goliathSelect.transform.position = slot3.transform.position;
                puntoGoliath = 1;
                Time.timeScale = 0;
            }
            else
            {
                Invoke(nameof(Trinkets3), 0.01f);
            }


        }
        if (range == 8)
        {
            if (puntoGoliath <= 0)
            {
                bartholomewSelect.SetActive(true);
                bartholomewSelect.transform.position = slot3.transform.position;
                puntoBartholomew = 1;
                Time.timeScale = 0;
            }
            else
            {
                Invoke(nameof(Trinkets3), 0.01f);
            }

        }

    }
    public void DespliegueConstruccion()
    {
        if (botonDespliegueConstrucciones >= 1)
        {
            botonDespliegueConstrucciones = 0;
            despliegueConstruicciones.SetActive(false);
        }
        else
        {
            botonDespliegueConstrucciones = 1;
            despliegueConstruicciones.SetActive(true);
        }
    }
    public void BotonMejora()
    {
        if (botonMejoraPunto >= 1)
        {
            botonMejoraPunto = 0;
            iconMejora.SetActive(false);
        }
        else
        {
            botonMejoraPunto = 1;
            iconMejora.SetActive(true);
        }
    }
    public void BotonDonar()
    {
        if (GetComponent<Recursos>().cantidadVioleta >= 10)
        {
            popUpMenos.transform.position = posicionMadera.transform.position + Vector3.right * 90.25f + Vector3.down * 185.85f;
            popUpMas.transform.position = posicionMadera.transform.position + Vector3.right * 790.25f + Vector3.down * 200;
            popUpMenos.SetActive(false);
            popUpMenos.SetActive(true);
            popUpMas.SetActive(false);
            popUpMas.SetActive(true);
            textoPopUpMas.text = "+" + 10.ToString("F0");
            textoPopUpMenos.text = "-" + 10.ToString("F0");
            GetComponent<Recursos>().cantidadVioleta -= 10;
            GetComponent<Recursos>().violetasDonados += 10;
        }
       
    
    }
   
    void Update()
    {
        if (botonMejoraPunto >= 1 && Input.GetKeyDown(KeyCode.Mouse1))
        {
            botonMejoraPunto = 0;
            iconMejora.SetActive(false);
        }
        if (botonMejoraPunto >= 1 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(mejoraPrefab, cam.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 5), Quaternion.identity);
            botonMejoraPunto = 0;
            iconMejora.SetActive(false);
        }

        if (botonMejoraPunto >= 1)
        {
            iconMejora.transform.position = cam.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 5);
        }
       
    }
}
