using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
public class HoverVender : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
  

    public GameObject image;
    public GameObject image2;
    public GameObject texto;
    public GameObject manager;

    public bool memoriam;
    public bool babel;
    public bool gabriel;
    public bool hourglass;
    public bool necrotic;
    public bool cincuenta;
    public bool glass;
    public bool goliath;
    public bool bartholomew;
    public bool prodigy;
    public bool elementalist;
    public bool barbarian;
    public bool hoarder;

    public GameObject recuadroVenderConfirmar;

    public int cantidadVender;

    public int posicion1;
    public int posicion2;
    public int posicion3;
    public int posicion4;

    public int puntoRecuardoVenderConfirmar;

    public GameObject player;
   
    public void VenderConfirmar()
    {
        if (puntoRecuardoVenderConfirmar <= 0)
        {
            puntoRecuardoVenderConfirmar = 1;
            recuadroVenderConfirmar.SetActive(true);
        }
        else
        {
            puntoRecuardoVenderConfirmar = 0;
            recuadroVenderConfirmar.SetActive(false);
        }
     
         

    }
    void QuitarMemoriam()
    {
     
        manager.GetComponent<Recursos>().bonusMemoriamMostrarPorNivel = 1;
        manager.GetComponent<Recursos>().bonusVelocidadMemoriamAumentar = 1;
        manager.GetComponent<Recursos>().bonusMemoriamMostrar = 0;
        manager.GetComponent<Recursos>().cantidadEnemigosMatadosNecesariosMemoriam = 5;
        manager.GetComponent<Recursos>().cantidadEnemigosMatadosNecesariosMemoriam2 = 5;
        manager.GetComponent<Trinkets>().memoriamSelect = 0;
        manager.GetComponent<Trinkets>().nivelMemoriam = 0;
    }
    public void Vender()
    {
        manager.GetComponent<Recursos>().cantidadTrinkets -= 1;
        if (posicion1 == 1)
        {
            posicion1 = 0;
            manager.GetComponent<Trinkets>().puntoTrinket1 = 0;
        }
       else if (posicion2 == 1)
        {
            posicion2 = 0;
            manager.GetComponent<Trinkets>().puntoTrinket2 = 0;
        }
        else if (posicion3 == 1)
        {
            posicion3 = 0;
            manager.GetComponent<Trinkets>().puntoTrinket3 = 0;
        }
        else if (posicion4 == 1)
        {
            posicion4 = 0;
            manager.GetComponent<Trinkets>().puntoTrinket4 = 0;
        }
        if (memoriam)
        {
            for (int i = 0; i < manager.GetComponent<Recursos>().puntoIrQuitandoMemoriamAlVender; i++)
            {
                player.GetComponent<Player>().speed /= 1 + (0.01f * manager.GetComponent<Trinkets>().nivelMemoriam);
                manager.GetComponent<Recursos>().timeDisparoArqueros *= 1 + (0.01f * manager.GetComponent<Trinkets>().nivelMemoriam);
                manager.GetComponent<Recursos>().timeDisparoMagos *= 1 + (0.01f * manager.GetComponent<Trinkets>().nivelMemoriam);
                
            
            }
            Invoke(nameof(QuitarMemoriam), 0.1f);
          
        }
        if (babel)
        {
            manager.GetComponent<Recursos>().bonusBabelMostrarPorNivel = 1;
            manager.GetComponent<Recursos>().dañoUniversal -= manager.GetComponent<Recursos>().dañoMejoraBabelTotal;
            manager.GetComponent<Recursos>().cantidadConstruccionesNecesariasParaBabel = 3;
            manager.GetComponent<Recursos>().cantidadConstruccionesNecesariasParaBabel2 = 3;
            manager.GetComponent<Recursos>().dañoMejoraBabel = 0;
            manager.GetComponent<Recursos>().dañoMejoraBabel2 = 0;
            manager.GetComponent<Recursos>().dañoMejoraBabelTotal = 3;
            manager.GetComponent<Trinkets>().babelSelect = 0;
            manager.GetComponent<Trinkets>().nivelBabel = 0;
        }
        if (gabriel)
        {
            manager.GetComponent<Recursos>().timeGanarArmaduraGabriel = 55;
            manager.GetComponent<Trinkets>().gabrielSelect = 0;
            manager.GetComponent<Trinkets>().nivelGabriel = 0;
        }
        if (hourglass)
        {
            manager.GetComponent<Recursos>().timeSpawnCasas += 1 + (0.5f * manager.GetComponent<Trinkets>().nivelHourglass);
            manager.GetComponent<Recursos>().timeReducirSpawnHourglass = 1;
            manager.GetComponent<Trinkets>().hourglassSelect = 0;
            manager.GetComponent<Trinkets>().nivelHourglass = 0;
        }
        if (necrotic)
        {
            manager.GetComponent<Recursos>().rangeExplosionNecrotic = 10;
            manager.GetComponent<Trinkets>().necroticSelect = 0;
            manager.GetComponent<Trinkets>().nivelNecrotic = 0;
        }
        if (cincuenta)
        {
            manager.GetComponent<Recursos>().rangeDobleAtaqueCincuenta = 10;
            manager.GetComponent<Trinkets>().cincuentaSelect = 0;
            manager.GetComponent<Trinkets>().nivelCincuenta = 0;
        }
        if (glass)
        {
            manager.GetComponent<Recursos>().rangeDobleAtaqueGlass = 10;
            manager.GetComponent<Trinkets>().glassSelect = 0;
            manager.GetComponent<Trinkets>().nivelGlass = 0;
        }
        if (goliath)
        {
            manager.GetComponent<Recursos>().rangeFlechaGoliath = 2;
            manager.GetComponent<Trinkets>().goliathSelect = 0;
            manager.GetComponent<Trinkets>().nivelGoliath = 0;
        }
        if (bartholomew)
        {
            manager.GetComponent<Trinkets>().bartholomewSelect = 0;
            manager.GetComponent<Trinkets>().nivelBartholomew = 0;
        }
        if (prodigy)
        {
            manager.GetComponent<Recursos>().dañoFuego = 0;
            manager.GetComponent<Recursos>().tiempoCongelacion = 2;
            manager.GetComponent<Trinkets>().prodigySelect = 0;
            manager.GetComponent<Trinkets>().nivelProdigy = 0;
        }
        if (elementalist)
        {
            manager.GetComponent<Recursos>().dañoElementalTotal -= (2 * manager.GetComponent<Trinkets>().nivelElementalist);
            manager.GetComponent<Trinkets>().elementalistSelect = 0;
            manager.GetComponent<Trinkets>().nivelElementalist = 0;
        }
        if (barbarian)
        {
            manager.GetComponent<Recursos>().dañoFisicoTotal -= (2 * manager.GetComponent<Trinkets>().nivelBarbarian);
            manager.GetComponent<Trinkets>().barbarianSelect = 0;
            manager.GetComponent<Trinkets>().nivelBarbarian = 0;
        }
        if (hoarder)
        {
            for (int i = 0; i < (manager.GetComponent<Recursos>().maderaNecesariaHoarder / 10); i++)
            {
                if (manager.GetComponent<Trinkets>().nivelHoarder >= 2)
                {
                    manager.GetComponent<Recursos>().timeDisparoArqueros *= 1.02f + (0.01f * (manager.GetComponent<Trinkets>().nivelHoarder - 1));
                    manager.GetComponent<Recursos>().timeDisparoMagos *= 1.02f + (0.01f * (manager.GetComponent<Trinkets>().nivelHoarder - 1));
                }
                else
                {
                    manager.GetComponent<Recursos>().timeDisparoArqueros *= 1.02f;
                    manager.GetComponent<Recursos>().timeDisparoMagos *= 1.02f;
                }
            }
            Invoke(nameof(QuitarHoarder), 0.1f);
          
        }
        manager.GetComponent<Recursos>().cantidadVioleta += manager.GetComponent<Recursos>().cantidadVecesTrinketsComprados;
        recuadroVenderConfirmar.SetActive(false);
        image.SetActive(false);
        image2.SetActive(false);
        gameObject.SetActive(false);
        
    }
    void QuitarHoarder()
    {
        manager.GetComponent<Recursos>().mostrarSpeedHoarder = 0;
        manager.GetComponent<Recursos>().mostrarSpeedHoarderTotal = 0;
        manager.GetComponent<Recursos>().maderaNecesariaHoarder = 10;
        manager.GetComponent<Recursos>().bonusSpeedHoarder = 1;
        manager.GetComponent<Trinkets>().hoarderSelect = 0;
        manager.GetComponent<Trinkets>().nivelHoarder = 0;
    }
    public void Cancelar()
    {

     
        recuadroVenderConfirmar.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        texto.GetComponent<TMP_Text>().text = manager.GetComponent<Recursos>().cantidadVecesTrinketsComprados.ToString("F0");
     
        image.SetActive(true);
        image2.SetActive(true);

    }

    public void OnPointerExit(PointerEventData eventData)
    {
      
        image.SetActive(false);
        image2.SetActive(false);
    }
}
