using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{

    public Image sliderCarga;
    public GameObject textoCarga;
  
    public GameObject canvasMenu;
    public GameObject canvasMain;
    public GameObject mapa;
    public GameObject mainRun;
    public int puntoQuitarCarga;
    void Start()
    {
        
    }
    public void CargarMapa()
    {
        textoCarga.SetActive(true);
        canvasMenu.SetActive(false);
     
        mapa.SetActive(true);
        mainRun.SetActive(true);
        Invoke(nameof(QuitarCarga), 1.5f);
    
    }
    void QuitarCarga()
    {
        textoCarga.SetActive(false);
        canvasMain.SetActive(true);
        puntoQuitarCarga = 1;
    }
    void Update()
    {
        if (puntoQuitarCarga >= 1)
        {
            sliderCarga.GetComponent<Image>().fillAmount -= 0.0085f;
        }
    }
}
