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
    void Start()
    {
        nivelCasa = 1;
      
         manager = GameObject.FindGameObjectWithTag("Manager");
   
        cantidadArquerosMax = manager.GetComponent<Recursos>().cantidadMaximaArquerosEnArqueria;
        manager.GetComponent<Recursos>().cantidadArquerosMax += cantidadArquerosMax;
        Invoke(nameof(Verif), 1f);
    }

    void Verif()
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
        Invoke(nameof(Verif), 1f);
    }
    void Update()
    {
     
        textoCantidadArquerosMax.text = "/" + cantidadArquerosMax.ToString("F0");
        textoCantidadArquerosActual.text = cantidadArquerosActual.ToString("F0");
    }
}
