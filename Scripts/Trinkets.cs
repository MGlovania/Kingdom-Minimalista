using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Trinkets : MonoBehaviour
{

    public TMP_Text textoNivelMemoriam;
    public TMP_Text textoNivelBabel;
    public TMP_Text textoNivelGabriel;
    public TMP_Text textoNivelHourglass;
    public TMP_Text textoNivelNecrotic;
    public TMP_Text textoNivelCincuenta;
    public TMP_Text textoNivelGlass;
    public TMP_Text textoNivelGoliath;
    public TMP_Text textoNivelBartholomew;
    public TMP_Text textoNivelProdigy;
    public TMP_Text textoNivelElementalist;
    public TMP_Text textoNivelBarbarian;
    public TMP_Text textoNivelHoarder;


    public int nivelMemoriam;
    public int nivelBabel;
    public int nivelGabriel;
    public int nivelHourglass;
    public int nivelNecrotic;
    public int nivelCincuenta;
    public int nivelGlass;
    public int nivelGoliath;
    public int nivelBartholomew;
    public int nivelProdigy;
    public int nivelElementalist;
    public int nivelBarbarian;
    public int nivelHoarder;

    public GameObject trinket1;
    public int puntoTrinket1;
    public GameObject trinket2;
    public int puntoTrinket2;
    public GameObject trinket3;
    public int puntoTrinket3;
    public GameObject trinket4;
    public int puntoTrinket4;
  


    public GameObject memoriam;
    public GameObject babel;
    public GameObject gabriel;
    public GameObject hourglass;
    public GameObject necrotic;
    public GameObject cincuenta;
    public GameObject glass;
    public GameObject goliath;
    public GameObject bartholomew;
    public GameObject prodigy;
    public GameObject elementalist;
    public GameObject barbarian;
    public GameObject hoarder;

    public int memoriamSelect;
    public int babelSelect;
    public int gabrielSelect;
    public int hourglassSelect;
    public int necroticSelect;
    public int cincuentaSelect;
    public int glassSelect;
    public int goliathSelect;
    public int bartholomewSelect;
    public int prodigySelect;
    public int elementalistSelect;
    public int barbarianSelect;
    public int hoarderSelect;

    public GameObject trinketMenu;

    public int nivelTrinket1;
    public int nivelTrinket2;
    public int nivelTrinket3;
    public int nivelTrinket4;


    public GameObject memoriamRecuadroActivo;
    public GameObject babelRecuadroActivo;
    public GameObject gabrielRecuadroActivo;
    public GameObject hourGlassRecuadroActivo;
    public GameObject necroticRecuadroActivo;
    public GameObject cincuentaRecuadroActivo;
    public GameObject glassRecuadroActivo;
    public GameObject goliathRecuadroActivo;
    public GameObject bartholomewRecuadroActivo;
    public GameObject prodigyRecuadroActivo;
    public GameObject elementalistRecuadroActivo;
    public GameObject barbarianRecuadroActivo;
    public GameObject hoarderRecuadroActivo;
    void Start()
    {
        
    }
    public void SeleccionarYQuitarRecuadros()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            AudioManager.instance.PlaySFX("Click");
            memoriamRecuadroActivo.SetActive(false);
            babelRecuadroActivo.SetActive(false);
            gabrielRecuadroActivo.SetActive(false);
            hourGlassRecuadroActivo.SetActive(false);
            necroticRecuadroActivo.SetActive(false);
            cincuentaRecuadroActivo.SetActive(false);
            glassRecuadroActivo.SetActive(false);
            goliathRecuadroActivo.SetActive(false);
            bartholomewRecuadroActivo.SetActive(false);
            prodigyRecuadroActivo.SetActive(false);
            elementalistRecuadroActivo.SetActive(false);
            barbarianRecuadroActivo.SetActive(false);
            hoarderRecuadroActivo.SetActive(false);
            GetComponent<BotonesRun>().puntoBabel = 0;
            GetComponent<BotonesRun>().puntoBarbarian = 0;
            GetComponent<BotonesRun>().puntoBartholomew = 0;
            GetComponent<BotonesRun>().puntoCincuenta = 0;
            GetComponent<BotonesRun>().puntoElementalist = 0;
            GetComponent<BotonesRun>().puntoGabriel = 0;
            GetComponent<BotonesRun>().puntoGlass = 0;
            GetComponent<BotonesRun>().puntoGoliath = 0;
            GetComponent<BotonesRun>().puntoHoarder = 0;
            GetComponent<BotonesRun>().puntoHourGlass = 0;
            GetComponent<BotonesRun>().puntoMemoriam = 0;
            GetComponent<BotonesRun>().puntoNecrotic = 0;
            GetComponent<BotonesRun>().puntoProdigy = 0;
            GetComponent<BotonesRun>().botonTrinkets.SetActive(true);
            GetComponent<BotonesRun>().botonDonar.SetActive(true);
        }
           
    }

  
    public void Memoriam()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            GetComponent<Recursos>().puntoActualizarMemoriam = 1;
            if (nivelMemoriam >= 1)
            {
                GetComponent<Recursos>().bonusMemoriamMostrarPorNivel += 1;
                memoriam.SetActive(true);
            }
            else 
            {
                memoriam.SetActive(true);
                GetComponent<Recursos>().cantidadTrinkets += 1;
                memoriamSelect = 1;
                if (puntoTrinket1 <= 0)
                {
                    puntoTrinket1 = 1;
                    memoriam.transform.position = trinket1.transform.position;
                    memoriam.GetComponent<HoverVender>().posicion1 = 1;
                }
                else if (puntoTrinket2 <= 0)
                {
                    puntoTrinket2 = 1;
                    memoriam.transform.position = trinket2.transform.position;
                    memoriam.GetComponent<HoverVender>().posicion2 = 1;
                }
                else if (puntoTrinket3 <= 0)
                {
                    puntoTrinket3 = 1;
                    memoriam.transform.position = trinket3.transform.position;
                    memoriam.GetComponent<HoverVender>().posicion3 = 1;
                }
                else if (puntoTrinket4 <= 0)
                {
                    puntoTrinket4 = 1;
                    memoriam.transform.position = trinket4.transform.position;
                    memoriam.GetComponent<HoverVender>().posicion4 = 1;
                }
            }
            Time.timeScale = 1;
            trinketMenu.SetActive(false);                
            nivelMemoriam += 1;
           
          
        }
     
        
    }
    public void Babel()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            GetComponent<Recursos>().puntoActualizarBabel = 1;
            if (nivelBabel >= 1)
            {
                GetComponent<Recursos>().bonusBabelMostrarPorNivel += 1;
                babel.SetActive(true);
            }
            else
            {
                GetComponent<Recursos>().cantidadTrinkets += 1;
                babelSelect = 1;
                babel.SetActive(true);
                if (puntoTrinket1 <= 0)
                {
                    puntoTrinket1 = 1;
                    babel.transform.position = trinket1.transform.position;
                    babel.GetComponent<HoverVender>().posicion1 = 1;
                }
                else if (puntoTrinket2 <= 0)
                {
                    puntoTrinket2 = 1;
                    babel.transform.position = trinket2.transform.position;
                    babel.GetComponent<HoverVender>().posicion2 = 1;
                }
                else if (puntoTrinket3 <= 0)
                {
                    puntoTrinket3 = 1;
                    babel.transform.position = trinket3.transform.position;
                    babel.GetComponent<HoverVender>().posicion3 = 1;
                }
                else if (puntoTrinket4 <= 0)
                {
                    puntoTrinket4 = 1;
                    babel.transform.position = trinket4.transform.position;
                    babel.GetComponent<HoverVender>().posicion4 = 1;
                }

            }


            Time.timeScale = 1;       
            trinketMenu.SetActive(false);
            nivelBabel += 1;
         
        }
         
    }
    public void Gabriel()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            if (nivelGabriel >= 1)
            {
                gabriel.SetActive(true);
            }
            else
            {
                GetComponent<Recursos>().cantidadTrinkets += 1;
                gabrielSelect = 1;
                gabriel.SetActive(true);
                if (puntoTrinket1 <= 0)
                {
                    puntoTrinket1 = 1;
                    gabriel.transform.position = trinket1.transform.position;
                    gabriel.GetComponent<HoverVender>().posicion1 = 1;
                }
                else if (puntoTrinket2 <= 0)
                {
                    puntoTrinket2 = 1;
                    gabriel.transform.position = trinket2.transform.position;
                    gabriel.GetComponent<HoverVender>().posicion1 = 2;
                }
                else if (puntoTrinket3 <= 0)
                {
                    puntoTrinket3 = 1;
                    gabriel.transform.position = trinket3.transform.position;
                    gabriel.GetComponent<HoverVender>().posicion1 = 3;
                }
                else if (puntoTrinket4 <= 0)
                {
                    puntoTrinket4 = 1;
                    gabriel.transform.position = trinket4.transform.position;
                    gabriel.GetComponent<HoverVender>().posicion1 = 4;
                }

            }
            GetComponent<Recursos>().timeGanarArmaduraGabriel -= 4;
            Time.timeScale = 1;
        
            trinketMenu.SetActive(false);
            nivelGabriel += 1;
           

        }
       
    }
    public void Hourglass()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            if (nivelHourglass >= 1)
            {
                GetComponent<Recursos>().puntoActualizarHourglass = 0;
                hourglass.SetActive(true);
            }
            else
            {
                GetComponent<Recursos>().cantidadTrinkets += 1;
                hourglassSelect = 1;
                hourglass.SetActive(true);
                if (puntoTrinket1 <= 0)
                {
                    puntoTrinket1 = 1;
                    hourglass.transform.position = trinket1.transform.position;
                    hourglass.GetComponent<HoverVender>().posicion1 = 1;

                }
                else if (puntoTrinket2 <= 0)
                {
                    puntoTrinket2 = 1;
                    hourglass.transform.position = trinket2.transform.position;
                    hourglass.GetComponent<HoverVender>().posicion2 = 1;
                }
                else if (puntoTrinket3 <= 0)
                {
                    puntoTrinket3 = 1;
                    hourglass.transform.position = trinket3.transform.position;
                    hourglass.GetComponent<HoverVender>().posicion3 = 1;
                }
                else if (puntoTrinket4 <= 0)
                {
                    puntoTrinket4 = 1;
                    hourglass.transform.position = trinket4.transform.position;
                    hourglass.GetComponent<HoverVender>().posicion4 = 1;
                }
            }
            Time.timeScale = 1;
            trinketMenu.SetActive(false);
            nivelHourglass += 1;
          

        }
   
    }
    public void Necrotic()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            if (nivelNecrotic >= 1)
            {
                GetComponent<Recursos>().rangeExplosionNecrotic += 10;
                necrotic.SetActive(true);
            }
            else
            {
                GetComponent<Recursos>().cantidadTrinkets += 1;
                necroticSelect = 1;
                necrotic.SetActive(true);
                if (puntoTrinket1 <= 0)
                {
                    puntoTrinket1 = 1;
                    necrotic.transform.position = trinket1.transform.position;
                    necrotic.GetComponent<HoverVender>().posicion1 = 1;
                }
                else if (puntoTrinket2 <= 0)
                {
                    puntoTrinket2 = 1;
                    necrotic.transform.position = trinket2.transform.position;
                    necrotic.GetComponent<HoverVender>().posicion2 = 1;
                }
                else if (puntoTrinket3 <= 0)
                {
                    puntoTrinket3 = 1;
                    necrotic.transform.position = trinket3.transform.position;
                    necrotic.GetComponent<HoverVender>().posicion3 = 1;
                }
                else if (puntoTrinket4 <= 0)
                {
                    puntoTrinket4 = 1;
                    necrotic.transform.position = trinket4.transform.position;
                    necrotic.GetComponent<HoverVender>().posicion4 = 1;
                }
            }
                  
            Time.timeScale = 1;
           
            trinketMenu.SetActive(false);
            nivelNecrotic += 1;
           

        }
      
    }
    public void Cincuenta()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            if (nivelCincuenta >= 1)
            {
                GetComponent<Recursos>().rangeDobleAtaqueCincuenta += 10;
                cincuenta.SetActive(true);
            }
            else
            {
                GetComponent<Recursos>().cantidadTrinkets += 1;
                cincuentaSelect = 1;
                cincuenta.SetActive(true);
                if (puntoTrinket1 <= 0)
                {
                    puntoTrinket1 = 1;
                    cincuenta.transform.position = trinket1.transform.position;
                    cincuenta.GetComponent<HoverVender>().posicion1 = 1;

                }
                else if (puntoTrinket2 <= 0)
                {
                    puntoTrinket2 = 1;
                    cincuenta.transform.position = trinket2.transform.position;
                    cincuenta.GetComponent<HoverVender>().posicion2 = 1;
                }
                else if (puntoTrinket3 <= 0)
                {
                    puntoTrinket3 = 1;
                    cincuenta.transform.position = trinket3.transform.position;
                    cincuenta.GetComponent<HoverVender>().posicion3 = 1;
                }
                else if (puntoTrinket4 <= 0)
                {
                    puntoTrinket4 = 1;
                    cincuenta.transform.position = trinket4.transform.position;
                    cincuenta.GetComponent<HoverVender>().posicion3 = 1;
                }
            }
            Time.timeScale = 1;
            trinketMenu.SetActive(false);
            nivelCincuenta += 1;
           
        }
       
    }
    public void Glass()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            if (nivelGlass >= 1)
            {
                GetComponent<Recursos>().rangeDobleAtaqueGlass += 10;
                glass.SetActive(true);
            }
            else
            {
                GetComponent<Recursos>().cantidadTrinkets += 1;
                glassSelect = 1;
                glass.SetActive(true);
                if (puntoTrinket1 <= 0)
                {
                    puntoTrinket1 = 1;
                    glass.transform.position = trinket1.transform.position;
                    glass.GetComponent<HoverVender>().posicion1 = 1;
                }
                else if (puntoTrinket2 <= 0)
                {
                    puntoTrinket2 = 1;
                    glass.transform.position = trinket2.transform.position;
                    glass.GetComponent<HoverVender>().posicion2 = 1;
                }
                else if (puntoTrinket3 <= 0)
                {
                    puntoTrinket3 = 1;
                    glass.transform.position = trinket3.transform.position;
                    glass.GetComponent<HoverVender>().posicion3 = 1;
                }
                else if (puntoTrinket4 <= 0)
                {
                    puntoTrinket4 = 1;
                    glass.transform.position = trinket4.transform.position;
                    glass.GetComponent<HoverVender>().posicion4 = 1;
                }
            }
            Time.timeScale = 1;
            trinketMenu.SetActive(false);
            nivelGlass += 1;
           

        }

    }
    public void Goliath()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            if (nivelGoliath >= 1)
            {
                GetComponent<Recursos>().rangeFlechaGoliath += 2;
                goliath.SetActive(true);
            }
            else
            {
                GetComponent<Recursos>().cantidadTrinkets += 1;
                goliathSelect = 1;
                goliath.SetActive(true);
                if (puntoTrinket1 <= 0)
                {
                    puntoTrinket1 = 1;
                    goliath.transform.position = trinket1.transform.position;
                    goliath.GetComponent<HoverVender>().posicion1 = 1;
                }
                else if (puntoTrinket2 <= 0)
                {
                    puntoTrinket2 = 1;
                    goliath.transform.position = trinket2.transform.position;
                    goliath.GetComponent<HoverVender>().posicion2 = 1;
                }
                else if (puntoTrinket3 <= 0)
                {
                    puntoTrinket3 = 1;
                    goliath.transform.position = trinket3.transform.position;
                    goliath.GetComponent<HoverVender>().posicion3 = 1;
                }
                else if (puntoTrinket4 <= 0)
                {
                    puntoTrinket4 = 1;
                    goliath.transform.position = trinket4.transform.position;
                    goliath.GetComponent<HoverVender>().posicion4 = 1;
                }
            }
            Time.timeScale = 1;
            trinketMenu.SetActive(false);
            nivelGoliath += 1;
          

        }

    }
    public void Bartholomew()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            GetComponent<Recursos>().cantidadTrinkets += 1;
            bartholomewSelect = 1;
            Time.timeScale = 1;
            bartholomew.SetActive(true);
            trinketMenu.SetActive(false);
            nivelBartholomew += 1;
            if (puntoTrinket1 <= 0)
            {
                puntoTrinket1 = 1;
                bartholomew.transform.position = trinket1.transform.position;
                bartholomew.GetComponent<HoverVender>().posicion1 = 1;
            }
            else if (puntoTrinket2 <= 0)
            {
                puntoTrinket2 = 1;
                bartholomew.transform.position = trinket2.transform.position;
                bartholomew.GetComponent<HoverVender>().posicion2 = 1;
            }
            else if (puntoTrinket3 <= 0)
            {
                puntoTrinket3 = 1;
                bartholomew.transform.position = trinket3.transform.position;
                bartholomew.GetComponent<HoverVender>().posicion3 = 1;
            }
            else if (puntoTrinket4 <= 0)
            {
                puntoTrinket4 = 1;
                bartholomew.transform.position = trinket4.transform.position;
                bartholomew.GetComponent<HoverVender>().posicion4 = 1;
            }

        }

    }
    public void Prodigy()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            if (nivelProdigy >= 1)
            {
                GetComponent<Recursos>().dañoFuego += 2;
                GetComponent<Recursos>().tiempoCongelacion += 0.4f;
                prodigy.SetActive(true);
            }
            else
            {
                GetComponent<Recursos>().dañoFuego += 2;
                GetComponent<Recursos>().tiempoCongelacion += 0.4f;
                GetComponent<Recursos>().cantidadTrinkets += 1;
                prodigySelect = 1;
                prodigy.SetActive(true);
                if (puntoTrinket1 <= 0)
                {
                    puntoTrinket1 = 1;
                    prodigy.transform.position = trinket1.transform.position;
                    prodigy.GetComponent<HoverVender>().posicion1 = 1;
                }
                else if (puntoTrinket2 <= 0)
                {
                    puntoTrinket2 = 1;
                    prodigy.transform.position = trinket2.transform.position;
                    prodigy.GetComponent<HoverVender>().posicion2 = 1;
                }
                else if (puntoTrinket3 <= 0)
                {
                    puntoTrinket3 = 1;
                    prodigy.transform.position = trinket3.transform.position;
                    prodigy.GetComponent<HoverVender>().posicion3 = 1;
                }
                else if (puntoTrinket4 <= 0)
                {
                    puntoTrinket4 = 1;
                    prodigy.transform.position = trinket4.transform.position;
                    prodigy.GetComponent<HoverVender>().posicion4 = 1;
                }

            }
         
          
            Time.timeScale = 1;
            trinketMenu.SetActive(false);
            nivelProdigy += 1;
           
        }

    }
    public void Elementalist()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            if (nivelElementalist >= 1)
            {
                GetComponent<Recursos>().puntoActualizarElementalist = 0;
                elementalist.SetActive(true);
            }
            else
            {
                GetComponent<Recursos>().cantidadTrinkets += 1;
                elementalistSelect = 1;
                elementalist.SetActive(true);
                if (puntoTrinket1 <= 0)
                {
                    puntoTrinket1 = 1;
                    elementalist.transform.position = trinket1.transform.position;
                    elementalist.GetComponent<HoverVender>().posicion1 = 1;
                }
                else if (puntoTrinket2 <= 0)
                {
                    puntoTrinket2 = 1;
                    elementalist.transform.position = trinket2.transform.position;
                    elementalist.GetComponent<HoverVender>().posicion2 = 1;
                }
                else if (puntoTrinket3 <= 0)
                {
                    puntoTrinket3 = 1;
                    elementalist.transform.position = trinket3.transform.position;
                    elementalist.GetComponent<HoverVender>().posicion3 = 1;
                }
                else if (puntoTrinket4 <= 0)
                {
                    puntoTrinket4 = 1;
                    elementalist.transform.position = trinket4.transform.position;
                    elementalist.GetComponent<HoverVender>().posicion4 = 1;
                }


            }
            Time.timeScale = 1;
            trinketMenu.SetActive(false);
            nivelElementalist += 1;
           
        }

    }
    public void Barbarian()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            if (nivelBarbarian >= 1)
            {
                GetComponent<Recursos>().puntoActualizarBarbarian = 0;
                barbarian.SetActive(true);
            }
            else
            {
                GetComponent<Recursos>().cantidadTrinkets += 1;
                barbarianSelect = 1;
                barbarian.SetActive(true);
                if (puntoTrinket1 <= 0)
                {
                    puntoTrinket1 = 1;
                    barbarian.transform.position = trinket1.transform.position;
                    barbarian.GetComponent<HoverVender>().posicion1 = 1;
                }
                else if (puntoTrinket2 <= 0)
                {
                    puntoTrinket2 = 1;
                    barbarian.transform.position = trinket2.transform.position;
                    barbarian.GetComponent<HoverVender>().posicion2 = 1;
                }
                else if (puntoTrinket3 <= 0)
                {
                    puntoTrinket3 = 1;
                    barbarian.transform.position = trinket3.transform.position;
                    barbarian.GetComponent<HoverVender>().posicion3 = 1;
                }
                else if (puntoTrinket4 <= 0)
                {
                    puntoTrinket4 = 1;
                    barbarian.transform.position = trinket4.transform.position;
                    barbarian.GetComponent<HoverVender>().posicion4 = 1;
                }


            }
            Time.timeScale = 1;
            trinketMenu.SetActive(false);
            nivelBarbarian += 1;
          

        }

    }
    public void Hoarder()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            if (nivelHoarder >= 1)
            {
                GetComponent<Recursos>().puntoActualizarHoarder = 1;
                GetComponent<Recursos>().mostrarSpeedHoarder += 1;
                hoarder.SetActive(true);
            }
            else
            {
                GetComponent<Recursos>().mostrarSpeedHoarder = 2;
                hoarderSelect = 1;
                hoarder.SetActive(true);
                if (puntoTrinket1 <= 0)
                {
                    puntoTrinket1 = 1;
                    hoarder.transform.position = trinket1.transform.position;
                    hoarder.GetComponent<HoverVender>().posicion1 = 1;
                }
                else if (puntoTrinket2 <= 0)
                {
                    puntoTrinket2 = 1;
                    hoarder.transform.position = trinket2.transform.position;
                    hoarder.GetComponent<HoverVender>().posicion2 = 1;
                }
                else if (puntoTrinket3 <= 0)
                {
                    puntoTrinket3 = 1;
                    hoarder.transform.position = trinket3.transform.position;
                    hoarder.GetComponent<HoverVender>().posicion3 = 1;
                }
                else if (puntoTrinket4 <= 0)
                {
                    puntoTrinket4 = 1;
                    hoarder.transform.position = trinket4.transform.position;
                    hoarder.GetComponent<HoverVender>().posicion4 = 1;
                }

            }
            Time.timeScale = 1;
            trinketMenu.SetActive(false);
            nivelHoarder += 1;
           

        }

    }

    void Update()
    {
        textoNivelMemoriam.text = "x" + nivelMemoriam.ToString("F0");
        textoNivelBabel.text = "x" + nivelBabel.ToString("F0");
        textoNivelGabriel.text = "x" + nivelGabriel.ToString("F0");
        textoNivelHourglass.text = "x" + nivelHourglass.ToString("F0");
        textoNivelNecrotic.text = "x" + nivelNecrotic.ToString("F0");
        textoNivelCincuenta.text = "x" + nivelCincuenta.ToString("F0");
        textoNivelGlass.text = "x" + nivelGlass.ToString("F0");
        textoNivelGoliath.text = "x" + nivelGoliath.ToString("F0");
        textoNivelBartholomew.text = "x" + nivelBartholomew.ToString("F0");
        textoNivelProdigy.text = "x" + nivelProdigy.ToString("F0");
        textoNivelElementalist.text = "x" + nivelElementalist.ToString("F0");
        textoNivelBarbarian.text = "x" + nivelBarbarian.ToString("F0");
        textoNivelHoarder.text = "x" + nivelHoarder.ToString("F0");

    }
}
