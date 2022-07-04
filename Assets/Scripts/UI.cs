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

    public void ResetButtons_Moscú()
    {
        deselect.onClick.RemoveListener(control.MoscúClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);
    }

    public void ResetButtons_Berna()
    {
        deselect.onClick.RemoveListener(control.BernaClose);
        deselect_go.SetActive(false);
        open_go.SetActive(true);

    }











}
