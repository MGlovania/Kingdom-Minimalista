using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Idioma : MonoBehaviour
{
    public int cambioIdioma = 1;

    public string[] textoIngles;

    public string[] textoEspañol;

    public TMP_Text[] text;
    void Update()
    {

        cambioIdioma = PlayerPrefs.GetInt("Idioma");

        if (cambioIdioma == 0)
        {

            englishLanguage();

        }
        else if (cambioIdioma == 1)
        {

            spanishLanguage();
        
        }



    }

    public void Cambiar()
    {
        AudioManager.instance.PlaySFX("Click");
        if (cambioIdioma == 0)
        {
            cambioIdioma = 1;
            PlayerPrefs.SetInt("Idioma", cambioIdioma);
            PlayerPrefs.Save();
        }
        else if (cambioIdioma == 1)
        {
            cambioIdioma = 0;
            PlayerPrefs.SetInt("Idioma", cambioIdioma);
            PlayerPrefs.Save();

        }
    
    }

  
    void englishLanguage()
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != null)
            {
                text[i].text = textoIngles[i];
            }
        }
    }

    void spanishLanguage()
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != null)
            {
                text[i].text = textoEspañol[i];
            }
        }
    }
}
