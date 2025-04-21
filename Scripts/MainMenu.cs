using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public Slider musicSlider;
    public Slider sfxSlider;
    public Slider musicSlider2;
    public Slider sfxSlider2;
    public Slider musicSlider3;
    public Slider sfxSlider3;

    public float volumenMusic;
    public float volumenSFX;
    public int puntoPrimeraVezMusic;
    public int puntoPrimeraVezSFX;

    public GameObject panelOpciones;
    public int puntoPanelOpciones;
    void Start()
    {
        volumenMusic = PlayerPrefs.GetFloat("VolumenMusic");
        volumenSFX = PlayerPrefs.GetFloat("VolumenSFX");
        puntoPrimeraVezMusic = PlayerPrefs.GetInt("PuntoPrimeraVezMusic");
        puntoPrimeraVezSFX = PlayerPrefs.GetInt("PuntoPrimeraVezSFX");
        if (puntoPrimeraVezMusic >= 1)
        {
            AudioManager.instance.MusicVolume(volumenMusic);
            musicSlider.value = volumenMusic;
            if (musicSlider2 != null)
            {
                musicSlider2.value = volumenMusic;
            }
            if (musicSlider3 != null)
            {
                musicSlider3.value = volumenMusic;
            }
        }
        if (puntoPrimeraVezSFX >= 1)
        {
            AudioManager.instance.SFXVolume(volumenSFX);
            sfxSlider.value = volumenSFX;
            if (sfxSlider2 != null)
            {
                sfxSlider2.value = volumenSFX;
            }
            if (sfxSlider3 != null)
            {
                sfxSlider3.value = volumenSFX;
            }
        }




        AudioManager.instance.PlayMusic("MainMenuMusic");
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
    public void Quit()
    {
        AudioManager.instance.PlaySFX("Click");
        Application.Quit();
        
    }
    public void Carga()
    {
        AudioManager.instance.PlaySFX("Click");
        SceneManager.LoadScene(1);
    }
    public void MusicVolume()
    {
        AudioManager.instance.PlaySFX("Click");
        AudioManager.instance.MusicVolume(musicSlider.value);
        volumenMusic = musicSlider.value;
        if (musicSlider2 != null)
        {
            musicSlider2.value = volumenMusic;
        }
        if (musicSlider3 != null)
        {
            musicSlider3.value = volumenMusic;
        }
        PlayerPrefs.SetFloat("VolumenMusic", volumenMusic);
        puntoPrimeraVezMusic = 1;
        PlayerPrefs.SetInt("PuntoPrimeraVezMusic", puntoPrimeraVezMusic);
    }
    public void SFXVolume()
    {
        AudioManager.instance.SFXVolume(sfxSlider.value);
        volumenSFX = sfxSlider.value;
        if (sfxSlider2 != null)
        {
            sfxSlider2.value = volumenSFX;
        }
        if (sfxSlider3 != null)
        {
            sfxSlider3.value = volumenSFX;
        }
        PlayerPrefs.SetFloat("VolumenSFX", volumenSFX);
        puntoPrimeraVezSFX = 1;
        PlayerPrefs.SetInt("PuntoPrimeraVezSFX", puntoPrimeraVezSFX);
        AudioManager.instance.PlaySFX("Click");
    }
}
