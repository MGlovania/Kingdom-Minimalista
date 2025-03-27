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

    public int nivelMemoriam;
    public int nivelBabel;
    public int nivelGabriel;
    public int nivelHourglass;
    public int nivelNecrotic;
    public int nivelCincuenta;
    public int nivelGlass;
    public int nivelGoliath;
    public int nivelBartholomew;

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

    public int memoriamSelect;
    public int babelSelect;
    public int gabrielSelect;
    public int hourglassSelect;
    public int necroticSelect;
    public int cincuentaSelect;
    public int glassSelect;
    public int goliathSelect;
    public int bartholomewSelect;

    public GameObject trinketMenu;

    public int nivelTrinket1;
    public int nivelTrinket2;
    public int nivelTrinket3;
    public int nivelTrinket4;
    void Start()
    {
        
    }
    public void Memoriam()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            Time.timeScale = 1;
            memoriam.SetActive(true);
            trinketMenu.SetActive(false);
            memoriamSelect = 1;
            nivelMemoriam += 1;
            if (puntoTrinket1 <= 0)
            {
                puntoTrinket1 = 1;               
                memoriam.transform.position = trinket1.transform.position;
            }
            else if (puntoTrinket2 <= 0)
            {
                puntoTrinket2 = 1;
                memoriam.transform.position = trinket2.transform.position;
            }
            else if (puntoTrinket3 <= 0)
            {
                puntoTrinket3 = 1;
                memoriam.transform.position = trinket3.transform.position;
            }
            else if (puntoTrinket4 <= 0)
            {
                puntoTrinket4 = 1;
                memoriam.transform.position = trinket4.transform.position;
            }
        }
     
        
    }
    public void Babel()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            babelSelect = 1;
            Time.timeScale = 1;
            babel.SetActive(true);
            trinketMenu.SetActive(false);
            nivelBabel += 1;
            if (puntoTrinket1 <= 0)
            {
                puntoTrinket1 = 1;
                babel.transform.position = trinket1.transform.position;
            }
            else if (puntoTrinket2 <= 0)
            {
                puntoTrinket2 = 1;
                babel.transform.position = trinket2.transform.position;
            }
            else if (puntoTrinket3 <= 0)
            {
                puntoTrinket3 = 1;
                babel.transform.position = trinket3.transform.position;
            }
            else if (puntoTrinket4 <= 0)
            {
                puntoTrinket4 = 1;
                babel.transform.position = trinket4.transform.position;
            }

        }
         
    }
    public void Gabriel()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            gabrielSelect = 1;
            Time.timeScale = 1;
            gabriel.SetActive(true);
            trinketMenu.SetActive(false);
            nivelGabriel += 1;
            if (puntoTrinket1 <= 0)
            {
                puntoTrinket1 = 1;
                gabriel.transform.position = trinket1.transform.position;

            }
            else if (puntoTrinket2 <= 0)
            {
                puntoTrinket2 = 1;
                gabriel.transform.position = trinket2.transform.position;
            }
            else if (puntoTrinket3 <= 0)
            {
                puntoTrinket3 = 1;
                gabriel.transform.position = trinket3.transform.position;
            }
            else if (puntoTrinket4 <= 0)
            {
                puntoTrinket4 = 1;
                gabriel.transform.position = trinket4.transform.position;
            }

        }
       
    }
    public void Hourglass()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            hourglassSelect = 1;
            Time.timeScale = 1;
            hourglass.SetActive(true);
            trinketMenu.SetActive(false);
            nivelHourglass += 1;
            if (puntoTrinket1 <= 0)
            {
                puntoTrinket1 = 1;
                hourglass.transform.position = trinket1.transform.position;

            }
            else if (puntoTrinket2 <= 0)
            {
                puntoTrinket2 = 1;
                hourglass.transform.position = trinket2.transform.position;
            }
            else if (puntoTrinket3 <= 0)
            {
                puntoTrinket3 = 1;
                hourglass.transform.position = trinket3.transform.position;
            }
            else if (puntoTrinket4 <= 0)
            {
                puntoTrinket4 = 1;
                hourglass.transform.position = trinket4.transform.position;
            }

        }
   
    }
    public void Necrotic()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            necroticSelect = 1;
            Time.timeScale = 1;
            necrotic.SetActive(true);
            trinketMenu.SetActive(false);
            nivelNecrotic += 1;
            if (puntoTrinket1 <= 0)
            {
                puntoTrinket1 = 1;
                necrotic.transform.position = trinket1.transform.position;

            }
            else if (puntoTrinket2 <= 0)
            {
                puntoTrinket2 = 1;
                necrotic.transform.position = trinket2.transform.position;
            }
            else if (puntoTrinket3 <= 0)
            {
                puntoTrinket3 = 1;
                necrotic.transform.position = trinket3.transform.position;
            }
            else if (puntoTrinket4 <= 0)
            {
                puntoTrinket4 = 1;
                necrotic.transform.position = trinket4.transform.position;
            }

        }
      
    }
    public void Cincuenta()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            cincuentaSelect = 1;
            Time.timeScale = 1;
            cincuenta.SetActive(true);
            trinketMenu.SetActive(false);
            nivelCincuenta += 1;
            if (puntoTrinket1 <= 0)
            {
                puntoTrinket1 = 1;
                cincuenta.transform.position = trinket1.transform.position;

            }
            else if (puntoTrinket2 <= 0)
            {
                puntoTrinket2 = 1;
                cincuenta.transform.position = trinket2.transform.position;
            }
            else if (puntoTrinket3 <= 0)
            {
                puntoTrinket3 = 1;
                cincuenta.transform.position = trinket3.transform.position;
            }
            else if (puntoTrinket4 <= 0)
            {
                puntoTrinket4 = 1;
                cincuenta.transform.position = trinket4.transform.position;
            }
        }
       
    }
    public void Glass()
    {
        if (puntoTrinket1 <= 0 || puntoTrinket2 <= 0 || puntoTrinket3 <= 0 || puntoTrinket4 <= 0)
        {
            glassSelect = 1;
            Time.timeScale = 1;
            glass.SetActive(true);
            trinketMenu.SetActive(false);
            nivelGlass += 1;
            if (puntoTrinket1 <= 0)
            {
                puntoTrinket1 = 1;
                glass.transform.position = trinket1.transform.position;

            }
            else if (puntoTrinket2 <= 0)
            {
                puntoTrinket2 = 1;
                glass.transform.position = trinket2.transform.position;
            }
            else if (puntoTrinket3 <= 0)
            {
                puntoTrinket3 = 1;
                glass.transform.position = trinket3.transform.position;
            }
            else if (puntoTrinket4 <= 0)
            {
                puntoTrinket4 = 1;
                glass.transform.position = trinket4.transform.position;
            }

        }
      
    }

    void Update()
    {
        
    }
}
