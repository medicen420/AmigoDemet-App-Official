using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    //Button para abrir panel de opciones
    public Button open_panel_options;



    //Button para abrir SearchBar
    public Button open;
    //Button para cerrar SearchBar
    public Button close;
    //Button para deseleccionar un edificio
    public Button deselect;
    //Button para cerrar panel de wrong name
    //para cuando el usuario tipe un nombre inexistente
    public Button close_panel;

    //AHORA LOS BUTTONS SER�N DECLARADOS COMO GAMEOBJECTS
    //PARA PODER ACTIVARLOS Y DESACTIVARLOS CUANDO QUERAMOS



    //BUTTON ABRIR PANEL OPCIONES
    //BUTTON GRIS
    public GameObject open_pan_op;



    //BUTTON VERDE
    public GameObject open_go;
    //BUTTON ROJO
    public GameObject close_go;
    //BUTTON AZUL
    public GameObject deselect_go;
    //BUTTON AMARILLO
    public GameObject close_panel_go;



    //SEARCH BAR
    public GameObject Inputfield;
    //PANEL DE OPCIONES
    public GameObject Panel_op;



    //public Controller_edificios control;
    public SearchBar sear_b;


    public GameObject Panel;



    // Start is called before the first frame update
    void Start()
    {
        
        //BUTTON PARA ABRIR BARRA DE OPCIONES 
        //PARA BUSCAR EDIFICIOS
        


        //BUTTON PARA ABRIR SEARCHBAR
        open_go.SetActive(true);
        //BUTTON PARA CERRAR SEARCHBAR
        close_go.SetActive(false);
        //BUTTON PARA DESELECCIONAR MI EDIFICIO
        deselect_go.SetActive(false);
        //BUTTON PARA CERRAR PANEL DE WRONG NAME
        close_panel_go.SetActive(false);



        //CANVAS QUE CONTIENE MI SEARCHBAR
        //ESTAR� DESACTIVADO AL INICIO
        Inputfield.SetActive(false);

        //-----------------------------------------

        //ASIGNACI�N A LOS M�TODOS 
        //QUE NOS AYUDAR�N A EJECTURA LAS ACCIONES 
        //DE CADA BOT�N AL SER PRESIONADOS

        //BUtton para abrir panel de opciones para b�squeda de edificios
        open_panel_options.onClick.AddListener(OpenPanelOp);
        //**************************************************************
        //Button para abrir SearchBar
        open.onClick.AddListener(OpenSearchBar);
        //Button para cerrar SearchBar
        close.onClick.AddListener(CloseSearchBar);

        //Panel Error_Name
        Panel.SetActive(false);
        //Panel Opciones
        Panel_op.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {


    }


    public void OpenPanelOp()
    {
        Panel_op.SetActive(true);
    }

    //COMPORTAMIENTO PARA EL BUTTON VERDE
    //PRIMER M�TODO
    //ABRIR MI SEARCH BAR
    public void OpenSearchBar()
    {

        //Mensaje en la consola
        print("<color=yellow> Has abierto la SearchBar </color>");
        //BUTTON VERDE SE DESACTIVA
        open_go.SetActive(false);
        //BUTTON ROJO SE ACTIVA
        close_go.SetActive(true);
        Inputfield.SetActive(true);


    }


    //COMPORTAMIENTO PARA EL BUTTON ROJO
    //SEGUNDO M�TODO
    //CERRAR MI SEARCH BAR
    public void CloseSearchBar()
    {
        //Mensaje en la consola
        print("<color=red> Has cerrado la SearchBar </color>");

        //BUTTON ROJO SE DESACTIVA
        close_go.SetActive(false);
        //BUTTON VERDE SE ACTIVA
        open_go.SetActive(true);
        //DESACTIVAMOS LA SEARCH BAR
        Inputfield.SetActive(false);

    }
    //------------------------------------------------------------------







    //COMPORTAMIENTO QUE SE ENCARGA DE 
    //CERRAR EL BUTTON CLOSE Y ACTIVAR EL BUTTON AZUL
    public void ResetButtons_1()
    {
        //BUTTON ROJO SE DESACTIVA
        close_go.SetActive(false);
        //BUTTON AZUL SE ACTIVA
        //PERO NO LE HEMOS ASIGANDO UN COMPORTAMIENTO
        deselect_go.SetActive(true);

    }








    //ESTE M�TODO NOS FUNCIONA PARA REMOVER EL COMPORTAMIENTO ASIGANDO AL BUTTON AZUL
    //DEPENDIENDO DE EL EDIFICIO QUE ESTE SELECCIONADO SE REMOVER�
    //POR LO TANTO CADA COMPORTAMIENTO EST� POR SEPARADO
    public void ResetButtons_Estambul()
    {
        deselect.onClick.RemoveListener(sear_b.EstambulClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************************

    public void ResetButtons_Mosc�()
    {
        deselect.onClick.RemoveListener(sear_b.Mosc�Close);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************************
    public void ResetButtons_Berna()
    {
        deselect.onClick.RemoveListener(sear_b.BernaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);

    }
    //***********************************************************************
    public void ResetButtons_Atenas()
    {
        deselect.onClick.RemoveListener(sear_b.AtenasClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************************
    public void ResetButtons_Argel()
    {
        deselect.onClick.RemoveListener(sear_b.ArgelClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************************
    public void ResetButtons_Oslo()
    {
        deselect.onClick.RemoveListener(sear_b.OsloClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**********************************************************************
    public void ResetButtons_Bulgaria()
    {
        deselect.onClick.RemoveListener(sear_b.BulgariaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //****************************************************************************
    public void ResetButtons_Belgrado()
    {
        deselect.onClick.RemoveListener(sear_b.BelgradoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*****************************************************************************

    public void ResetButtons_Se�l()
    {
        deselect.onClick.RemoveListener(sear_b.Se�lClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //****************************************************************************
    public void ResetButtons_Damasco()
    {
        deselect.onClick.RemoveListener(sear_b.DamascoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************************
    public void ResetButtons_Varsovia()
    {
        deselect.onClick.RemoveListener(sear_b.VarsoviaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************************

    public void ResetButtons_Estocolmo()
    {
        deselect.onClick.RemoveListener(sear_b.EstocolmoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //****************************************************************************

    public void ResetButtons_Par�s()
    {
        deselect.onClick.RemoveListener(sear_b.Par�sClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************************

    public void ResetButtons_Madrid()
    {
        deselect.onClick.RemoveListener(sear_b.MadridClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************************

    public void ResetButtons_Lisboa()
    {
        deselect.onClick.RemoveListener(sear_b.LisboaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************************

    public void ResetButtons_Roma()
    {
        deselect.onClick.RemoveListener(sear_b.RomaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*************************************************************************

    public void ResetButtons_Bruselas()
    {
        deselect.onClick.RemoveListener(sear_b.BruselasClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************************

    public void ResetButtons_Londres()
    {
        deselect.onClick.RemoveListener(sear_b.LondresClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************************

    public void ResetButtons_Zurich()
    {
        deselect.onClick.RemoveListener(sear_b.ZurichClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**********************************************************************

    public void ResetButtons_Berl�n()
    {
        deselect.onClick.RemoveListener(sear_b.Berl�nClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //********************************************************************

    public void ResetButtons_Viena()
    {
        deselect.onClick.RemoveListener(sear_b.VienaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //********************************************************************

    public void ResetButtons_Praga()
    {
        deselect.onClick.RemoveListener(sear_b.PragaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*******************************************************************

    public void ResetButtons_Yakarta()
    {
        deselect.onClick.RemoveListener(sear_b.YakartaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*****************************************************************

    public void ResetButtons_M�naco()
    {
        deselect.onClick.RemoveListener(sear_b.M�nacoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //****************************************************************

    public void ResetButtons_Manila()
    {
        deselect.onClick.RemoveListener(sear_b.ManilaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_NuevaDelhi()
    {
        deselect.onClick.RemoveListener(sear_b.NuevaDelhiClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_M�xico()
    {
        deselect.onClick.RemoveListener(sear_b.M�xicoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_Teher�n()
    {
        deselect.onClick.RemoveListener(sear_b.Teher�nClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_Bombay()
    {
        deselect.onClick.RemoveListener(sear_b.BombayClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************

    public void ResetButtons_Pek�n()
    {
        deselect.onClick.RemoveListener(sear_b.Pek�nClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_Bucarest()
    {
        deselect.onClick.RemoveListener(sear_b.BucarestClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_Copennague()
    {
        deselect.onClick.RemoveListener(sear_b.CopennagueClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_Amsterdam()
    {
        deselect.onClick.RemoveListener(sear_b.AmsterdamClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************

    public void ResetButtons_Sa�gon()
    {
        deselect.onClick.RemoveListener(sear_b.Saig�nClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_Taip�i()
    {
        deselect.onClick.RemoveListener(sear_b.Taip�iClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //****************************************************************

    public void ResetButtons_Tokio()
    {
        deselect.onClick.RemoveListener(sear_b.TokioClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_SanJuan()
    {
        deselect.onClick.RemoveListener(sear_b.SanJuanClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*************************************************************

    public void ResetButtons_Kingston()
    {
        deselect.onClick.RemoveListener(sear_b.KingstonClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*************************************************************

    public void ResetButtons_Habana()
    {
        deselect.onClick.RemoveListener(sear_b.HabanaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*************************************************************

    public void ResetButtons_SanJos�()
    {
        deselect.onClick.RemoveListener(sear_b.SanJos�Close);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*************************************************************

    public void ResetButtons_Panam�()
    {
        deselect.onClick.RemoveListener(sear_b.Panam�Close);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_Managua()
    {
        deselect.onClick.RemoveListener(sear_b.ManaguaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_Tegucigalpa()
    {
        deselect.onClick.RemoveListener(sear_b.TegucigalpaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_NuevaYork()
    {
        deselect.onClick.RemoveListener(sear_b.NuevaYorkClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_BuenosAires()
    {
        deselect.onClick.RemoveListener(sear_b.BuenosAiresClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_Otawa()
    {
        deselect.onClick.RemoveListener(sear_b.OtawaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_ElCairo()
    {
        deselect.onClick.RemoveListener(sear_b.ElCairoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_Toronto()
    {
        deselect.onClick.RemoveListener(sear_b.TorontoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_Tr�poli()
    {
        deselect.onClick.RemoveListener(sear_b.Tr�poliClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_MonteVideo()
    {
        deselect.onClick.RemoveListener(sear_b.MonteVideoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_Luanda()
    {
        deselect.onClick.RemoveListener(sear_b.LuandaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_Santiago()
    {
        deselect.onClick.RemoveListener(sear_b.SantiagoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_Asunci�n()
    {
        deselect.onClick.RemoveListener(sear_b.Asunci�nClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_SanSalvador()
    {
        deselect.onClick.RemoveListener(sear_b.SanSalvadorClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**********************************************************

    public void ResetButtons_Bogot�()
    {
        deselect.onClick.RemoveListener(sear_b.Bogot�Close);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**********************************************************

    public void ResetButtons_Caracas()
    {
        deselect.onClick.RemoveListener(sear_b.CaracasClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_SantoDomingo()
    {
        deselect.onClick.RemoveListener(sear_b.SantoDomingoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_Quito()
    {
        deselect.onClick.RemoveListener(sear_b.QuitoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_Minesota()
    {
        deselect.onClick.RemoveListener(sear_b.MinesotaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*************************************************************

    public void ResetButtons_Siria()
    {
        deselect.onClick.RemoveListener(sear_b.SiriaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_Sof�a()
    {
        deselect.onClick.RemoveListener(sear_b.Sof�aClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //****************************************************************

    public void ResetButtons_ElCabo()
    {
        deselect.onClick.RemoveListener(sear_b.ElCaboClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //******************************************************************

    public void ResetButtons_Ankara()
    {
        deselect.onClick.RemoveListener(sear_b.AnkaraClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //******************************************************************

    public void ResetButtons_T�nez()
    {
        deselect.onClick.RemoveListener(sear_b.T�nezClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*****************************************************************

    public void ResetButtons_Singapur()
    {
        deselect.onClick.RemoveListener(sear_b.SingapurClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*****************************************************************

    public void ResetButtons_Eslovaquia()
    {
        deselect.onClick.RemoveListener(sear_b.EslovaquiaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //******************************************************************

    public void ResetButtons_Honolulu()
    {
        deselect.onClick.RemoveListener(sear_b.HonoluluClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*****************************************************************

    public void ResetButtons_Canberra()
    {
        deselect.onClick.RemoveListener(sear_b.CanberraClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************

    public void ResetButtons_Brasilia()
    {
        deselect.onClick.RemoveListener(sear_b.BrasiliaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_Yokohama()
    {
        deselect.onClick.RemoveListener(sear_b.YokohamaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_Guatemala()
    {
        deselect.onClick.RemoveListener(sear_b.GuatemalaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_Washington()
    {
        deselect.onClick.RemoveListener(sear_b.WashingtonClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************

    public void ResetButtons_Dacca()
    {
        deselect.onClick.RemoveListener(sear_b.DaccaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************

    public void ResetButtons_Hamburgo()
    {
        deselect.onClick.RemoveListener(sear_b.HamburgoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //****************************************************************










}
