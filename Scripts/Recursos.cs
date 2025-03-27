using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Recursos : MonoBehaviour
{
    public TMP_Text textFps;

    public TMP_Text textoPopUpMas;
    public TMP_Text textoPopUpMenos;

    public TMP_Text textoMadera;
    public TMP_Text textoPiedra;
    public TMP_Text textoPlata;
    public TMP_Text textoOro;
    public TMP_Text textoVioleta;

    public TMP_Text textoVioletasDonados;
    public TMP_Text textoVioletasTotalesADonar;
    public int violetasDonados;
    public int violetasTotalesADonar;

    public TMP_Text textoCosteTrinketsVioletas;
    public int costeTrinketsVioletas;

    public int cantidadMadera;
    public int cantidadPiedra;
    public int cantidadPlata;
    public int cantidadOro;
    public int cantidadVioleta;

    public int cantidadAldeanos;
    public int cantidadArquerosMax;
    public int cantidadArquerosActual;
    public int arqueriaAumentarNumero;
    public int arqueriaDisminuirNumero;

    public int cantidadMaximaArquerosEnArqueria;

    public int cantidadAldeanosIz;
    public int cantidadAldeanosDer;

    public int cantidadPicarRecursos;

    public int cantidadEnemigos;

    public int cantidadRecursosObtenidosDeConstrucciones;
    public float timeSpawnCasas;
    public float timeSpawnRecursosConstrucciones;

  

    //  public float fps;


    void Start()
    {
        cantidadPicarRecursos = 1;
        cantidadMaximaArquerosEnArqueria = 10;
        Invoke(nameof(Verif), 1f);
    }

    void Verif()
    {
        Invoke(nameof(Verif), 1f);
       // fps = (int)(1 / Time.unscaledDeltaTime);
       // textFps.text = fps.ToString("F0");
    }
    void Update()
    {
     

        if (Input.GetKeyUp(KeyCode.E))
        {
            Time.timeScale = 15;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Time.timeScale = 1;
        }
        if (cantidadMadera <= 0)
        {
            cantidadMadera = 0;
        }
        if (cantidadPiedra <= 0)
        {
            cantidadPiedra = 0;
        }
        if (cantidadPlata <= 0)
        {
            cantidadPlata = 0;
        }
        if (cantidadOro <= 0)
        {
            cantidadOro = 0;
        }
        if (cantidadVioleta <= 0)
        {
            cantidadVioleta = 0;
        }
        if (cantidadAldeanosIz <= 0)
        {
            cantidadAldeanosIz = 0;
        }
        if (cantidadAldeanosDer <= 0)
        {
            cantidadAldeanosDer = 0;
        }
        if (cantidadAldeanos <= 0)
        {
            cantidadAldeanos = 0;
        }
        if (cantidadArquerosActual <= 0)
        {
            cantidadArquerosActual = 0;
        }
        if (cantidadEnemigos <= 0)
        {
            cantidadEnemigos = 0;
        }
        textoMadera.text = cantidadMadera.ToString("F0");
        textoPiedra.text = cantidadPiedra.ToString("F0");
        textoPlata.text = cantidadPlata.ToString("F0");
        textoOro.text = cantidadOro.ToString("F0");
        textoVioleta.text = cantidadVioleta.ToString("F0");
        textoVioletasDonados.text = violetasDonados.ToString("F0");
        textoVioletasTotalesADonar.text = "/ " + violetasTotalesADonar.ToString("F0");
    }
}
