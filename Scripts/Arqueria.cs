using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Arqueria : MonoBehaviour
{
    public TMP_Text textoCantidadArquerosMax;
    public TMP_Text textoCantidadArquerosActual;

    public int cantidadArquerosMax;
    public int cantidadArquerosActual;
    

   

    public GameObject manager;

    public int nivelCasa;

    public int posIz;
    public int posDer;

    public bool esArqueria;
    public bool esTorreMago;
    void Start()
    {
        nivelCasa = 1;
      
         manager = GameObject.FindGameObjectWithTag("Manager");

        if (esArqueria)
        {
            cantidadArquerosMax = manager.GetComponent<Recursos>().cantidadMaximaArquerosEnArqueria;
            manager.GetComponent<Recursos>().cantidadArquerosMax += cantidadArquerosMax;
        }
        else if (esTorreMago)
        {
            cantidadArquerosMax = manager.GetComponent<Recursos>().cantidadMaximaMagosEnTorre;
            manager.GetComponent<Recursos>().cantidadMagosMax += cantidadArquerosMax;
        }



        Invoke(nameof(Verif), 1f);
    }

    void Verif()
    {
        if (esArqueria)
        {
            if (manager.GetComponent<Recursos>().cantidadAldeanosAlmacenados >= 1 && cantidadArquerosActual < cantidadArquerosMax)
            {
                manager.GetComponent<Recursos>().cantidadAldeanosAlmacenados -= 1;
                cantidadArquerosActual += 1;
                manager.GetComponent<Recursos>().cantidadAldeanosAlmacenadosPuestosEnArqueria += 1;
            }
            else
            {
                if (manager.GetComponent<Recursos>().arqueriaAumentarNumero >= 1 && cantidadArquerosActual < cantidadArquerosMax)
                {
                    cantidadArquerosActual += 1;
                    manager.GetComponent<Recursos>().arqueriaAumentarNumero -= 1;
                }
                if (manager.GetComponent<Recursos>().arqueriaDisminuirNumero >= 1 && cantidadArquerosActual > 0)
                {
                    cantidadArquerosActual -= 1;
                    manager.GetComponent<Recursos>().arqueriaDisminuirNumero -= 1;
                }
            }
          
        }
       else if (esTorreMago)
        {
            if (manager.GetComponent<Recursos>().cantidadAldeanosAlmacenados >= 1 && cantidadArquerosActual < cantidadArquerosMax)
            {
                manager.GetComponent<Recursos>().cantidadAldeanosAlmacenados -= 1;
                cantidadArquerosActual += 1;
                manager.GetComponent<Recursos>().cantidadAldeanosAlmacenadosPuestosTorreDeMagos += 1;
            }
            else
            {
                if (manager.GetComponent<Recursos>().magosAumentarNumero >= 1 && cantidadArquerosActual < cantidadArquerosMax)
                {
                    cantidadArquerosActual += 1;
                    manager.GetComponent<Recursos>().magosAumentarNumero -= 1;
                }
                if (manager.GetComponent<Recursos>().magosDisminuirNumero >= 1 && cantidadArquerosActual > 0)
                {
                    cantidadArquerosActual -= 1;
                    manager.GetComponent<Recursos>().magosDisminuirNumero -= 1;
                }
            }
           
        }

        Invoke(nameof(Verif), 1f);
    }
    void Update()
    {
     
        textoCantidadArquerosMax.text = "/" + cantidadArquerosMax.ToString("F0");
        textoCantidadArquerosActual.text = cantidadArquerosActual.ToString("F0");
    }
}
