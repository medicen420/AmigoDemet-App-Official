using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    //Button para abrir SearchBar
    public Button open;
    //Button para cerrar SearchBar
    public Button close;
    //Button para deseleccionar un edificio
    public Button deselect;
    //Button para cerrar panel de wrong name
    //para cuando el usuario tipe un nombre inexistente
    public Button close_panel;

    //AHORA LOS BUTTONS SERÁN DECLARADOS COMO GAMEOBJECTS
    //PARA PODER ACTIVARLOS Y DESACTIVARLOS CUANDO QUERAMOS


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



    public Controller_edificios control;


    public GameObject Panel;




    // Start is called before the first frame update
    void Start()
    {
        //BUTTON PARA ABRIR SEARCHBAR
        open_go.SetActive(true);
        //BUTTON PARA CERRAR SEARCHBAR
        close_go.SetActive(false);
        //BUTTON PARA DESELECCIONAR MI EDIFICIO
        deselect_go.SetActive(false);
        //BUTTON PARA CERRAR PANEL DE WRONG NAME
        close_panel_go.SetActive(false);



        //CANVAS QUE CONTIENE MI SEARCHBAR
        //ESTARÁ DESACTIVADO AL INICIO
        Inputfield.SetActive(false);

        //-----------------------------------------

        //ASIGNACIÓN A LOS MÉTODOS 
        //QUE NOS AYUDARÁN A EJECTURA LAS ACCIONES 
        //DE CADA BOTÓN AL SER PRESIONADOS
        open.onClick.AddListener(OpenSearchBar);
        close.onClick.AddListener(CloseSearchBar);

        Panel.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {


    }


    //COMPORTAMIENTO PARA EL BUTTON VERDE
    //PRIMER MÉTODO
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
    //SEGUNDO MÉTODO
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








    //ESTE MÉTODO NOS FUNCIONA PARA REMOVER EL COMPORTAMIENTO ASIGANDO AL BUTTON AZUL
    //DEPENDIENDO DE EL EDIFICIO QUE ESTE SELECCIONADO SE REMOVERÁ
    //POR LO TANTO CADA COMPORTAMIENTO ESTÁ POR SEPARADO
    public void ResetButtons_Estambul()
    {
        deselect.onClick.RemoveListener(control.EstambulClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************************

    public void ResetButtons_Moscú()
    {
        deselect.onClick.RemoveListener(control.MoscúClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************************
    public void ResetButtons_Berna()
    {
        deselect.onClick.RemoveListener(control.BernaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);

    }
    //***********************************************************************
    public void ResetButtons_Atenas()
    {
        deselect.onClick.RemoveListener(control.AtenasClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************************
    public void ResetButtons_Argel()
    {
        deselect.onClick.RemoveListener(control.ArgelClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************************
    public void ResetButtons_Oslo()
    {
        deselect.onClick.RemoveListener(control.OsloClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**********************************************************************
    public void ResetButtons_Bulgaria()
    {
        deselect.onClick.RemoveListener(control.BulgariaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //****************************************************************************
    public void ResetButtons_Belgrado()
    {
        deselect.onClick.RemoveListener(control.BelgradoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*****************************************************************************

    public void ResetButtons_Seúl()
    {
        deselect.onClick.RemoveListener(control.SeúlClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //****************************************************************************
    public void ResetButtons_Damasco()
    {
        deselect.onClick.RemoveListener(control.DamascoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************************
    public void ResetButtons_Varsovia()
    {
        deselect.onClick.RemoveListener(control.VarsoviaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************************

    public void ResetButtons_Estocolmo()
    {
        deselect.onClick.RemoveListener(control.EstocolmoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //****************************************************************************

    public void ResetButtons_París()
    {
        deselect.onClick.RemoveListener(control.ParísClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************************

    public void ResetButtons_Madrid()
    {
        deselect.onClick.RemoveListener(control.MadridClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************************

    public void ResetButtons_Lisboa()
    {
        deselect.onClick.RemoveListener(control.LisboaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************************

    public void ResetButtons_Roma()
    {
        deselect.onClick.RemoveListener(control.RomaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*************************************************************************

    public void ResetButtons_Bruselas()
    {
        deselect.onClick.RemoveListener(control.BruselasClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************************

    public void ResetButtons_Londres()
    {
        deselect.onClick.RemoveListener(control.LondresClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************************

    public void ResetButtons_Zurich()
    {
        deselect.onClick.RemoveListener(control.ZurichClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**********************************************************************

    public void ResetButtons_Berlín()
    {
        deselect.onClick.RemoveListener(control.BerlínClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //********************************************************************

    public void ResetButtons_Viena()
    {
        deselect.onClick.RemoveListener(control.VienaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //********************************************************************

    public void ResetButtons_Praga()
    {
        deselect.onClick.RemoveListener(control.PragaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*******************************************************************

    public void ResetButtons_Yakarta()
    {
        deselect.onClick.RemoveListener(control.YakartaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*****************************************************************

    public void ResetButtons_Mónaco()
    {
        deselect.onClick.RemoveListener(control.MónacoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //****************************************************************

    public void ResetButtons_Manila()
    {
        deselect.onClick.RemoveListener(control.ManilaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_NuevaDelhi()
    {
        deselect.onClick.RemoveListener(control.NuevaDelhiClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_México()
    {
        deselect.onClick.RemoveListener(control.MéxicoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_Teherán()
    {
        deselect.onClick.RemoveListener(control.TeheránClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_Bombay()
    {
        deselect.onClick.RemoveListener(control.BombayClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************

    public void ResetButtons_Pekín()
    {
        deselect.onClick.RemoveListener(control.PekínClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_Bucarest()
    {
        deselect.onClick.RemoveListener(control.BucarestClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_Copennague()
    {
        deselect.onClick.RemoveListener(control.CopennagueClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_Amsterdam()
    {
        deselect.onClick.RemoveListener(control.AmsterdamClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************

    public void ResetButtons_Saígon()
    {
        deselect.onClick.RemoveListener(control.SaigónClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_Taipéi()
    {
        deselect.onClick.RemoveListener(control.TaipéiClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //****************************************************************

    public void ResetButtons_Tokio()
    {
        deselect.onClick.RemoveListener(control.TokioClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_SanJuan()
    {
        deselect.onClick.RemoveListener(control.SanJuanClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*************************************************************

    public void ResetButtons_Kingston()
    {
        deselect.onClick.RemoveListener(control.KingstonClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*************************************************************

    public void ResetButtons_Habana()
    {
        deselect.onClick.RemoveListener(control.HabanaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*************************************************************

    public void ResetButtons_SanJosé()
    {
        deselect.onClick.RemoveListener(control.SanJoséClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*************************************************************

    public void ResetButtons_Panamá()
    {
        deselect.onClick.RemoveListener(control.PanamáClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_Managua()
    {
        deselect.onClick.RemoveListener(control.ManaguaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_Tegucigalpa()
    {
        deselect.onClick.RemoveListener(control.TegucigalpaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_NuevaYork()
    {
        deselect.onClick.RemoveListener(control.NuevaYorkClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_BuenosAires()
    {
        deselect.onClick.RemoveListener(control.BuenosAiresClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_Otawa()
    {
        deselect.onClick.RemoveListener(control.OtawaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_ElCairo()
    {
        deselect.onClick.RemoveListener(control.ElCairoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_Toronto()
    {
        deselect.onClick.RemoveListener(control.TorontoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_Trípoli()
    {
        deselect.onClick.RemoveListener(control.TrípoliClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_MonteVideo()
    {
        deselect.onClick.RemoveListener(control.MonteVideoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_Luanda()
    {
        deselect.onClick.RemoveListener(control.LuandaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_Santiago()
    {
        deselect.onClick.RemoveListener(control.SantiagoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_Asunción()
    {
        deselect.onClick.RemoveListener(control.AsunciónClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_SanSalvador()
    {
        deselect.onClick.RemoveListener(control.SanSalvadorClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**********************************************************

    public void ResetButtons_Bogotá()
    {
        deselect.onClick.RemoveListener(control.BogotáClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**********************************************************

    public void ResetButtons_Caracas()
    {
        deselect.onClick.RemoveListener(control.CaracasClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_SantoDomingo()
    {
        deselect.onClick.RemoveListener(control.SantoDomingoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_Quito()
    {
        deselect.onClick.RemoveListener(control.QuitoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //************************************************************

    public void ResetButtons_Minesota()
    {
        deselect.onClick.RemoveListener(control.MinesotaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*************************************************************

    public void ResetButtons_Siria()
    {
        deselect.onClick.RemoveListener(control.SiriaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***********************************************************

    public void ResetButtons_Sofía()
    {
        deselect.onClick.RemoveListener(control.SofíaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //****************************************************************

    public void ResetButtons_ElCabo()
    {
        deselect.onClick.RemoveListener(control.ElCaboClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //******************************************************************

    public void ResetButtons_Ankara()
    {
        deselect.onClick.RemoveListener(control.AnkaraClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //******************************************************************

    public void ResetButtons_Túnez()
    {
        deselect.onClick.RemoveListener(control.TúnezClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*****************************************************************

    public void ResetButtons_Singapur()
    {
        deselect.onClick.RemoveListener(control.SingapurClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*****************************************************************

    public void ResetButtons_Eslovaquia()
    {
        deselect.onClick.RemoveListener(control.EslovaquiaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //******************************************************************

    public void ResetButtons_Honolulu()
    {
        deselect.onClick.RemoveListener(control.HonoluluClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //*****************************************************************

    public void ResetButtons_Canberra()
    {
        deselect.onClick.RemoveListener(control.CanberraClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************

    public void ResetButtons_Brasilia()
    {
        deselect.onClick.RemoveListener(control.BrasiliaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_Yokohama()
    {
        deselect.onClick.RemoveListener(control.YokohamaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_Guatemala()
    {
        deselect.onClick.RemoveListener(control.GuatemalaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //**************************************************************

    public void ResetButtons_Washington()
    {
        deselect.onClick.RemoveListener(control.WashingtonClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************

    public void ResetButtons_Dacca()
    {
        deselect.onClick.RemoveListener(control.DaccaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //***************************************************************

    public void ResetButtons_Hamburgo()
    {
        deselect.onClick.RemoveListener(control.HamburgoClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }
    //****************************************************************










}
