using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
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
    public GameObject textoMemoriamLvl1;
    public GameObject textoMemoriamLvl2;
    public GameObject babelSelect;
    public int puntoBabel;
    public GameObject textoBabelLvl1;
    public GameObject textoBabelLvl2;
    public GameObject gabrielSelect;
    public int puntoGabriel;
    public GameObject textoGabrielLvl1;
    public GameObject textoGabrielLvl2;
    public GameObject hourGlassSelect;
    public int puntoHourGlass;
    public GameObject textoHourglassLvl1;
    public GameObject textoHourglassLvl2;
    public GameObject necroticSelect;
    public int puntoNecrotic;
    public GameObject textoNecroticLvl1;
    public GameObject textoNecroticLvl2;
    public GameObject cincuentaSelect;
    public int puntoCincuenta;
    public GameObject textoCincuentaLvl1;
    public GameObject textoCincuentaLvl2;
    public GameObject glassSelect;
    public int puntoGlass;
    public GameObject textoGlassLvl1;
    public GameObject textoGlassLvl2;
    public GameObject goliathSelect;
    public int puntoGoliath;
    public GameObject textoGoliathLvl1;
    public GameObject textoGoliathLvl2;
    public GameObject bartholomewSelect;
    public int puntoBartholomew;
    public GameObject textoBartholomewLvl1;
    public GameObject textoBartholomewLvl2;
    public GameObject prodigySelect;
    public int puntoProdigy;
    public GameObject textoProdigyLvl1;
    public GameObject textoProdigyLvl2;
    public GameObject elementalistSelect;
    public int puntoElementalist;
    public GameObject textoElementalistLvl1;
    public GameObject textoElementalistLvl2;
    public GameObject barbarianSelect;
    public int puntoBarbarian;
    public GameObject textoBarbarianLvl1;
    public GameObject textoBarbarianLvl2;
    public GameObject hoarderSelect;
    public int puntoHoarder;
    public GameObject textoHoarderLvl1;
    public GameObject textoHoarderLvl2;

    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;

    public int range;

    public GameObject hoverQuitar;

    public GameObject panelPausa;
    public GameObject ctrPausa;
    public int puntoPausa;
    public GameObject panelOpciones;
    public int puntoPanelOpciones;

    public int puntoMorirPlayerCancelarEscape;

    public int puntoRetry;

    public GameObject tutorial;
    public GameObject tutorialRecuadro1;
    public GameObject tutorialRecuadro2;
    public GameObject tutorialRecuadro3;
    public GameObject tutorialRecuadro4;
    public GameObject tutorialRecuadro5;
    public GameObject tutorialRecuadro6;
    public int tutorialYaVisto;
    void Start()
    {
        tutorialYaVisto = PlayerPrefs.GetInt("TutorialYaVisto");
        if (tutorialYaVisto <= 0)
        {
            Invoke(nameof(AbrirTutorial), 2.5f);
            puntoMorirPlayerCancelarEscape = 1;
          
        }
    
            posicionMadera = GameObject.FindGameObjectWithTag("PosicionMadera");
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
   
    public void CerrarTutorial()
    {
        AudioManager.instance.PlaySFX("Click");
        Time.timeScale = 1;
        puntoMorirPlayerCancelarEscape = 0;
        tutorial.SetActive(false);
        tutorialRecuadro1.SetActive(true);
        tutorialYaVisto = 1;
        PlayerPrefs.SetInt("TutorialYaVisto", tutorialYaVisto);
    }
    public void AbrirTutorial()
    {
        AudioManager.instance.PlaySFX("Click");
        puntoPanelOpciones = 0;
        panelOpciones.SetActive(false);
        panelPausa.SetActive(false);
        ctrPausa.SetActive(false);
        tutorial.SetActive(true);
        tutorialRecuadro1.SetActive(true);
        tutorialRecuadro2.SetActive(false);
        tutorialRecuadro3.SetActive(false);
        tutorialRecuadro4.SetActive(false);
        tutorialRecuadro5.SetActive(false);
        tutorialRecuadro6.SetActive(false);
        Time.timeScale = 1;
        Time.timeScale = 0;
    }
    public void TutorialUno()
    {
        AudioManager.instance.PlaySFX("Click");
        tutorialRecuadro1.SetActive(true);
        tutorialRecuadro2.SetActive(false);
    }
    public void TutorialDos()
    {
        AudioManager.instance.PlaySFX("Click");
        tutorialRecuadro1.SetActive(false);
        tutorialRecuadro2.SetActive(true);
        tutorialRecuadro3.SetActive(false);
    }
    public void TutorialTres()
    {
        AudioManager.instance.PlaySFX("Click");
        tutorialRecuadro2.SetActive(false);
        tutorialRecuadro3.SetActive(true);
        tutorialRecuadro4.SetActive(false);
    }
    public void TutorialCuatro()
    {
        AudioManager.instance.PlaySFX("Click");
        tutorialRecuadro3.SetActive(false);
        tutorialRecuadro4.SetActive(true);
        tutorialRecuadro5.SetActive(false);
    }
    public void TutorialCinco()
    {
        AudioManager.instance.PlaySFX("Click");
        tutorialRecuadro4.SetActive(false);
        tutorialRecuadro5.SetActive(true);
        tutorialRecuadro6.SetActive(false);
    }
    public void TutorialSeis()
    {
        AudioManager.instance.PlaySFX("Click");
        tutorialRecuadro5.SetActive(false);
        tutorialRecuadro6.SetActive(true);
    }

    public void CancelarTrinkets()
    {
        AudioManager.instance.PlaySFX("Click");
        Time.timeScale = 1;
       
        recuadroTrinkets.SetActive(false);
        botonTrinkets.SetActive(true);
        botonDonar.SetActive(true);
        memoriamSelect.SetActive(false);
        babelSelect.SetActive(false);
        gabrielSelect.SetActive(false);
        hourGlassSelect.SetActive(false);
        necroticSelect.SetActive(false);
        cincuentaSelect.SetActive(false);
        glassSelect.SetActive(false);
        goliathSelect.SetActive(false);
        bartholomewSelect.SetActive(false);
        prodigySelect.SetActive(false);
        elementalistSelect.SetActive(false);
        barbarianSelect.SetActive(false);
        hoarderSelect.SetActive(false);
        puntoMemoriam = 0;
        puntoBabel = 0;
        puntoGabriel = 0;
        puntoHourGlass = 0;
        puntoGlass = 0;
        puntoCincuenta = 0;
        puntoNecrotic = 0;
        puntoGoliath = 0;
        puntoBartholomew = 0;
        puntoProdigy = 0;
        puntoElementalist = 0;
        puntoBarbarian = 0;
        puntoHoarder = 0;
       

    }
    public void Trinkets1()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Trinkets>().nivelMemoriam == 0)
        {
            textoMemoriamLvl1.SetActive(true);
            textoMemoriamLvl2.SetActive(false);
        }
       else if (GetComponent<Trinkets>().nivelMemoriam >= 1)
        {
            textoMemoriamLvl1.SetActive(false);
            textoMemoriamLvl2.SetActive(true);
        }
        if (GetComponent<Trinkets>().nivelBabel == 0)
        {
            textoBabelLvl1.SetActive(true);
            textoBabelLvl2.SetActive(false);
        }
        else if (GetComponent<Trinkets>().nivelBabel >= 1)
        {
            textoBabelLvl1.SetActive(false);
            textoBabelLvl2.SetActive(true);
        }
        if (GetComponent<Trinkets>().nivelGabriel == 0)
        {
            textoGabrielLvl1.SetActive(true);
            textoGabrielLvl2.SetActive(false);
        }
        else if (GetComponent<Trinkets>().nivelGabriel >= 1)
        {
            textoGabrielLvl1.SetActive(false);
            textoGabrielLvl2.SetActive(true);
        }
        if (GetComponent<Trinkets>().nivelHourglass == 0)
        {
            textoHourglassLvl1.SetActive(true);
            textoHourglassLvl2.SetActive(false);
        }
        else if (GetComponent<Trinkets>().nivelHourglass >= 1)
        {
            textoHourglassLvl1.SetActive(false);
            textoHourglassLvl2.SetActive(true);
        }
        if (GetComponent<Trinkets>().nivelNecrotic == 0)
        {
            textoNecroticLvl1.SetActive(true);
            textoNecroticLvl2.SetActive(false);
        }
        else if (GetComponent<Trinkets>().nivelNecrotic >= 1)
        {
            textoNecroticLvl1.SetActive(false);
            textoNecroticLvl2.SetActive(true);
        }
        if (GetComponent<Trinkets>().nivelCincuenta == 0)
        {
            textoCincuentaLvl1.SetActive(true);
            textoCincuentaLvl2.SetActive(false);
        }
        else if (GetComponent<Trinkets>().nivelCincuenta >= 1)
        {
            textoCincuentaLvl1.SetActive(false);
            textoCincuentaLvl2.SetActive(true);
        }
        if (GetComponent<Trinkets>().nivelGlass == 0)
        {
            textoGlassLvl1.SetActive(true);
            textoGlassLvl2.SetActive(false);
        }
        else if (GetComponent<Trinkets>().nivelGlass >= 1)
        {
            textoGlassLvl1.SetActive(false);
            textoGlassLvl2.SetActive(true);
        }
        if (GetComponent<Trinkets>().nivelGoliath == 0)
        {
            textoGoliathLvl1.SetActive(true);
            textoGoliathLvl2.SetActive(false);
        }
        else if (GetComponent<Trinkets>().nivelGoliath >= 1)
        {
            textoGoliathLvl1.SetActive(false);
            textoGoliathLvl2.SetActive(true);
        }
        if (GetComponent<Trinkets>().nivelProdigy == 0)
        {
            textoProdigyLvl1.SetActive(true);
            textoProdigyLvl2.SetActive(false);
        }
        else if (GetComponent<Trinkets>().nivelProdigy >= 1)
        {
            textoProdigyLvl1.SetActive(false);
            textoProdigyLvl2.SetActive(true);
        }
        if (GetComponent<Trinkets>().nivelElementalist == 0)
        {
            textoElementalistLvl1.SetActive(true);
            textoElementalistLvl2.SetActive(false);
        }
        else if (GetComponent<Trinkets>().nivelElementalist >= 1)
        {
            textoElementalistLvl1.SetActive(false);
            textoElementalistLvl2.SetActive(true);
        }
        if (GetComponent<Trinkets>().nivelBarbarian == 0)
        {
            textoBarbarianLvl1.SetActive(true);
            textoBarbarianLvl2.SetActive(false);
        }
        else if (GetComponent<Trinkets>().nivelBarbarian >= 1)
        {
            textoBarbarianLvl1.SetActive(false);
            textoBarbarianLvl2.SetActive(true);
        }
        if (GetComponent<Trinkets>().nivelHoarder == 0)
        {
            textoHoarderLvl1.SetActive(true);
            textoHoarderLvl2.SetActive(false);
        }
        else if (GetComponent<Trinkets>().nivelHoarder >= 1)
        {
            textoHoarderLvl1.SetActive(false);
            textoHoarderLvl2.SetActive(true);
        }


        GetComponent<Recursos>().cantidadVecesTrinketsComprados += 2;
        GetComponent<Recursos>().cantidadVioleta -= GetComponent<Recursos>().costeTrinketsVioletas;
        GetComponent<Recursos>().costeTrinketsVioletas += 5;
        hoverQuitar.SetActive(false);
        recuadroTrinkets.SetActive(true);
        botonTrinkets.SetActive(false);
        botonDonar.SetActive(false);
        range = Random.Range(0, 12);
        if (range == 0)
        {
            
            memoriamSelect.SetActive(true);
                memoriamSelect.transform.position = slot1.transform.position;
                puntoMemoriam = 1;
            
        }
        else if (range == 1)
        {
          
            babelSelect.SetActive(true);
                babelSelect.transform.position = slot1.transform.position;
                puntoBabel = 1;

        }
        else if(range == 2)
        {
          
            gabrielSelect.SetActive(true);
            gabrielSelect.transform.position = slot1.transform.position;
            puntoGabriel = 1;

        }
        else if (range == 3)
        {
           
            hourGlassSelect.SetActive(true);
            hourGlassSelect.transform.position = slot1.transform.position;
            puntoHourGlass = 1;

        }
        else if (range == 4)
        {
           
            necroticSelect.SetActive(true);
            necroticSelect.transform.position = slot1.transform.position;
            puntoNecrotic = 1;

        }
        else if(range == 5)
        {
           
            cincuentaSelect.SetActive(true);
            cincuentaSelect.transform.position = slot1.transform.position;
            puntoCincuenta = 1;

        }
        else if (range == 6)
        {
           
            glassSelect.SetActive(true);
            glassSelect.transform.position = slot1.transform.position;
            puntoGlass = 1;

        }
        else if (range == 7)
        {
          
            goliathSelect.SetActive(true);
            goliathSelect.transform.position = slot1.transform.position;
            puntoGoliath = 1;

        }
        else if (range == 8)
        {
           
            prodigySelect.SetActive(true);
            prodigySelect.transform.position = slot1.transform.position;
            puntoProdigy = 1;

        }
        else if (range == 9)
        {
         
            elementalistSelect.SetActive(true);
            elementalistSelect.transform.position = slot1.transform.position;
            puntoElementalist = 1;

        }
        else if (range == 10)
        {
         
            barbarianSelect.SetActive(true);
            barbarianSelect.transform.position = slot1.transform.position;
            puntoBarbarian = 1;

        }
        else if (range == 11)
        {
           
            hoarderSelect.SetActive(true);
            hoarderSelect.transform.position = slot1.transform.position;
            puntoHoarder = 1;

        }
        Invoke(nameof(Trinkets2), 0.03f);
    
    }
    public void Trinkets2()
    {
     
        range = Random.Range(0, 12);
        if (range == 0)
        {
            if (puntoMemoriam <= 0)
            {
                
                memoriamSelect.SetActive(true);
                memoriamSelect.transform.position = slot2.transform.position;
                puntoMemoriam = 1;
                Invoke(nameof(Trinkets3), 0.1f);
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);

            }
        }
        else if (range == 1)
        {
            if (puntoBabel <= 0)
            {
                babelSelect.SetActive(true);
                babelSelect.transform.position = slot2.transform.position;
                puntoBabel = 1;
                Invoke(nameof(Trinkets3), 0.1f);
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
        }
        else if (range == 2)
        {
            if (puntoGabriel <= 0)
            {
                gabrielSelect.SetActive(true);
                gabrielSelect.transform.position = slot2.transform.position;
                puntoGabriel = 1;
                Invoke(nameof(Trinkets3), 0.1f);
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
          
        }
        else if (range == 3)
        {
            if (puntoHourGlass <= 0)
            {
                hourGlassSelect.SetActive(true);
                hourGlassSelect.transform.position = slot2.transform.position;
                puntoHourGlass = 1;
                Invoke(nameof(Trinkets3), 0.1f);
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
           
        }
        else if (range == 4)
        {
            if (puntoNecrotic <= 0)
            {
                necroticSelect.SetActive(true);
                necroticSelect.transform.position = slot2.transform.position;
                puntoNecrotic = 1;
                Invoke(nameof(Trinkets3), 0.1f);
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
           
        }
        else if (range == 5)
        {
            if (puntoCincuenta <= 0)
            {
                cincuentaSelect.SetActive(true);
                cincuentaSelect.transform.position = slot2.transform.position;
                puntoCincuenta = 1;
                Invoke(nameof(Trinkets3), 0.1f);
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
          
        }
        else if (range == 6)
        {
            if (puntoGlass <= 0)
            {
                glassSelect.SetActive(true);
                glassSelect.transform.position = slot2.transform.position;
                puntoGlass = 1;
                Invoke(nameof(Trinkets3), 0.1f);
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }

           

        }
        else if (range == 7)
        {
            if (puntoGoliath <= 0)
            {
                goliathSelect.SetActive(true);
                goliathSelect.transform.position = slot2.transform.position;
                puntoGoliath = 1;
                Invoke(nameof(Trinkets3), 0.1f);
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
           

        }
        else if (range == 8)
        {
            if (puntoProdigy <= 0)
            {
                prodigySelect.SetActive(true);
                prodigySelect.transform.position = slot2.transform.position;
                puntoProdigy = 1;
                Invoke(nameof(Trinkets3), 0.1f);
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }

        }

        else if (range == 9)
        {
            if (puntoElementalist <= 0)
            {
                elementalistSelect.SetActive(true);
                elementalistSelect.transform.position = slot2.transform.position;
                puntoElementalist = 1;
                Invoke(nameof(Trinkets3), 0.1f);
            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
          

        }
        else if (range == 10)
        {
            if (puntoBarbarian <= 0)
            {
                barbarianSelect.SetActive(true);
                barbarianSelect.transform.position = slot2.transform.position;
                puntoBarbarian = 1;
                Invoke(nameof(Trinkets3), 0.1f);

            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
          
        }
        else if (range == 11)
        {
            if (puntoHoarder <= 0)
            {
                hoarderSelect.SetActive(true);
                hoarderSelect.transform.position = slot2.transform.position;
                puntoHoarder = 1;
                Invoke(nameof(Trinkets3), 0.1f);

            }
            else
            {
                Invoke(nameof(Trinkets2), 0.01f);
            }
          
        }
        
    }
    public void Trinkets3()
    {
       
       
        range = Random.Range(0, 12);
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
                Invoke(nameof(Trinkets3), 0.02f);
            }
        }
        else if (range == 1)
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
                Invoke(nameof(Trinkets3), 0.02f);
            }
        }
        else if (range == 2)
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
                Invoke(nameof(Trinkets3), 0.02f);
            }

        }
        else if (range == 3)
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
                Invoke(nameof(Trinkets3), 0.02f);
            }

        }
        else if (range == 4)
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
                Invoke(nameof(Trinkets3), 0.02f);
            }

        }
        else if (range == 5)
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
                Invoke(nameof(Trinkets3), 0.02f);
            }

        }
        else if (range == 6)
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
                Invoke(nameof(Trinkets3), 0.02f);
            }



        }
        else if (range == 7)
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
                Invoke(nameof(Trinkets3), 0.02f);
            }


        }
        else if (range == 8)
        {
            if (puntoProdigy <= 0)
            {
                prodigySelect.SetActive(true);
                prodigySelect.transform.position = slot3.transform.position;
                puntoProdigy = 1;
                Time.timeScale = 0;
            }
            else
            {
                Invoke(nameof(Trinkets3), 0.02f);
            }

        }

        else if (range == 9)
        {
            if (puntoElementalist <= 0)
            {
                elementalistSelect.SetActive(true);
                elementalistSelect.transform.position = slot3.transform.position;
                puntoElementalist = 1;
                Time.timeScale = 0;
            }
            else
            {
                Invoke(nameof(Trinkets3), 0.02f);
            }


        }
        else if (range == 10)
        {
            if (puntoBarbarian <= 0)
            {
                barbarianSelect.SetActive(true);
                barbarianSelect.transform.position = slot3.transform.position;
                puntoBarbarian = 1;
                Time.timeScale = 0;

            }
            else
            {
                Invoke(nameof(Trinkets3), 0.02f);
            }

        }
        else if (range == 11)
        {
            if (puntoHoarder <= 0)
            {

                hoarderSelect.SetActive(true);
                hoarderSelect.transform.position = slot3.transform.position;
                puntoHoarder = 1;
                Time.timeScale = 0;

            }
            else
            {
                Invoke(nameof(Trinkets3), 0.02f);
            }

        }

    }
    public void DespliegueConstruccion()
    {
        AudioManager.instance.PlaySFX("Click");
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
        AudioManager.instance.PlaySFX("Click");
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
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadVioleta >= 10 && GetComponent<Recursos>().violetasDonados < GetComponent<Recursos>().violetasTotalesADonar)
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
    public void Opciones()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoPanelOpciones <= 0)
        {
            puntoPanelOpciones = 1;
            panelOpciones.SetActive(true);
        }
        else
        {
            puntoPanelOpciones = 0;
            panelOpciones.SetActive(false);
        }
    }
    public void BotonResume()
    {
        AudioManager.instance.PlaySFX("Click");
        panelPausa.SetActive(false);
        ctrPausa.SetActive(false);
        panelOpciones.SetActive(false);
        puntoPanelOpciones = 0;
        puntoPausa = 0;
        Time.timeScale = 1;
    }
    public void Retry()
    {
        puntoRetry = 1;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        puntoRetry = 1;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    void Update()
    {
        if (puntoPausa <= 0 && Input.GetKeyDown(KeyCode.Escape) && puntoMorirPlayerCancelarEscape <= 0)
        {
            puntoPausa = 1;
            panelPausa.SetActive(true);
            ctrPausa.SetActive(true);
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelOpciones.SetActive(false);
            panelPausa.SetActive(false);
            ctrPausa.SetActive(false);
            puntoPausa = 0;
            Time.timeScale = 1;
        }
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
