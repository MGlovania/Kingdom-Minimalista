using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Recursos : MonoBehaviour
{
    public TMP_Text textFps;

    public int cantidadVida;
    public GameObject vida;
   


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
    public int cantidadVecesTrinketsComprados;
    public TMP_Text textoCantidadTrinkets;
    public TMP_Text textoCantidadTrinketsTotales;
    public int cantidadTrinkets;
    public int cantidadTrinketsTotales;
    public int cantidadLaps;
    public TMP_Text textoLaps;
    public int cantidadLapsTotal;
    public TMP_Text textoLapsTotal;
    public GameObject sleeping;
    public GameObject consuming;
    public GameObject awaken;
    public int diasHastaDormir;
    public TMP_Text textoCantidadDiasHastaDormir;

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

    public int cantidadAldeanosAlmacenados;
    public int cantidadAldeanosAlmacenadosPuestosEnArqueria;
    public int cantidadAldeanosAlmacenadosReqParaBonusArqueria;
    public int cantidadAldeanosAlmacenadosPuestosTorreDeMagos;
    public int cantidadAldeanosAlmacenadosReqParaBonusTorreDeMagos;

    public int cantidadMaximaArquerosEnArqueria;

    public int cantidadMagosMax;
    public int cantidadMagosActual;
    public int magosAumentarNumero;
    public int magosDisminuirNumero;

    public int cantidadMaximaMagosEnTorre;

    public int cantidadAldeanosIz;
    public int cantidadAldeanosDer;

    public int cantidadPicarRecursos;

    public int cantidadEnemigos;

    public int cantidadRecursosObtenidosDeConstrucciones;
    public float timeSpawnCasas;
    public float timeSpawnRecursosConstrucciones;



    //  public float fps;


    //CosasParaTrinkets
    public int cantidadEnemigosMatados;
    public int cantidadConstruccionesTotales;

    public int cantidadEnemigosMatadosNecesariosMemoriam;
    public int cantidadEnemigosMatadosNecesariosMemoriam2;
    public float bonusVelocidadMemoriamAumentar;
    public TMP_Text textoBonusMemoriam;
    public TMP_Text textoBonusMemoriam2;
    public int bonusMemoriamMostrarPorNivel;
    public TMP_Text textoBonusMemoriamVelocidadPorNivel;
    public int bonusMemoriamMostrar;
    public int puntoActualizarMemoriam;
    public int puntoIrQuitandoMemoriamAlVender;


    public int cantidadConstruccionesNecesariasParaBabel;
    public int cantidadConstruccionesNecesariasParaBabel2;
    public int dañoMejoraBabelTotal;
    public int dañoMejoraBabel;
    public int dañoMejoraBabel2;
    public TMP_Text textoBonusBabel;
    public TMP_Text textoBonusBabel2;
    public int bonusBabelMostrarPorNivel;
    public TMP_Text textoBonusBabelDañoPorNivel;
    public int puntoActualizarBabel;

    public float timeGanarArmaduraGabriel;
    public TMP_Text textoTimeGanarArmaduraGabriel;
    public int puntoArmaduraGanada;

    public float timeReducirSpawnHourglass;
    public TMP_Text textoTimeReducirSpawnHourglass;
    public int puntoActualizarHourglass;

    public int rangeExplosionNecrotic;
    public TMP_Text textoChanceExplosionNecrotic;

    public int rangeDobleAtaqueCincuenta;
    public TMP_Text textoChanceCincuenta;

    public int rangeDobleAtaqueGlass;
    public TMP_Text textoChanceGlass;

    public int rangeFlechaGoliath;
    public TMP_Text textoChanceGoliath;

    public TMP_Text textoMasDañoFuegoProdigy;
    public TMP_Text textoMasCongelarProdigy;

    public int puntoNoArquerosYCañones;
    public int puntoActualizarElementalist;
    public int actualizarCuandoSeTenga1Arquero;
    public TMP_Text textoDañoElementalNoArqueros;

    public int puntoNoMagosYAlquimistas;
    public int puntoActualizarBarbarian;
    public int actualizarCuandoSeTenga1Mago;
    public TMP_Text textoDañoFisicoNoMagos;

    public int puntoActualizarHoarder;
    public int maderaNecesariaHoarder;
    public int mostrarSpeedHoarder;
    public int mostrarSpeedHoarderTotal;
    public float bonusSpeedHoarder;
    public TMP_Text textoVelocidadHoarder;
    public TMP_Text textoVelocidadHoarderTotal;

    public int dañoUniversal;
    public int dañoFisicoTotal;
    public int dañoElementalTotal;
    public float timeDisparoArqueros;
    public float timeDisparoMagos;
    public int dañoFuego;
    public float tiempoCongelacion;


    public TMP_Text prob1;
    public TMP_Text prob2;
    public TMP_Text prob3;

    public GameObject player;
    void Start()
    {
      
        AudioManager.instance.musicSource.Stop();
        AudioManager.instance.PlayMusic("Ost1");

        cantidadLaps = 0;
        cantidadLapsTotal = 3;
        diasHastaDormir = 0;

        cantidadVida = 1;

        timeDisparoArqueros = 2;
        timeDisparoMagos = 3.5f;

        dañoFisicoTotal = 1;
        dañoElementalTotal = 1;

        dañoFuego = 0;
        tiempoCongelacion = 2;


        bonusVelocidadMemoriamAumentar = 1f;
        cantidadEnemigosMatadosNecesariosMemoriam = 5;
        cantidadEnemigosMatadosNecesariosMemoriam2 = 5;
        bonusMemoriamMostrar = 0;
        bonusMemoriamMostrarPorNivel = 1;

        cantidadConstruccionesNecesariasParaBabel = 3;
        cantidadConstruccionesNecesariasParaBabel2 = 3;
        bonusBabelMostrarPorNivel = 1;

        timeGanarArmaduraGabriel = 55;

        timeReducirSpawnHourglass = 1;

        rangeExplosionNecrotic = 10;

        rangeDobleAtaqueCincuenta = 10;

        rangeDobleAtaqueGlass = 10;

        rangeFlechaGoliath = 2;

        bonusSpeedHoarder = 1;

        cantidadAldeanosAlmacenadosReqParaBonusArqueria = 10;
        cantidadAldeanosAlmacenadosReqParaBonusTorreDeMagos = 10;

           cantidadTrinketsTotales = 4;
           cantidadPicarRecursos = 1;
        cantidadMaximaArquerosEnArqueria = 10;
        cantidadMaximaMagosEnTorre = 5;
        Invoke(nameof(Verif), 0.25f);
    }
   
    void Verif()
    {
        if (cantidadAldeanosAlmacenadosPuestosEnArqueria >= cantidadAldeanosAlmacenadosReqParaBonusArqueria)
        {
            cantidadAldeanosAlmacenadosReqParaBonusArqueria += 10;
            dañoFisicoTotal += 1;
            timeDisparoArqueros /= 1.15f;
        }
        if (cantidadAldeanosAlmacenadosPuestosTorreDeMagos >= cantidadAldeanosAlmacenadosReqParaBonusTorreDeMagos)
        {
            cantidadAldeanosAlmacenadosReqParaBonusTorreDeMagos += 10;
            dañoElementalTotal += 1;
            timeDisparoMagos /= 1.15f;
        }
        prob1.text = cantidadAldeanos.ToString("F0");
         prob2.text = dañoFisicoTotal.ToString("F2");
        // prob3.text = puntoIrQuitandoMemoriamAlVender.ToString("F0");


        Invoke(nameof(Verif), 0.25f);
        textoBonusMemoriam.text = "+" + bonusMemoriamMostrar.ToString("F0") + "%";
        textoBonusMemoriam2.text = "+" + bonusMemoriamMostrar.ToString("F0") + "%";
        textoBonusMemoriamVelocidadPorNivel.text = "+" + bonusMemoriamMostrarPorNivel.ToString("F0") + "%";
        textoBonusBabel.text = "+" + dañoMejoraBabel2.ToString("F0");
        textoBonusBabel2.text = "+" + dañoMejoraBabel.ToString("F0");
        textoBonusBabelDañoPorNivel.text = "+" + bonusBabelMostrarPorNivel.ToString("F0");
        textoTimeGanarArmaduraGabriel.text = timeGanarArmaduraGabriel.ToString("F0") + "s";
        textoTimeReducirSpawnHourglass.text = "-" + timeReducirSpawnHourglass.ToString("F1") + "s";
        textoChanceExplosionNecrotic.text = rangeExplosionNecrotic.ToString("F0") + "%";
        textoChanceCincuenta.text = rangeDobleAtaqueCincuenta.ToString("F0") + "%";
        textoChanceGlass.text = rangeDobleAtaqueGlass.ToString("F0") + "%";
        textoChanceGoliath.text = rangeFlechaGoliath.ToString("F0") + "%";
        textoMasDañoFuegoProdigy.text = "+" + dañoFuego.ToString("F0");
        textoMasCongelarProdigy.text = "+" + (tiempoCongelacion - 2).ToString("F0") + "s";
        textoDañoElementalNoArqueros.text = "+" + (2 * GetComponent<Trinkets>().nivelElementalist).ToString("F0");
        textoDañoFisicoNoMagos.text = "+" + (2 * GetComponent<Trinkets>().nivelBarbarian).ToString("F0");
        textoVelocidadHoarder.text = "+" + mostrarSpeedHoarder.ToString("F0") + "%";
        if (puntoActualizarMemoriam >= 1)
        {
            timeDisparoArqueros *= bonusVelocidadMemoriamAumentar;
            timeDisparoMagos *= bonusVelocidadMemoriamAumentar;
            player.GetComponent<Player>().speed /= bonusVelocidadMemoriamAumentar;
            puntoActualizarMemoriam = 0;
            bonusVelocidadMemoriamAumentar = 1;
            cantidadEnemigosMatadosNecesariosMemoriam = 5;
            cantidadEnemigosMatadosNecesariosMemoriam2 = 5;
            bonusMemoriamMostrar = 1;
            puntoIrQuitandoMemoriamAlVender = 0;
        }
        if (cantidadEnemigosMatados >= cantidadEnemigosMatadosNecesariosMemoriam && GetComponent<Trinkets>().nivelMemoriam >= 1)
        {
            if (GetComponent<Trinkets>().nivelMemoriam >= 1)
            {              
                timeDisparoArqueros /= 1 + (0.01f * GetComponent<Trinkets>().nivelMemoriam);
                timeDisparoMagos /= 1 + (0.01f * GetComponent<Trinkets>().nivelMemoriam);
                player.GetComponent<Player>().speed *= 1 + (0.01f * GetComponent<Trinkets>().nivelMemoriam);
                bonusVelocidadMemoriamAumentar += 0.01f * GetComponent<Trinkets>().nivelMemoriam;
            }
            else
            {
                bonusVelocidadMemoriamAumentar += 0.01f;
                timeDisparoArqueros /= 1.01f;
                timeDisparoMagos /= 1.01f;
                player.GetComponent<Player>().speed *= 1.01f;
            }
            puntoIrQuitandoMemoriamAlVender += 1;
                cantidadEnemigosMatadosNecesariosMemoriam += 5;
        }
        //necesario para mostrar cuanto bonus da si no tenes el trinket
        if (cantidadEnemigosMatados >= cantidadEnemigosMatadosNecesariosMemoriam2)
        {
            if (GetComponent<Trinkets>().nivelMemoriam >= 1)
            {
                bonusMemoriamMostrar += 1 * GetComponent<Trinkets>().nivelMemoriam;
            }
            else
            {
                bonusMemoriamMostrar += 1;
            }
            cantidadEnemigosMatadosNecesariosMemoriam2 += 5;

        }


        if (puntoActualizarBabel >= 1)
        {
            dañoUniversal -= dañoMejoraBabelTotal;
            puntoActualizarBabel = 0;
            dañoMejoraBabel = 0;
            dañoMejoraBabelTotal = 0;
            cantidadConstruccionesNecesariasParaBabel = 3;
            dañoMejoraBabel2 = 0;
        }
        if (cantidadConstruccionesTotales >= cantidadConstruccionesNecesariasParaBabel && GetComponent<Trinkets>().nivelBabel >= 1)
        {
            if (GetComponent<Trinkets>().nivelBabel >= 1)
            {
                dañoUniversal += 1 * GetComponent<Trinkets>().nivelBabel;
                dañoMejoraBabel += 1 * GetComponent<Trinkets>().nivelBabel;
                dañoMejoraBabelTotal += 1 * GetComponent<Trinkets>().nivelBabel;
            }
            else
            {
                dañoMejoraBabel += 1;
                dañoUniversal += 1;
                dañoMejoraBabelTotal += 1;
            }
            cantidadConstruccionesNecesariasParaBabel += 3;
        }
        //necesario para mostrar cuanto bonus da si no tenes el trinket
        if (cantidadConstruccionesTotales >= cantidadConstruccionesNecesariasParaBabel2)
        {
            if (GetComponent<Trinkets>().nivelBabel >= 1)
            {
                dañoMejoraBabel2 += 1 * GetComponent<Trinkets>().nivelBabel;
            }
            else
            {              
                dañoMejoraBabel2 += 1;
            }
            cantidadConstruccionesNecesariasParaBabel2 += 3;

        }



        if (GetComponent<Trinkets>().nivelGabriel >= 1 && puntoArmaduraGanada <= 0)
        {
            puntoArmaduraGanada = 1;
            Invoke(nameof(ObtenerArmadura), timeGanarArmaduraGabriel);
           
        }


        if (GetComponent<Trinkets>().nivelHourglass >= 1 && puntoActualizarHourglass <= 0)
        {
            if (GetComponent<Trinkets>().nivelHourglass >= 2)
            {
                timeReducirSpawnHourglass += 0.5f;
                timeSpawnCasas -= 0.5f;
            }
            else
            {            
                timeSpawnCasas -= timeReducirSpawnHourglass;

            }
            puntoActualizarHourglass = 1;

        }



        if (GetComponent<Trinkets>().nivelElementalist >= 1 && puntoActualizarElementalist <= 0 && cantidadArquerosActual <= 0)
        {
            dañoElementalTotal += 2;
            puntoActualizarElementalist = 1;

        }
        if (cantidadArquerosActual >= 1 && actualizarCuandoSeTenga1Arquero <= 0)
        {
            dañoElementalTotal -= 2 * GetComponent<Trinkets>().nivelElementalist;
            actualizarCuandoSeTenga1Arquero = 1;

        }


        if (GetComponent<Trinkets>().nivelBarbarian >= 1 && puntoActualizarBarbarian <= 0 && cantidadMagosActual <= 0)
        {
            dañoFisicoTotal += 2;
            puntoActualizarBarbarian = 1;

        }
        if (cantidadMagosActual >= 1 && actualizarCuandoSeTenga1Mago <= 0)
        {
            dañoFisicoTotal -= 2 * GetComponent<Trinkets>().nivelBarbarian;
            actualizarCuandoSeTenga1Mago = 1;

        }

       
        
        if (puntoActualizarHoarder >= 1)
        {
            timeDisparoArqueros *= bonusSpeedHoarder;
            timeDisparoMagos *= bonusSpeedHoarder;
            puntoActualizarHoarder = 0;
            bonusSpeedHoarder = 1;
            maderaNecesariaHoarder = 10;
            mostrarSpeedHoarderTotal = 0;
        }
        if (GetComponent<Trinkets>().nivelHoarder >= 1 && cantidadMadera >= maderaNecesariaHoarder)
        {
            if (GetComponent<Trinkets>().nivelHoarder >= 2)
            {
                timeDisparoArqueros /= 1.02f + (0.01f * (GetComponent<Trinkets>().nivelHoarder - 1));
                timeDisparoMagos /= 1.02f + (0.01f * (GetComponent<Trinkets>().nivelHoarder - 1));
                mostrarSpeedHoarderTotal += 2 + (1 * (GetComponent<Trinkets>().nivelHoarder - 1));
                bonusSpeedHoarder += 0.02f + (0.01f * (GetComponent<Trinkets>().nivelHoarder - 1));
            }
            else
            {
                mostrarSpeedHoarderTotal += 2;
                timeDisparoArqueros /= 1.02f;
                timeDisparoMagos /= 1.02f;
                bonusSpeedHoarder += 0.02f;
            }
            maderaNecesariaHoarder += 10;
         
        }
      

        // fps = (int)(1 / Time.unscaledDeltaTime);
        // textFps.text = fps.ToString("F0");
    }
    void ObtenerArmadura()
    {
        if (GetComponent<Trinkets>().nivelGabriel >= 1)
        {
            puntoArmaduraGanada = 0;
            player.GetComponent<Player>().cantidadArmadura += 1;
        }
      
    }
    void Update()
    {
        if (GetComponent<Recursos>().violetasDonados == GetComponent<Recursos>().violetasTotalesADonar && diasHastaDormir <= 0 && cantidadLaps <= 2)
        {
            GetComponent<Recursos>().diasHastaDormir = 3;
            sleeping.SetActive(false);
            consuming.SetActive(true);
            cantidadLaps += 1;
        }



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
        textoCosteTrinketsVioletas.text = costeTrinketsVioletas.ToString("F0");
        textoCantidadTrinkets.text = cantidadTrinkets.ToString("F0");
        textoCantidadTrinketsTotales.text = "/ " + cantidadTrinketsTotales.ToString("F0");
        textoLaps.text = cantidadLaps.ToString("F0");
        textoLapsTotal.text = "/ " + cantidadLapsTotal.ToString("F0");
        textoCantidadDiasHastaDormir.text = diasHastaDormir.ToString("F0");
    }
}
